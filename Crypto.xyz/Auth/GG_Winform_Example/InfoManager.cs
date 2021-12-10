using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200000D RID: 13
	internal class InfoManager
	{
		// Token: 0x06000068 RID: 104 RVA: 0x001843B9 File Offset: 0x0017F1B9
		public InfoManager()
		{
			this.lastGateway = this.GetGatewayMAC();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x001843D6 File Offset: 0x0017F1D6
		public void StartListener()
		{
			this.timer = new System.Threading.Timer(delegate(object _)
			{
				this.OnCallBack();
			}, null, 5000, -1);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00186F34 File Offset: 0x00181D34
		private void OnCallBack()
		{
			this.timer.Dispose();
			if (!(this.GetGatewayMAC() == this.lastGateway))
			{
				Constants.Breached = true;
				MessageBox.Show("ARP Cache poisoning has been detected!", OnProgramStart.Name);
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				this.lastGateway = this.GetGatewayMAC();
			}
			this.timer = new System.Threading.Timer(delegate(object _)
			{
				this.OnCallBack();
			}, null, 5000, -1);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00186FC8 File Offset: 0x00181DC8
		public static IPAddress GetDefaultGateway()
		{
			return (from a in (from n in NetworkInterface.GetAllNetworkInterfaces()
			where n.OperationalStatus == OperationalStatus.Up
			where n.NetworkInterfaceType != NetworkInterfaceType.Loopback
			select n).SelectMany(delegate(NetworkInterface n)
			{
				IPInterfaceProperties ipproperties = n.GetIPProperties();
				if (ipproperties == null)
				{
					return null;
				}
				return ipproperties.GatewayAddresses;
			}).Select(delegate(GatewayIPAddressInformation g)
			{
				if (g == null)
				{
					return null;
				}
				return g.Address;
			})
			where a != null
			select a).FirstOrDefault<IPAddress>();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00187094 File Offset: 0x00181E94
		private string GetArpTable()
		{
			string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
			string result;
			using (Process process = Process.Start(new ProcessStartInfo
			{
				FileName = pathRoot + "Windows\\System32\\arp.exe",
				Arguments = "-a",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			}))
			{
				using (StreamReader standardOutput = process.StandardOutput)
				{
					result = standardOutput.ReadToEnd();
				}
			}
			return result;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0018715C File Offset: 0x00181F5C
		private string GetGatewayMAC()
		{
			string arg = InfoManager.GetDefaultGateway().ToString();
			return new Regex(string.Format("({0} [\\W]*) ([a-z0-9-]*)", arg)).Match(this.GetArpTable()).Groups[2].ToString();
		}

		// Token: 0x04000033 RID: 51
		private System.Threading.Timer timer;

		// Token: 0x04000034 RID: 52
		private string lastGateway;
	}
}
