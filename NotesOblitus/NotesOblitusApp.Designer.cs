using System;
using System.Security.AccessControl;
using NotesOblitus.Controls;

namespace NotesOblitus
{
	partial class NotesOblitusApp
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesOblitusApp));
			this.msMainMenu = new System.Windows.Forms.MenuStrip();
			this.miFile = new System.Windows.Forms.ToolStripMenuItem();
			this.miFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.miFileRecentProjects = new System.Windows.Forms.ToolStripMenuItem();
			this.miFileRecentSearches = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.miFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miAboutHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.miAboutAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.niMainNotify = new System.Windows.Forms.NotifyIcon(this.components);
			this.msNotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miNotifyAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.miNotifyExit = new System.Windows.Forms.ToolStripMenuItem();
			this.tcProjects = new CellSharpControls.EditableTabControl();
			this.miProjectSave = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miProjectSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.exportAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.miProjectRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.miProjectScanDir = new System.Windows.Forms.ToolStripMenuItem();
			this.displayAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.miProjectOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.miProjectStatistics = new System.Windows.Forms.ToolStripMenuItem();
			this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miProjectExportXml = new System.Windows.Forms.ToolStripMenuItem();
			this.miProjectExportJson = new System.Windows.Forms.ToolStripMenuItem();
			this.miProjectDisplayTable = new System.Windows.Forms.ToolStripMenuItem();
			this.miProjectDisplayTree = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.msMainMenu.SuspendLayout();
			this.msNotifyMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// msMainMenu
			// 
			this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.viewToolStripMenuItem,
            this.miProjectSave,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.msMainMenu.Location = new System.Drawing.Point(0, 0);
			this.msMainMenu.Name = "msMainMenu";
			this.msMainMenu.Size = new System.Drawing.Size(784, 24);
			this.msMainMenu.TabIndex = 0;
			this.msMainMenu.Text = "menuStrip1";
			// 
			// miFile
			// 
			this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileOpen,
            this.toolStripSeparator1,
            this.miFileRecentProjects,
            this.miFileRecentSearches,
            this.toolStripSeparator3,
            this.miFileExit});
			this.miFile.Name = "miFile";
			this.miFile.Size = new System.Drawing.Size(37, 20);
			this.miFile.Text = "File";
			this.miFile.Click += new System.EventHandler(this.miFile_Click);
			// 
			// miFileOpen
			// 
			this.miFileOpen.Name = "miFileOpen";
			this.miFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.miFileOpen.Size = new System.Drawing.Size(180, 22);
			this.miFileOpen.Text = "Open";
			this.miFileOpen.Click += new System.EventHandler(this.miFileOpen_Click);
			// 
			// miFileRecentProjects
			// 
			this.miFileRecentProjects.Name = "miFileRecentProjects";
			this.miFileRecentProjects.Size = new System.Drawing.Size(180, 22);
			this.miFileRecentProjects.Text = "Recent Projects";
			// 
			// miFileRecentSearches
			// 
			this.miFileRecentSearches.Name = "miFileRecentSearches";
			this.miFileRecentSearches.Size = new System.Drawing.Size(180, 22);
			this.miFileRecentSearches.Text = "Recent Search Paths";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
			// 
			// miFileExit
			// 
			this.miFileExit.Name = "miFileExit";
			this.miFileExit.Size = new System.Drawing.Size(180, 22);
			this.miFileExit.Text = "Exit";
			this.miFileExit.Click += new System.EventHandler(this.miFileExit_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAboutHelp,
            this.miAboutAbout});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// miAboutHelp
			// 
			this.miAboutHelp.Name = "miAboutHelp";
			this.miAboutHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.miAboutHelp.Size = new System.Drawing.Size(152, 22);
			this.miAboutHelp.Text = "Help";
			this.miAboutHelp.Click += new System.EventHandler(this.miAboutHelp_Click);
			// 
			// miAboutAbout
			// 
			this.miAboutAbout.Name = "miAboutAbout";
			this.miAboutAbout.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.miAboutAbout.Size = new System.Drawing.Size(152, 22);
			this.miAboutAbout.Text = "About";
			this.miAboutAbout.Click += new System.EventHandler(this.miAboutAbout_Click);
			// 
			// niMainNotify
			// 
			this.niMainNotify.ContextMenuStrip = this.msNotifyMenu;
			this.niMainNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("niMainNotify.Icon")));
			this.niMainNotify.Text = "niMainIcon";
			this.niMainNotify.Visible = true;
			// 
			// msNotifyMenu
			// 
			this.msNotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNotifyAbout,
            this.miNotifyExit});
			this.msNotifyMenu.Name = "msNotifyMenu";
			this.msNotifyMenu.Size = new System.Drawing.Size(153, 70);
			this.msNotifyMenu.Opening += new System.ComponentModel.CancelEventHandler(this.msNotifyMenu_Opening);
			// 
			// miNotifyAbout
			// 
			this.miNotifyAbout.Name = "miNotifyAbout";
			this.miNotifyAbout.Size = new System.Drawing.Size(152, 22);
			this.miNotifyAbout.Text = "About";
			this.miNotifyAbout.Click += new System.EventHandler(this.miNotifyAbout_Click);
			// 
			// miNotifyExit
			// 
			this.miNotifyExit.Name = "miNotifyExit";
			this.miNotifyExit.Size = new System.Drawing.Size(152, 22);
			this.miNotifyExit.Text = "Exit";
			this.miNotifyExit.Click += new System.EventHandler(this.miNotifyExit_Click);
			// 
			// tcProjects
			// 
			this.tcProjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcProjects.Location = new System.Drawing.Point(0, 24);
			this.tcProjects.Name = "tcProjects";
			this.tcProjects.Size = new System.Drawing.Size(784, 538);
			this.tcProjects.TabIndex = 1;
			this.tcProjects.TabMouseDown += new CellSharpControls.EditableTabControl.TabMouseEvent(this.tcProjects_TabMouseDown);
			// 
			// miProjectSave
			// 
			this.miProjectSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.miProjectSaveAs,
            this.exportAsToolStripMenuItem,
            this.toolStripSeparator5,
            this.miProjectScanDir,
            this.miProjectRefresh,
            this.displayAsToolStripMenuItem1,
            this.toolStripSeparator6,
            this.miProjectOptions,
            this.miProjectStatistics});
			this.miProjectSave.Name = "miProjectSave";
			this.miProjectSave.Size = new System.Drawing.Size(56, 20);
			this.miProjectSave.Text = "Project";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// miProjectSaveAs
			// 
			this.miProjectSaveAs.Name = "miProjectSaveAs";
			this.miProjectSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.miProjectSaveAs.Size = new System.Drawing.Size(195, 22);
			this.miProjectSaveAs.Text = "Save As...";
			this.miProjectSaveAs.Click += new System.EventHandler(this.miProjectSaveAs_Click);
			// 
			// exportAsToolStripMenuItem
			// 
			this.exportAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProjectExportXml,
            this.miProjectExportJson});
			this.exportAsToolStripMenuItem.Name = "exportAsToolStripMenuItem";
			this.exportAsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
			this.exportAsToolStripMenuItem.Text = "Export As...";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(192, 6);
			// 
			// miProjectRefresh
			// 
			this.miProjectRefresh.Name = "miProjectRefresh";
			this.miProjectRefresh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.miProjectRefresh.Size = new System.Drawing.Size(195, 22);
			this.miProjectRefresh.Text = "Refresh";
			this.miProjectRefresh.Click += new System.EventHandler(this.miProjectRefresh_Click);
			// 
			// miProjectScanDir
			// 
			this.miProjectScanDir.Name = "miProjectScanDir";
			this.miProjectScanDir.Size = new System.Drawing.Size(195, 22);
			this.miProjectScanDir.Text = "Scan Directory";
			this.miProjectScanDir.Click += new System.EventHandler(this.miProjectScanDir_Click);
			// 
			// displayAsToolStripMenuItem1
			// 
			this.displayAsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProjectDisplayTable,
            this.miProjectDisplayTree});
			this.displayAsToolStripMenuItem1.Name = "displayAsToolStripMenuItem1";
			this.displayAsToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
			this.displayAsToolStripMenuItem1.Text = "Display As...";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(192, 6);
			// 
			// miProjectOptions
			// 
			this.miProjectOptions.Name = "miProjectOptions";
			this.miProjectOptions.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.miProjectOptions.Size = new System.Drawing.Size(195, 22);
			this.miProjectOptions.Text = "Options";
			this.miProjectOptions.Click += new System.EventHandler(this.miProjectOptions_Click);
			// 
			// miProjectStatistics
			// 
			this.miProjectStatistics.Name = "miProjectStatistics";
			this.miProjectStatistics.Size = new System.Drawing.Size(195, 22);
			this.miProjectStatistics.Text = "Statistics";
			this.miProjectStatistics.Click += new System.EventHandler(this.miProjectStatistics_Click);
			// 
			// preferencesToolStripMenuItem
			// 
			this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
			this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.preferencesToolStripMenuItem.Text = "Preferences";
			// 
			// miProjectExportXml
			// 
			this.miProjectExportXml.Name = "miProjectExportXml";
			this.miProjectExportXml.Size = new System.Drawing.Size(152, 22);
			this.miProjectExportXml.Text = "XML";
			this.miProjectExportXml.Click += new System.EventHandler(this.miProjectExportXml_Click);
			// 
			// miProjectExportJson
			// 
			this.miProjectExportJson.Name = "miProjectExportJson";
			this.miProjectExportJson.Size = new System.Drawing.Size(152, 22);
			this.miProjectExportJson.Text = "Json";
			this.miProjectExportJson.Click += new System.EventHandler(this.miProjectExportJson_Click);
			// 
			// miProjectDisplayTable
			// 
			this.miProjectDisplayTable.Name = "miProjectDisplayTable";
			this.miProjectDisplayTable.Size = new System.Drawing.Size(152, 22);
			this.miProjectDisplayTable.Text = "Table";
			this.miProjectDisplayTable.Click += new System.EventHandler(this.miProjectDisplayTable_Click);
			// 
			// miProjectDisplayTree
			// 
			this.miProjectDisplayTree.Name = "miProjectDisplayTree";
			this.miProjectDisplayTree.Size = new System.Drawing.Size(152, 22);
			this.miProjectDisplayTree.Text = "Tree";
			this.miProjectDisplayTree.Click += new System.EventHandler(this.miProjectDisplayTree_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// NotesOblitusApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.tcProjects);
			this.Controls.Add(this.msMainMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.msMainMenu;
			this.Name = "NotesOblitusApp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Notes Oblitus";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NotesOblitusApp_FormClosed);
			this.Shown += new System.EventHandler(this.NotesOblitusApp_Shown);
			this.VisibleChanged += new System.EventHandler(this.NotesOblitusApp_VisibleChanged);
			this.msMainMenu.ResumeLayout(false);
			this.msMainMenu.PerformLayout();
			this.msNotifyMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip msMainMenu;
		private System.Windows.Forms.ToolStripMenuItem miFile;
		private System.Windows.Forms.ToolStripMenuItem miFileOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem miFileExit;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miAboutHelp;
		private System.Windows.Forms.ToolStripMenuItem miAboutAbout;
		private System.Windows.Forms.NotifyIcon niMainNotify;
		private System.Windows.Forms.ContextMenuStrip msNotifyMenu;
		private System.Windows.Forms.ToolStripMenuItem miNotifyAbout;
		private System.Windows.Forms.ToolStripMenuItem miNotifyExit;
		private System.Windows.Forms.ToolStripMenuItem miFileRecentProjects;
		private System.Windows.Forms.ToolStripMenuItem miFileRecentSearches;
		private CellSharpControls.EditableTabControl tcProjects;
		private System.Windows.Forms.ToolStripMenuItem miProjectSave;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miProjectSaveAs;
		private System.Windows.Forms.ToolStripMenuItem exportAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem miProjectScanDir;
		private System.Windows.Forms.ToolStripMenuItem miProjectRefresh;
		private System.Windows.Forms.ToolStripMenuItem displayAsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem miProjectOptions;
		private System.Windows.Forms.ToolStripMenuItem miProjectStatistics;
		private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miProjectExportXml;
		private System.Windows.Forms.ToolStripMenuItem miProjectExportJson;
		private System.Windows.Forms.ToolStripMenuItem miProjectDisplayTable;
		private System.Windows.Forms.ToolStripMenuItem miProjectDisplayTree;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}

