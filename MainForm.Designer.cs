/*
 * Created by SharpDevelop.
 * User: Radimir
 * Date: 12.04.2015
 * Time: 21:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Windows.Forms;
namespace Facebook_Messenger
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.WebBrowser mainBrowser;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainBrowser = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// mainBrowser
			// 
			this.mainBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainBrowser.IsWebBrowserContextMenuEnabled = false;
			this.mainBrowser.Location = new System.Drawing.Point(0, 0);
			this.mainBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.mainBrowser.Name = "mainBrowser";
			this.mainBrowser.ScrollBarsEnabled = false;
			this.mainBrowser.Size = new System.Drawing.Size(722, 535);
			this.mainBrowser.TabIndex = 0;
			this.mainBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1DocumentCompleted);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 535);
			this.Controls.Add(this.mainBrowser);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Facebook Messenger";
			this.ResumeLayout(false);

		}
		
	}
}
