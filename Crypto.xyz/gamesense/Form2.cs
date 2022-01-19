using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using KeyAuth;

namespace gamesense
{
	// Token: 0x0200000A RID: 10
	public partial class Form2 : Form
	{
		// Token: 0x06000058 RID: 88
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000059 RID: 89
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600005A RID: 90 RVA: 0x001AA37D File Offset: 0x001A3F7D
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x001AA391 File Offset: 0x001A3F91
		private void Form3_Load(object sender, EventArgs e)
		{
			Form2.KeyAuthApp.init();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x001AA39D File Offset: 0x001A3F9D
		private void Form3_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Form2.ReleaseCapture();
				Form2.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x001AEFFC File Offset: 0x001A8BFC
		private void button3_Click(object sender, EventArgs e)
		{
			if (Form2.KeyAuthApp.register(this.username.Text, this.password.Text, this.license.Text))
			{
				MessageBox.Show("Seccesful register!", "Crypto.xyz");
				new Form1().Show();
				base.Hide();
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x001AA3D3 File Offset: 0x001A3FD3
		private void button1_Click_1(object sender, EventArgs e)
		{
			new Form1().Show();
			base.Hide();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x001AA1DA File Offset: 0x001A3DDA
		private void button4_Click_2(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x001AA3E8 File Offset: 0x001A3FE8
		private void username_Enter(object sender, EventArgs e)
		{
			if (this.username.Text == "Username")
			{
				this.username.Text = "";
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x001AA417 File Offset: 0x001A4017
		private void username_Leave(object sender, EventArgs e)
		{
			if (this.username.Text == "")
			{
				this.username.Text = "Username";
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x001AA446 File Offset: 0x001A4046
		private void password_Enter(object sender, EventArgs e)
		{
			if (this.password.Text == "Password")
			{
				this.password.Text = "";
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x001AA475 File Offset: 0x001A4075
		private void password_Leave(object sender, EventArgs e)
		{
			if (this.password.Text == "")
			{
				this.password.Text = "Password";
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x001AA4A4 File Offset: 0x001A40A4
		private void license_Enter(object sender, EventArgs e)
		{
			if (this.license.Text == "Invitation code")
			{
				this.license.Text = "";
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x001AA4D3 File Offset: 0x001A40D3
		private void license_Leave(object sender, EventArgs e)
		{
			if (this.license.Text == "")
			{
				this.license.Text = "Invitation code";
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x001AA502 File Offset: 0x001A4102
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox1.Checked)
			{
				this.password.UseSystemPasswordChar = false;
				return;
			}
			this.password.UseSystemPasswordChar = true;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x001AA39D File Offset: 0x001A3F9D
		private void Form3_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Form2.ReleaseCapture();
				Form2.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x0400004D RID: 77
		private static string name = "Crypto.xyz";

		// Token: 0x0400004E RID: 78
		private static string ownerid = "rjNPznxhP4";

		// Token: 0x0400004F RID: 79
		private static string secret = "64871944fcb3db44189ab45bb9e25483bc46f5c2c0618850cb0659ebcda88eda";

		// Token: 0x04000050 RID: 80
		private static string version = "1.0";

		// Token: 0x04000051 RID: 81
		public static api KeyAuthApp = new api(Form2.name, Form2.ownerid, Form2.secret, Form2.version);

		// Token: 0x04000052 RID: 82
		private string HWID;

		// Token: 0x04000053 RID: 83
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000054 RID: 84
		public const int HT_CAPTION = 2;
	}
}
