using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;
using Auth.GG_Winform_Example;

namespace gamesense
{
	// Token: 0x02000010 RID: 16
	public partial class Form3 : Form
	{
		// Token: 0x06000092 RID: 146
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000093 RID: 147
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000094 RID: 148 RVA: 0x00184600 File Offset: 0x0017F400
		public Form3()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00184614 File Offset: 0x0017F414
		private void Form3_Load(object sender, EventArgs e)
		{
			this.HWID = WindowsIdentity.GetCurrent().User.Value;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0018462E File Offset: 0x0017F42E
		private void Form3_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Form3.ReleaseCapture();
				Form3.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00189658 File Offset: 0x00184458
		private void button3_Click(object sender, EventArgs e)
		{
			if (API.Register(this.username.Text, this.password.Text, this.email.Text, this.license.Text))
			{
				MessageBox.Show("Register has been successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00184664 File Offset: 0x0017F464
		private void button1_Click_1(object sender, EventArgs e)
		{
			new Form1().Show();
			base.Hide();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0018445D File Offset: 0x0017F25D
		private void button4_Click_2(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00184679 File Offset: 0x0017F479
		private void username_Enter(object sender, EventArgs e)
		{
			if (this.username.Text == "Username")
			{
				this.username.Text = "";
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x001846A8 File Offset: 0x0017F4A8
		private void username_Leave(object sender, EventArgs e)
		{
			if (this.username.Text == "")
			{
				this.username.Text = "Username";
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x001846D7 File Offset: 0x0017F4D7
		private void password_Enter(object sender, EventArgs e)
		{
			if (this.password.Text == "Password")
			{
				this.password.Text = "";
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00184706 File Offset: 0x0017F506
		private void password_Leave(object sender, EventArgs e)
		{
			if (this.password.Text == "")
			{
				this.password.Text = "Password";
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00184735 File Offset: 0x0017F535
		private void email_Enter(object sender, EventArgs e)
		{
			if (this.email.Text == "Email")
			{
				this.email.Text = "";
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00184764 File Offset: 0x0017F564
		private void email_Leave(object sender, EventArgs e)
		{
			if (this.email.Text == "")
			{
				this.email.Text = "Email";
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00184793 File Offset: 0x0017F593
		private void license_Enter(object sender, EventArgs e)
		{
			if (this.license.Text == "Invitation code")
			{
				this.license.Text = "";
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x001847C2 File Offset: 0x0017F5C2
		private void license_Leave(object sender, EventArgs e)
		{
			if (this.license.Text == "")
			{
				this.license.Text = "Invitation code";
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x001847F1 File Offset: 0x0017F5F1
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox1.Checked)
			{
				this.password.UseSystemPasswordChar = false;
				return;
			}
			this.password.UseSystemPasswordChar = true;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0018440B File Offset: 0x0017F20B
		private void license_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000061 RID: 97
		private string HWID;

		// Token: 0x04000062 RID: 98
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000063 RID: 99
		public const int HT_CAPTION = 2;
	}
}
