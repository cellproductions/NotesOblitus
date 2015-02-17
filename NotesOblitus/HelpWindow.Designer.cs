namespace NotesOblitus
{
	partial class HelpWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
			this.wbDisplay = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// wbDisplay
			// 
			this.wbDisplay.AllowWebBrowserDrop = false;
			this.wbDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wbDisplay.IsWebBrowserContextMenuEnabled = false;
			this.wbDisplay.Location = new System.Drawing.Point(0, 0);
			this.wbDisplay.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbDisplay.Name = "wbDisplay";
			this.wbDisplay.Size = new System.Drawing.Size(784, 562);
			this.wbDisplay.TabIndex = 0;
			this.wbDisplay.WebBrowserShortcutsEnabled = false;
			// 
			// HelpWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.wbDisplay);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "HelpWindow";
			this.Text = "Help";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser wbDisplay;
	}
}