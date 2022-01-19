namespace gamesense
{
	// Token: 0x02000008 RID: 8
	public partial class Form3 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000042 RID: 66 RVA: 0x001AA1E1 File Offset: 0x001A3DE1
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x001AC9E0 File Offset: 0x001A65E0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::gamesense.Form3));
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.label2 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button6 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.FromArgb(0, 11, 22);
			this.label2.Location = new global::System.Drawing.Point(764, 155);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(35, 13);
			this.label2.TabIndex = 82;
			this.label2.Text = "label2";
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("MV Boli", 20.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.ForeColor = global::System.Drawing.Color.White;
			this.label11.Location = new global::System.Drawing.Point(12, 9);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(128, 34);
			this.label11.TabIndex = 73;
			this.label11.Text = "CRYPTO";
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(317, 167);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(412, 212);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 84;
			this.pictureBox1.TabStop = false;
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.Location = new global::System.Drawing.Point(18, 217);
			this.button1.Margin = new global::System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(148, 24);
			this.button1.TabIndex = 86;
			this.button1.Text = "Discord";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.button2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.Location = new global::System.Drawing.Point(18, 250);
			this.button2.Margin = new global::System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(148, 24);
			this.button2.TabIndex = 87;
			this.button2.Text = "Youtube";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button5.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button5.ForeColor = global::System.Drawing.SystemColors.ControlLight;
			this.button5.Location = new global::System.Drawing.Point(181, 331);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(225, 36);
			this.button5.TabIndex = 93;
			this.button5.Text = "Load v1";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.button4.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new global::System.Drawing.Font("Segoe UI Semibold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.ForeColor = global::System.Drawing.SystemColors.ScrollBar;
			this.button4.Location = new global::System.Drawing.Point(550, 3);
			this.button4.Margin = new global::System.Windows.Forms.Padding(2);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(38, 36);
			this.button4.TabIndex = 94;
			this.button4.Text = "X";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click_1);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(4, 6);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(66, 13);
			this.label1.TabIndex = 95;
			this.label1.Text = "Last update";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new global::System.Drawing.Point(181, 61);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(225, 213);
			this.panel1.TabIndex = 96;
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.Location = new global::System.Drawing.Point(14, 189);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(100, 13);
			this.label10.TabIndex = 104;
			this.label10.Text = "+ Updated visuals";
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.Location = new global::System.Drawing.Point(14, 167);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(122, 13);
			this.label9.TabIndex = 103;
			this.label9.Text = "+ Updated double tap";
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.Location = new global::System.Drawing.Point(14, 147);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(94, 13);
			this.label8.TabIndex = 102;
			this.label8.Text = "+ Updated menu";
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.Location = new global::System.Drawing.Point(14, 125);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(135, 13);
			this.label7.TabIndex = 101;
			this.label7.Text = "+ Updated resolver logic";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.Location = new global::System.Drawing.Point(14, 103);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(90, 13);
			this.label6.TabIndex = 100;
			this.label6.Text = "+ Fixed anti aim";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.Location = new global::System.Drawing.Point(14, 81);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(116, 13);
			this.label5.TabIndex = 99;
			this.label5.Text = "+ Added esp preview";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(14, 59);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(107, 13);
			this.label4.TabIndex = 98;
			this.label4.Text = "+ Recoded resolver";
			this.label4.Click += new global::System.EventHandler(this.label4_Click);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(14, 37);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(156, 13);
			this.label3.TabIndex = 97;
			this.label3.Text = "+ Recoded animation system";
			this.label3.Click += new global::System.EventHandler(this.label3_Click);
			this.panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new global::System.Drawing.Point(-2, -2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(239, 26);
			this.panel2.TabIndex = 96;
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.Location = new global::System.Drawing.Point(18, 309);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(148, 33);
			this.button3.TabIndex = 97;
			this.button3.Text = "Server crasher";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button6.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button6.ForeColor = global::System.Drawing.SystemColors.ControlLight;
			this.button6.Location = new global::System.Drawing.Point(181, 287);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(225, 38);
			this.button6.TabIndex = 98;
			this.button6.Text = "Load v2 ( Beta )";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(592, 379);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.pictureBox1);
			this.DoubleBuffered = true;
			this.ForeColor = global::System.Drawing.SystemColors.ControlLight;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "Form3";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Crypto.xyz";
			base.Load += new global::System.EventHandler(this.Form2_Load);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000022 RID: 34
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Button button5;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Button button6;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Label label9;
	}
}
