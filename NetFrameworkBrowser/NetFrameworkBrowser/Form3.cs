using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NetFrameworkBrowser
{
	public partial class Form3 : Form
	{
		private TextBox textBox1;
		private Microsoft.Toolkit.Forms.UI.Controls.WebView webView1;
		private Button button1;

		public Form3()
		{
			InitializeComponent();
			this.textBox1.Text = "http://getright.com/useragent.html";
			this.webView1.Navigate(new Uri(this.textBox1.Text));
		}

		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.webView1 = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
			((System.ComponentModel.ISupportInitialize)(this.webView1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(641, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyUp);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(659, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Go";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click_1);
			// 
			// webView1
			// 
			this.webView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.webView1.Location = new System.Drawing.Point(12, 39);
			this.webView1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webView1.Name = "webView1";
			this.webView1.Size = new System.Drawing.Size(722, 535);
			this.webView1.TabIndex = 5;
			// 
			// Form3
			// 
			this.ClientSize = new System.Drawing.Size(746, 586);
			this.Controls.Add(this.webView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form3";
			this.Text = "Better Browser";
			((System.ComponentModel.ISupportInitialize)(this.webView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void Button1_Click_1(object sender, EventArgs e)
		{
			this.webView1.Navigate(new Uri(this.textBox1.Text));
		}

		private void TextBox1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.webView1.Navigate(new Uri(this.textBox1.Text));
			}
		}

	}
}
