using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace Auth.GG_Winform_Example
{
	// Token: 0x02000006 RID: 6
	internal class Constants
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00184130 File Offset: 0x0017EF30
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00184137 File Offset: 0x0017EF37
		public static string Token { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00184142 File Offset: 0x0017EF42
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00184149 File Offset: 0x0017EF49
		public static string Date
		{
			get
			{
				return Constants.<Date>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				Constants.<Date>k__BackingField = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00184154 File Offset: 0x0017EF54
		// (set) Token: 0x0600001D RID: 29 RVA: 0x0018415B File Offset: 0x0017EF5B
		public static string APIENCRYPTKEY { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00184166 File Offset: 0x0017EF66
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0018416D File Offset: 0x0017EF6D
		public static string APIENCRYPTSALT
		{
			[CompilerGenerated]
			get
			{
				return Constants.<APIENCRYPTSALT>k__BackingField;
			}
			set
			{
				Constants.<APIENCRYPTSALT>k__BackingField = value;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00184178 File Offset: 0x0017EF78
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", length)
			select s[Constants.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000021 RID: 33 RVA: 0x001841B6 File Offset: 0x0017EFB6
		public static string HWID()
		{
			return WindowsIdentity.GetCurrent().User.Value;
		}

		// Token: 0x04000012 RID: 18
		public static bool Breached = false;

		// Token: 0x04000013 RID: 19
		public static bool Started = false;

		// Token: 0x04000014 RID: 20
		public static string IV = null;

		// Token: 0x04000015 RID: 21
		public static string Key = null;

		// Token: 0x04000016 RID: 22
		public static string ApiUrl = "https://api.auth.gg/csharp/";

		// Token: 0x04000017 RID: 23
		public static bool Initialized = false;

		// Token: 0x04000018 RID: 24
		public static Random random = new Random();
	}
}
