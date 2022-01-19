namespace gamesense
{
	// Token: 0x02000009 RID: 9
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000055 RID: 85 RVA: 0x001AA34F File Offset: 0x001A3F4F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x001AE2D0 File Offset: 0x001A7ED0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::gamesense.Form1));
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.label3 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.txtUsername = new global::System.Windows.Forms.TextBox();
			this.txtPassword = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.checkRemember = new global::System.Windows.Forms.CheckBox();
			base.SuspendLayout();
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new global::System.Drawing.Point(8, 15);
			this.label3.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(123, 19);
			this.label3.TabIndex = 72;
			this.label3.Text = "Crypto.xyz | Login";
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("MV Boli", 20.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.ForeColor = global::System.Drawing.Color.White;
			this.label11.Location = new global::System.Drawing.Point(91, 42);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(128, 34);
			this.label11.TabIndex = 71;
			this.label11.Text = "CRYPTO";
			this.label11.Click += new global::System.EventHandler(this.label11_Click);
			this.txtUsername.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.txtUsername.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUsername.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtUsername.ForeColor = global::System.Drawing.SystemColors.ButtonShadow;
			this.txtUsername.Location = new global::System.Drawing.Point(45, 88);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new global::System.Drawing.Size(236, 25);
			this.txtUsername.TabIndex = 73;
			this.txtUsername.Text = "Username";
			this.txtUsername.TextChanged += new global::System.EventHandler(this.txtUsername_TextChanged);
			this.txtUsername.Enter += new global::System.EventHandler(this.txtUsername_Enter);
			this.txtUsername.Leave += new global::System.EventHandler(this.txtUsername_Leave);
			this.txtPassword.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.txtPassword.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtPassword.ForeColor = global::System.Drawing.SystemColors.ButtonShadow;
			this.txtPassword.Location = new global::System.Drawing.Point(45, 124);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new global::System.Drawing.Size(236, 25);
			this.txtPassword.TabIndex = 74;
			this.txtPassword.Text = "Password";
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.Enter += new global::System.EventHandler(this.txtPassword_Enter);
			this.txtPassword.Leave += new global::System.EventHandler(this.txtPassword_Leave);
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.SystemColors.ScrollBar;
			this.button1.Location = new global::System.Drawing.Point(35, 181);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(255, 27);
			this.button1.TabIndex = 75;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click_1);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.SystemColors.ScrollBar;
			this.button2.Location = new global::System.Drawing.Point(35, 214);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(255, 27);
			this.button2.TabIndex = 76;
			this.button2.Text = "Register";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click_1);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.button4.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button4.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new global::System.Drawing.Font("Segoe UI Semibold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.ForeColor = global::System.Drawing.SystemColors.ScrollBar;
			this.button4.Location = new global::System.Drawing.Point(289, 9);
			this.button4.Margin = new global::System.Windows.Forms.Padding(2);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(38, 36);
			this.button4.TabIndex = 93;
			this.button4.Text = "X";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.checkBox1.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.checkBox1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.checkBox1.FlatAppearance.BorderSize = 0;
			this.checkBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("checkBox1.Image");
			this.checkBox1.Location = new global::System.Drawing.Point(251, 128);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(27, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.checkRemember.AutoSize = true;
			this.checkRemember.ForeColor = global::System.Drawing.SystemColors.ControlLight;
			this.checkRemember.Location = new global::System.Drawing.Point(45, 155);
			this.checkRemember.Name = "checkRemember";
			this.checkRemember.Size = new global::System.Drawing.Size(94, 17);
			this.checkRemember.TabIndex = 94;
			this.checkRemember.Text = "Remember me";
			this.checkRemember.UseVisualStyleBackColor = true;
			this.checkRemember.CheckedChanged += new global::System.EventHandler(this.checkRemember_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(334, 251);
			base.Controls.Add(this.checkRemember);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.txtPassword);
			base.Controls.Add(this.txtUsername);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label11);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Crypto.xyz";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000042 RID: 66
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.TextBox txtUsername;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.TextBox txtPassword;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.CheckBox checkRemember;
	}
}
