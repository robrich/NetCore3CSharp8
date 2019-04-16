using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NetFrameworkBrowser
{
	public partial class Form1 : Form
	{
		private IContainer components;
		private Button button2;
		private Button button1;

		public Form1()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(73, 33);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(294, 146);
			this.button1.TabIndex = 4;
			this.button1.Text = "Launch 1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click_1);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(443, 33);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(294, 146);
			this.button2.TabIndex = 5;
			this.button2.Text = "Launch 2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(811, 234);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Web Browser Form";
			this.ResumeLayout(false);

		}

		private void Button1_Click_1(object sender, EventArgs e)
		{
			Form2 form = new Form2();
			form.Show();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Form3 form = new Form3();
			form.Show();
		}
	}
}
