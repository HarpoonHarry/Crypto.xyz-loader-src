namespace gamesense
{
	// Token: 0x0200000A RID: 10
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000068 RID: 104 RVA: 0x001AA53B File Offset: 0x001A413B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x001AF064 File Offset: 0x001A8C64
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::gamesense.Form2));
			this.label2 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.username = new global::System.Windows.Forms.TextBox();
			this.password = new global::System.Windows.Forms.TextBox();
			this.license = new global::System.Windows.Forms.TextBox();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			base.SuspendLayout();
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new global::System.Drawing.Point(11, 9);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(139, 19);
			this.label2.TabIndex = 74;
			this.label2.Text = "Crypto.xyz | Register";
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("MV Boli", 20.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.ForeColor = global::System.Drawing.Color.White;
			this.label11.Location = new global::System.Drawing.Point(96, 47);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(128, 34);
			this.label11.TabIndex = 82;
			this.label11.Text = "CRYPTO";
			this.username.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.username.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.username.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.username.ForeColor = global::System.Drawing.SystemColors.ButtonShadow;
			this.username.Location = new global::System.Drawing.Point(45, 92);
			this.username.Name = "username";
			this.username.Size = new global::System.Drawing.Size(236, 25);
			this.username.TabIndex = 91;
			this.username.Text = "Username";
			this.username.Enter += new global::System.EventHandler(this.username_Enter);
			this.username.Leave += new global::System.EventHandler(this.username_Leave);
			this.password.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.password.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.password.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.password.ForeColor = global::System.Drawing.SystemColors.ButtonShadow;
			this.password.Location = new global::System.Drawing.Point(45, 128);
			this.password.Name = "password";
			this.password.Size = new global::System.Drawing.Size(236, 25);
			this.password.TabIndex = 95;
			this.password.Text = "Password";
			this.password.UseSystemPasswordChar = true;
			this.password.Enter += new global::System.EventHandler(this.password_Enter);
			this.password.Leave += new global::System.EventHandler(this.password_Leave);
			this.license.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.license.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.license.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.license.ForeColor = global::System.Drawing.SystemColors.ButtonShadow;
			this.license.Location = new global::System.Drawing.Point(45, 164);
			this.license.Name = "license";
			this.license.Size = new global::System.Drawing.Size(236, 25);
			this.license.TabIndex = 97;
			this.license.Text = "Invitation code";
			this.license.Enter += new global::System.EventHandler(this.license_Enter);
			this.license.Leave += new global::System.EventHandler(this.license_Leave);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.button3.FlatAppearance.BorderColor = global::System.Drawing.SystemColors.ActiveBorder;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.ForeColor = global::System.Drawing.SystemColors.ScrollBar;
			this.button3.Location = new global::System.Drawing.Point(35, 210);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(255, 27);
			this.button3.TabIndex = 98;
			this.button3.Text = "Register";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.SystemColors.ScrollBar;
			this.button1.Location = new global::System.Drawing.Point(35, 243);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(255, 27);
			this.button1.TabIndex = 99;
			this.button1.Text = "Back to Login";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click_1);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.button4.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new global::System.Drawing.Font("Segoe UI Semibold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.ForeColor = global::System.Drawing.SystemColors.ScrollBar;
			this.button4.Location = new global::System.Drawing.Point(282, 4);
			this.button4.Margin = new global::System.Windows.Forms.Padding(2);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(38, 36);
			this.button4.TabIndex = 100;
			this.button4.Text = "X";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click_2);
			this.checkBox1.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.checkBox1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.checkBox1.FlatAppearance.BorderSize = 0;
			this.checkBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("checkBox1.Image");
			this.checkBox1.Location = new global::System.Drawing.Point(250, 132);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(27, 17);
			this.checkBox1.TabIndex = 101;
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(324, 288);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.license);
			base.Controls.Add(this.password);
			base.Controls.Add(this.username);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label2);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "Form2";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Crypto.xyz";
			base.Load += new global::System.EventHandler(this.Form3_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Form3_MouseMove);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000055 RID: 85
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.TextBox username;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.TextBox password;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.TextBox license;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.CheckBox checkBox1;
	}
}
