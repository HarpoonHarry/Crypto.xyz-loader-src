using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace KeyAuth
{
	// Token: 0x02000005 RID: 5
	public class api
	{
		// Token: 0x06000015 RID: 21 RVA: 0x001AABC0 File Offset: 0x001A47C0
		public api(string name, string ownerid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				api.error("Application not setup correctly.");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x001AAC6C File Offset: 0x001A486C
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			if (text2 == "KeyAuth_Invalid")
			{
				api.error("Application not found");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (response_structure.success)
			{
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
				return;
			}
			if (response_structure.message == "invalidver")
			{
				Process.Start(response_structure.download);
				Environment.Exit(0);
				return;
			}
			api.error(response_structure.message);
			Environment.Exit(0);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x001AAE50 File Offset: 0x001A4A50
		public bool register(string username, string pass, string key)
		{
			if (!this.initzalized)
			{
				MessageBox.Show("Failed to register!");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				return false;
			}
			this.load_user_data(response_structure.info);
			return true;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x001AB030 File Offset: 0x001A4C30
		public bool login(string username, string pass)
		{
			if (!this.initzalized)
			{
				MessageBox.Show("Failed to login");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				return false;
			}
			this.load_user_data(response_structure.info);
			return true;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x001AB1EC File Offset: 0x001A4DEC
		public void setvar(string var, string data)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["data"] = encryption.encrypt(data, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x001AB360 File Offset: 0x001A4F60
		public string getvar(string var)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				return null;
			}
			return response_structure.response;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x001AB4C0 File Offset: 0x001A50C0
		public void ban()
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x001AB5F4 File Offset: 0x001A51F4
		public string var(string varid)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				return null;
			}
			return response_structure.message;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x001AB764 File Offset: 0x001A5364
		public List<api.msg> chatget(string channelname)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
				return null;
			}
			return response_structure.messages;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x001AB8C4 File Offset: 0x001A54C4
		public bool chatsend(string msg, string channelname)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(msg, this.enckey, text);
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				return false;
			}
			return true;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x001ABA3C File Offset: 0x001A563C
		public bool checkblack()
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			return this.response_decoder.string_to_generic<api.response_structure>(text2).success;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x001ABB90 File Offset: 0x001A5790
		public void webhook(string webid, string param)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
			nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x001ABD04 File Offset: 0x001A5904
		public byte[] download(string fileid)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first. File is empty since no request could be made.");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			string text2 = api.req(nameValueCollection);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (!response_structure.success)
			{
				api.error(response_structure.message);
				Environment.Exit(0);
			}
			return encryption.str_to_byte_arr(response_structure.contents);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x001ABE68 File Offset: 0x001A5A68
		public void log(string message)
		{
			if (!this.initzalized)
			{
				api.error("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
			nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			api.req(nameValueCollection);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x001ABF88 File Offset: 0x001A5B88
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					result = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x001AA11E File Offset: 0x001A3D1E
		public static void error(string message)
		{
			MessageBox.Show(message);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x001AC018 File Offset: 0x001A5C18
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				if (((HttpWebResponse)ex.Response).StatusCode == (HttpStatusCode)429)
				{
					api.error("You're connecting too fast to loader, slow down.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x001AC0DC File Offset: 0x001A5CDC
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x0400000C RID: 12
		public string name;

		// Token: 0x0400000D RID: 13
		public string ownerid;

		// Token: 0x0400000E RID: 14
		public string secret;

		// Token: 0x0400000F RID: 15
		public string version;

		// Token: 0x04000010 RID: 16
		private string sessionid;

		// Token: 0x04000011 RID: 17
		private string enckey;

		// Token: 0x04000012 RID: 18
		private bool initzalized;

		// Token: 0x04000013 RID: 19
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x04000014 RID: 20
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x0200000C RID: 12
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600006C RID: 108 RVA: 0x001AA584 File Offset: 0x001A4184
			// (set) Token: 0x0600006D RID: 109 RVA: 0x001AA58F File Offset: 0x001A418F
			[DataMember]
			public bool success
			{
				[CompilerGenerated]
				get
				{
					return this.<success>k__BackingField;
				}
				set
				{
					this.<success>k__BackingField = value;
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600006E RID: 110 RVA: 0x001AA59E File Offset: 0x001A419E
			// (set) Token: 0x0600006F RID: 111 RVA: 0x001AA5A9 File Offset: 0x001A41A9
			[DataMember]
			public string sessionid
			{
				get
				{
					return this.<sessionid>k__BackingField;
				}
				set
				{
					this.<sessionid>k__BackingField = value;
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000070 RID: 112 RVA: 0x001AA5B8 File Offset: 0x001A41B8
			// (set) Token: 0x06000071 RID: 113 RVA: 0x001AA5C3 File Offset: 0x001A41C3
			[DataMember]
			public string contents
			{
				get
				{
					return this.<contents>k__BackingField;
				}
				set
				{
					this.<contents>k__BackingField = value;
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000072 RID: 114 RVA: 0x001AA5D2 File Offset: 0x001A41D2
			// (set) Token: 0x06000073 RID: 115 RVA: 0x001AA5DD File Offset: 0x001A41DD
			[DataMember]
			public string response
			{
				get
				{
					return this.<response>k__BackingField;
				}
				set
				{
					this.<response>k__BackingField = value;
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000074 RID: 116 RVA: 0x001AA5EC File Offset: 0x001A41EC
			// (set) Token: 0x06000075 RID: 117 RVA: 0x001AA5F7 File Offset: 0x001A41F7
			[DataMember]
			public string message
			{
				get
				{
					return this.<message>k__BackingField;
				}
				set
				{
					this.<message>k__BackingField = value;
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000076 RID: 118 RVA: 0x001AA606 File Offset: 0x001A4206
			// (set) Token: 0x06000077 RID: 119 RVA: 0x001AA611 File Offset: 0x001A4211
			[DataMember]
			public string download
			{
				get
				{
					return this.<download>k__BackingField;
				}
				set
				{
					this.<download>k__BackingField = value;
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000078 RID: 120 RVA: 0x001AA620 File Offset: 0x001A4220
			// (set) Token: 0x06000079 RID: 121 RVA: 0x001AA62B File Offset: 0x001A422B
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info
			{
				get
				{
					return this.<info>k__BackingField;
				}
				set
				{
					this.<info>k__BackingField = value;
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600007A RID: 122 RVA: 0x001AA63A File Offset: 0x001A423A
			// (set) Token: 0x0600007B RID: 123 RVA: 0x001AA645 File Offset: 0x001A4245
			[DataMember]
			public List<api.msg> messages { get; set; }
		}

		// Token: 0x0200000D RID: 13
		public class msg
		{
			// Token: 0x1700000E RID: 14
			// (get) Token: 0x0600007D RID: 125 RVA: 0x001AA654 File Offset: 0x001A4254
			// (set) Token: 0x0600007E RID: 126 RVA: 0x001AA65F File Offset: 0x001A425F
			public string message { get; set; }

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x0600007F RID: 127 RVA: 0x001AA66E File Offset: 0x001A426E
			// (set) Token: 0x06000080 RID: 128 RVA: 0x001AA679 File Offset: 0x001A4279
			public string author { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000081 RID: 129 RVA: 0x001AA688 File Offset: 0x001A4288
			// (set) Token: 0x06000082 RID: 130 RVA: 0x001AA693 File Offset: 0x001A4293
			public string timestamp { get; set; }
		}

		// Token: 0x0200000E RID: 14
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000084 RID: 132 RVA: 0x001AA6A2 File Offset: 0x001A42A2
			// (set) Token: 0x06000085 RID: 133 RVA: 0x001AA6AD File Offset: 0x001A42AD
			[DataMember]
			public string username
			{
				[CompilerGenerated]
				get
				{
					return this.<username>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<username>k__BackingField = value;
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000086 RID: 134 RVA: 0x001AA6BC File Offset: 0x001A42BC
			// (set) Token: 0x06000087 RID: 135 RVA: 0x001AA6C7 File Offset: 0x001A42C7
			[DataMember]
			public string ip
			{
				[CompilerGenerated]
				get
				{
					return this.<ip>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<ip>k__BackingField = value;
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000088 RID: 136 RVA: 0x001AA6D6 File Offset: 0x001A42D6
			// (set) Token: 0x06000089 RID: 137 RVA: 0x001AA6E1 File Offset: 0x001A42E1
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600008A RID: 138 RVA: 0x001AA6F0 File Offset: 0x001A42F0
			// (set) Token: 0x0600008B RID: 139 RVA: 0x001AA6FB File Offset: 0x001A42FB
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x0600008C RID: 140 RVA: 0x001AA70A File Offset: 0x001A430A
			// (set) Token: 0x0600008D RID: 141 RVA: 0x001AA715 File Offset: 0x001A4315
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x0600008E RID: 142 RVA: 0x001AA724 File Offset: 0x001A4324
			// (set) Token: 0x0600008F RID: 143 RVA: 0x001AA72F File Offset: 0x001A432F
			[DataMember]
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x0400006A RID: 106
			private string <username>k__BackingField;

			// Token: 0x0400006B RID: 107
			private string <ip>k__BackingField;
		}

		// Token: 0x0200000F RID: 15
		public class user_data_class
		{
			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000091 RID: 145 RVA: 0x001AA73E File Offset: 0x001A433E
			// (set) Token: 0x06000092 RID: 146 RVA: 0x001AA749 File Offset: 0x001A4349
			public string username { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000093 RID: 147 RVA: 0x001AA758 File Offset: 0x001A4358
			// (set) Token: 0x06000094 RID: 148 RVA: 0x001AA763 File Offset: 0x001A4363
			public string ip { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000095 RID: 149 RVA: 0x001AA772 File Offset: 0x001A4372
			// (set) Token: 0x06000096 RID: 150 RVA: 0x001AA77D File Offset: 0x001A437D
			public string hwid { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000097 RID: 151 RVA: 0x001AA78C File Offset: 0x001A438C
			// (set) Token: 0x06000098 RID: 152 RVA: 0x001AA797 File Offset: 0x001A4397
			public string createdate { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000099 RID: 153 RVA: 0x001AA7A6 File Offset: 0x001A43A6
			// (set) Token: 0x0600009A RID: 154 RVA: 0x001AA7B1 File Offset: 0x001A43B1
			public string lastlogin { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x0600009B RID: 155 RVA: 0x001AA7C0 File Offset: 0x001A43C0
			// (set) Token: 0x0600009C RID: 156 RVA: 0x001AA7CB File Offset: 0x001A43CB
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000010 RID: 16
		public class Data
		{
			// Token: 0x1700001D RID: 29
			// (get) Token: 0x0600009E RID: 158 RVA: 0x001AA7DA File Offset: 0x001A43DA
			// (set) Token: 0x0600009F RID: 159 RVA: 0x001AA7E5 File Offset: 0x001A43E5
			public string subscription { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000A0 RID: 160 RVA: 0x001AA7F4 File Offset: 0x001A43F4
			// (set) Token: 0x060000A1 RID: 161 RVA: 0x001AA7FF File Offset: 0x001A43FF
			public string expiry { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000A2 RID: 162 RVA: 0x001AA80E File Offset: 0x001A440E
			// (set) Token: 0x060000A3 RID: 163 RVA: 0x001AA819 File Offset: 0x001A4419
			public string timeleft { get; set; }
		}
	}
}
