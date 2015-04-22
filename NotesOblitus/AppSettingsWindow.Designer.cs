namespace NotesOblitus
{
	partial class AppSettingsWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettingsWindow));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.bUpdateCheckUpdate = new System.Windows.Forms.Button();
			this.cbUpdateUpdate = new System.Windows.Forms.ComboBox();
			this.bUpdateUpdate = new System.Windows.Forms.Button();
			this.cProxyUseProxy = new System.Windows.Forms.CheckBox();
			this.cProxyDefaultProxy = new System.Windows.Forms.CheckBox();
			this.cProxyShowPwd = new System.Windows.Forms.CheckBox();
			this.cProxyDefaultCreds = new System.Windows.Forms.CheckBox();
			this.tbProxyPassword = new CellSharpControls.TextBoxPlaceHolder();
			this.tbProxyUsername = new CellSharpControls.TextBoxPlaceHolder();
			this.tbProxyPort = new CellSharpControls.TextBoxPlaceHolder();
			this.tbProxyAddress = new CellSharpControls.TextBoxPlaceHolder();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 262);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cProxyUseProxy);
			this.groupBox1.Controls.Add(this.cProxyDefaultProxy);
			this.groupBox1.Controls.Add(this.cProxyShowPwd);
			this.groupBox1.Controls.Add(this.cProxyDefaultCreds);
			this.groupBox1.Controls.Add(this.tbProxyPassword);
			this.groupBox1.Controls.Add(this.tbProxyUsername);
			this.groupBox1.Controls.Add(this.tbProxyPort);
			this.groupBox1.Controls.Add(this.tbProxyAddress);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(278, 171);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Proxy";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.bUpdateCheckUpdate);
			this.groupBox2.Controls.Add(this.cbUpdateUpdate);
			this.groupBox2.Controls.Add(this.bUpdateUpdate);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 180);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(278, 79);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Update";
			// 
			// bUpdateCheckUpdate
			// 
			this.bUpdateCheckUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bUpdateCheckUpdate.Location = new System.Drawing.Point(6, 50);
			this.bUpdateCheckUpdate.Name = "bUpdateCheckUpdate";
			this.bUpdateCheckUpdate.Size = new System.Drawing.Size(129, 23);
			this.bUpdateCheckUpdate.TabIndex = 31;
			this.bUpdateCheckUpdate.Text = "Check for updates";
			this.bUpdateCheckUpdate.UseVisualStyleBackColor = true;
			this.bUpdateCheckUpdate.Click += new System.EventHandler(this.bUpdateCheckUpdate_Click);
			// 
			// cbUpdateUpdate
			// 
			this.cbUpdateUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbUpdateUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUpdateUpdate.FormattingEnabled = true;
			this.cbUpdateUpdate.Items.AddRange(new object[] {
            "Automatically update",
            "Notify me of an update",
            "Do not check for updates"});
			this.cbUpdateUpdate.Location = new System.Drawing.Point(6, 23);
			this.cbUpdateUpdate.Name = "cbUpdateUpdate";
			this.cbUpdateUpdate.Size = new System.Drawing.Size(266, 21);
			this.cbUpdateUpdate.TabIndex = 30;
			// 
			// bUpdateUpdate
			// 
			this.bUpdateUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bUpdateUpdate.CausesValidation = false;
			this.bUpdateUpdate.ForeColor = System.Drawing.Color.Firebrick;
			this.bUpdateUpdate.Location = new System.Drawing.Point(143, 50);
			this.bUpdateUpdate.Name = "bUpdateUpdate";
			this.bUpdateUpdate.Size = new System.Drawing.Size(129, 23);
			this.bUpdateUpdate.TabIndex = 29;
			this.bUpdateUpdate.Text = "No update available";
			this.bUpdateUpdate.UseVisualStyleBackColor = true;
			// 
			// cProxyUseProxy
			// 
			this.cProxyUseProxy.AutoSize = true;
			this.cProxyUseProxy.Location = new System.Drawing.Point(6, 19);
			this.cProxyUseProxy.Name = "cProxyUseProxy";
			this.cProxyUseProxy.Size = new System.Drawing.Size(73, 17);
			this.cProxyUseProxy.TabIndex = 16;
			this.cProxyUseProxy.Text = "Use proxy";
			this.cProxyUseProxy.UseVisualStyleBackColor = true;
			this.cProxyUseProxy.CheckedChanged += new System.EventHandler(this.cProxyUseProxy_CheckedChanged);
			// 
			// cProxyDefaultProxy
			// 
			this.cProxyDefaultProxy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cProxyDefaultProxy.AutoSize = true;
			this.cProxyDefaultProxy.Checked = true;
			this.cProxyDefaultProxy.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cProxyDefaultProxy.Location = new System.Drawing.Point(164, 19);
			this.cProxyDefaultProxy.Name = "cProxyDefaultProxy";
			this.cProxyDefaultProxy.Size = new System.Drawing.Size(108, 17);
			this.cProxyDefaultProxy.TabIndex = 15;
			this.cProxyDefaultProxy.Text = "Use default proxy";
			this.cProxyDefaultProxy.UseVisualStyleBackColor = true;
			this.cProxyDefaultProxy.CheckedChanged += new System.EventHandler(this.cProxyDefaultProxy_CheckedChanged);
			this.cProxyDefaultProxy.EnabledChanged += new System.EventHandler(this.cProxyDefaultProxy_EnabledChanged);
			// 
			// cProxyShowPwd
			// 
			this.cProxyShowPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cProxyShowPwd.AutoSize = true;
			this.cProxyShowPwd.Location = new System.Drawing.Point(171, 94);
			this.cProxyShowPwd.Name = "cProxyShowPwd";
			this.cProxyShowPwd.Size = new System.Drawing.Size(101, 17);
			this.cProxyShowPwd.TabIndex = 14;
			this.cProxyShowPwd.Text = "Show password";
			this.cProxyShowPwd.UseVisualStyleBackColor = true;
			this.cProxyShowPwd.CheckedChanged += new System.EventHandler(this.cProxyShowPwd_CheckedChanged);
			// 
			// cProxyDefaultCreds
			// 
			this.cProxyDefaultCreds.AutoSize = true;
			this.cProxyDefaultCreds.Location = new System.Drawing.Point(6, 94);
			this.cProxyDefaultCreds.Name = "cProxyDefaultCreds";
			this.cProxyDefaultCreds.Size = new System.Drawing.Size(134, 17);
			this.cProxyDefaultCreds.TabIndex = 13;
			this.cProxyDefaultCreds.Text = "Use default credentials";
			this.cProxyDefaultCreds.UseVisualStyleBackColor = true;
			this.cProxyDefaultCreds.CheckedChanged += new System.EventHandler(this.cProxyDefaultCreds_CheckedChanged);
			this.cProxyDefaultCreds.EnabledChanged += new System.EventHandler(this.cProxyDefaultCreds_EnabledChanged);
			// 
			// tbProxyPassword
			// 
			this.tbProxyPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbProxyPassword.Location = new System.Drawing.Point(6, 143);
			this.tbProxyPassword.Name = "tbProxyPassword";
			this.tbProxyPassword.PlaceHolder = "Password";
			this.tbProxyPassword.Size = new System.Drawing.Size(266, 20);
			this.tbProxyPassword.TabIndex = 12;
			// 
			// tbProxyUsername
			// 
			this.tbProxyUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbProxyUsername.Location = new System.Drawing.Point(6, 117);
			this.tbProxyUsername.Name = "tbProxyUsername";
			this.tbProxyUsername.PlaceHolder = "User name";
			this.tbProxyUsername.Size = new System.Drawing.Size(266, 20);
			this.tbProxyUsername.TabIndex = 11;
			// 
			// tbProxyPort
			// 
			this.tbProxyPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbProxyPort.Location = new System.Drawing.Point(6, 68);
			this.tbProxyPort.Name = "tbProxyPort";
			this.tbProxyPort.PlaceHolder = "Proxy port";
			this.tbProxyPort.Size = new System.Drawing.Size(266, 20);
			this.tbProxyPort.TabIndex = 10;
			// 
			// tbProxyAddress
			// 
			this.tbProxyAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbProxyAddress.Location = new System.Drawing.Point(6, 42);
			this.tbProxyAddress.Name = "tbProxyAddress";
			this.tbProxyAddress.PlaceHolder = "Proxy address";
			this.tbProxyAddress.Size = new System.Drawing.Size(266, 20);
			this.tbProxyAddress.TabIndex = 9;
			// 
			// AppSettingsWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AppSettingsWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button bUpdateCheckUpdate;
		public System.Windows.Forms.ComboBox cbUpdateUpdate;
		public System.Windows.Forms.Button bUpdateUpdate;
		private System.Windows.Forms.CheckBox cProxyUseProxy;
		private System.Windows.Forms.CheckBox cProxyDefaultProxy;
		private System.Windows.Forms.CheckBox cProxyShowPwd;
		private System.Windows.Forms.CheckBox cProxyDefaultCreds;
		private CellSharpControls.TextBoxPlaceHolder tbProxyPassword;
		private CellSharpControls.TextBoxPlaceHolder tbProxyUsername;
		private CellSharpControls.TextBoxPlaceHolder tbProxyPort;
		private CellSharpControls.TextBoxPlaceHolder tbProxyAddress;
	}
}