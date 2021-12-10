using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200000B RID: 11
	internal class Security
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00186720 File Offset: 0x00181520
		public static string Signature(string value)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				byte[] bytes = Encoding.UTF8.GetBytes(value);
				result = BitConverter.ToString(md.ComputeHash(bytes)).Replace("-", "");
			}
			return result;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00186794 File Offset: 0x00181594
		private static string Session(int length)
		{
			Random random = new Random();
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz", length)
			select s[random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600005A RID: 90 RVA: 0x001867E4 File Offset: 0x001815E4
		public static string Obfuscate(int length)
		{
			Random random = new Random();
			return new string((from s in Enumerable.Repeat<string>("gd8JQ57nxXzLLMPrLylVhxoGnWGCFjO4knKTfRE6mVvdjug2NF/4aptAsZcdIGbAPmcx0O+ftU/KvMIjcfUnH3j+IMdhAW5OpoX3MrjQdf5AAP97tTB5g1wdDSAqKpq9gw06t3VaqMWZHKtPSuAXy0kkZRsc+DicpcY8E9+vWMHXa3jMdbPx4YES0p66GzhqLd/heA2zMvX8iWv4wK7S3QKIW/a9dD4ALZJpmcr9OOE=", length)
			select s[random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00186834 File Offset: 0x00181634
		public static void Start()
		{
			string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
			if (Constants.Started)
			{
				MessageBox.Show("A session has already been started, please end the previous one!", OnProgramStart.Name);
				Process.GetCurrentProcess().Kill();
				return;
			}
			using (StreamReader streamReader = new StreamReader(pathRoot + "Windows\\System32\\drivers\\etc\\hosts"))
			{
				if (streamReader.ReadToEnd().Contains("api.auth.gg"))
				{
					Constants.Breached = true;
					MessageBox.Show("DNS redirecting has been detected!", OnProgramStart.Name);
					Process.GetCurrentProcess().Kill();
				}
			}
			new InfoManager().StartListener();
			Constants.Token = Guid.NewGuid().ToString();
			ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(Security.PinPublicKey));
			Constants.APIENCRYPTKEY = Convert.ToBase64String(Encoding.Default.GetBytes(Security.Session(32)));
			Constants.APIENCRYPTSALT = Convert.ToBase64String(Encoding.Default.GetBytes(Security.Session(16)));
			Constants.IV = Convert.ToBase64String(Encoding.Default.GetBytes(Constants.RandomString(16)));
			Constants.Key = Convert.ToBase64String(Encoding.Default.GetBytes(Constants.RandomString(32)));
			Constants.Started = true;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x001869AC File Offset: 0x001817AC
		public static void End()
		{
			if (!Constants.Started)
			{
				MessageBox.Show("No session has been started, closing for security reasons!", OnProgramStart.Name);
				Process.GetCurrentProcess().Kill();
				return;
			}
			Constants.Token = null;
			ServicePointManager.ServerCertificateValidationCallback = ((object <p0>, X509Certificate <p1>, X509Chain <p2>, SslPolicyErrors <p3>) => true);
			Constants.APIENCRYPTKEY = null;
			Constants.APIENCRYPTSALT = null;
			Constants.IV = null;
			Constants.Key = null;
			Constants.Started = false;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00184398 File Offset: 0x0017F198
		private static bool PinPublicKey(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return certificate != null && certificate.GetPublicKeyString() == "045C03C7FB0E76A822AB197B6663C288D9632E55B39B80296CBCD978707A7E5B3EAE1DB5D487CE9F0E448C3557079CE142F5A41B7F1F6436077D8F3FF7C311888C";
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00186A28 File Offset: 0x00181828
		public static string Integrity(string filename)
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

		// Token: 0x0600005F RID: 95 RVA: 0x00186AB8 File Offset: 0x001818B8
		public static bool MaliciousCheck(string date)
		{
			DateTime d = DateTime.Parse(date);
			DateTime now = DateTime.Now;
			TimeSpan timeSpan = d - now;
			if (Convert.ToInt32(timeSpan.Seconds.ToString().Replace("-", "")) < 5 && Convert.ToInt32(timeSpan.Minutes.ToString().Replace("-", "")) < 1)
			{
				return false;
			}
			Constants.Breached = true;
			return true;
		}

		// Token: 0x04000032 RID: 50
		private const string _key = "045C03C7FB0E76A822AB197B6663C288D9632E55B39B80296CBCD978707A7E5B3EAE1DB5D487CE9F0E448C3557079CE142F5A41B7F1F6436077D8F3FF7C311888C";
	}
}
