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
			this.miFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.miFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.miFileRead = new System.Windows.Forms.ToolStripMenuItem();
			this.miFileRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.miFileAutoRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.miFileExport = new System.Windows.Forms.ToolStripMenuItem();
			this.miExportXml = new System.Windows.Forms.ToolStripMenuItem();
			this.miExportJson = new System.Windows.Forms.ToolStripMenuItem();
			this.miFileRecentProjects = new System.Windows.Forms.ToolStripMenuItem();
			this.miFileRecentSearches = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.miFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.displayAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miViewTable = new System.Windows.Forms.ToolStripMenuItem();
			this.miViewTree = new System.Windows.Forms.ToolStripMenuItem();
			this.miViewStatistics = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miEditPreview = new System.Windows.Forms.ToolStripMenuItem();
			this.miEditEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.miEditDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.miEditOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miAboutHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.miAboutAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.niMainNotify = new System.Windows.Forms.NotifyIcon(this.components);
			this.msNotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miNotifyAuto = new System.Windows.Forms.ToolStripMenuItem();
			this.miNotifyAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.miNotifyExit = new System.Windows.Forms.ToolStripMenuItem();
			this.tcProjects = new CellSharpControls.EditableTabControl();
			this.msMainMenu.SuspendLayout();
			this.msNotifyMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// msMainMenu
			// 
			this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.viewToolStripMenuItem,
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
            this.miFileSave,
            this.miFileSaveAs,
            this.toolStripSeparator1,
            this.miFileRead,
            this.miFileRefresh,
            this.miFileAutoRefresh,
            this.toolStripSeparator2,
            this.miFileExport,
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
			this.miFileOpen.Size = new System.Drawing.Size(195, 22);
			this.miFileOpen.Text = "Open";
			this.miFileOpen.Click += new System.EventHandler(this.miFileOpen_Click);
			// 
			// miFileSave
			// 
			this.miFileSave.Name = "miFileSave";
			this.miFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.miFileSave.Size = new System.Drawing.Size(195, 22);
			this.miFileSave.Text = "Save";
			this.miFileSave.Click += new System.EventHandler(this.miFileSave_Click);
			// 
			// miFileSaveAs
			// 
			this.miFileSaveAs.Name = "miFileSaveAs";
			this.miFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.miFileSaveAs.Size = new System.Drawing.Size(195, 22);
			this.miFileSaveAs.Text = "Save As...";
			this.miFileSaveAs.Click += new System.EventHandler(this.miFileSaveAs_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
			// 
			// miFileRead
			// 
			this.miFileRead.Name = "miFileRead";
			this.miFileRead.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.miFileRead.Size = new System.Drawing.Size(195, 22);
			this.miFileRead.Text = "Scan Directory";
			this.miFileRead.Click += new System.EventHandler(this.miFileRead_Click);
			// 
			// miFileRefresh
			// 
			this.miFileRefresh.Name = "miFileRefresh";
			this.miFileRefresh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.miFileRefresh.Size = new System.Drawing.Size(195, 22);
			this.miFileRefresh.Text = "Refresh";
			this.miFileRefresh.Click += new System.EventHandler(this.miFileRefresh_Click);
			// 
			// miFileAutoRefresh
			// 
			this.miFileAutoRefresh.CheckOnClick = true;
			this.miFileAutoRefresh.Name = "miFileAutoRefresh";
			this.miFileAutoRefresh.Size = new System.Drawing.Size(195, 22);
			this.miFileAutoRefresh.Text = "Auto Refresh";
			this.miFileAutoRefresh.Click += new System.EventHandler(this.miFileAutoRefresh_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
			// 
			// miFileExport
			// 
			this.miFileExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExportXml,
            this.miExportJson});
			this.miFileExport.Name = "miFileExport";
			this.miFileExport.Size = new System.Drawing.Size(195, 22);
			this.miFileExport.Text = "Export As...";
			// 
			// miExportXml
			// 
			this.miExportXml.Name = "miExportXml";
			this.miExportXml.Size = new System.Drawing.Size(98, 22);
			this.miExportXml.Text = "XML";
			this.miExportXml.Click += new System.EventHandler(this.miExportXml_Click);
			// 
			// miExportJson
			// 
			this.miExportJson.Name = "miExportJson";
			this.miExportJson.Size = new System.Drawing.Size(98, 22);
			this.miExportJson.Text = "Json";
			this.miExportJson.Click += new System.EventHandler(this.miExportJson_Click);
			// 
			// miFileRecentProjects
			// 
			this.miFileRecentProjects.Name = "miFileRecentProjects";
			this.miFileRecentProjects.Size = new System.Drawing.Size(195, 22);
			this.miFileRecentProjects.Text = "Recent Projects";
			// 
			// miFileRecentSearches
			// 
			this.miFileRecentSearches.Name = "miFileRecentSearches";
			this.miFileRecentSearches.Size = new System.Drawing.Size(195, 22);
			this.miFileRecentSearches.Text = "Recent Search Paths";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
			// 
			// miFileExit
			// 
			this.miFileExit.Name = "miFileExit";
			this.miFileExit.Size = new System.Drawing.Size(195, 22);
			this.miFileExit.Text = "Exit";
			this.miFileExit.Click += new System.EventHandler(this.miFileExit_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayAsToolStripMenuItem,
            this.miViewStatistics});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// displayAsToolStripMenuItem
			// 
			this.displayAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miViewTable,
            this.miViewTree});
			this.displayAsToolStripMenuItem.Name = "displayAsToolStripMenuItem";
			this.displayAsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.displayAsToolStripMenuItem.Text = "Display As";
			// 
			// miViewTable
			// 
			this.miViewTable.Name = "miViewTable";
			this.miViewTable.Size = new System.Drawing.Size(103, 22);
			this.miViewTable.Text = "Table";
			this.miViewTable.Click += new System.EventHandler(this.miViewTable_Click);
			// 
			// miViewTree
			// 
			this.miViewTree.Name = "miViewTree";
			this.miViewTree.Size = new System.Drawing.Size(103, 22);
			this.miViewTree.Text = "Tree";
			this.miViewTree.Click += new System.EventHandler(this.miViewTree_Click);
			// 
			// miViewStatistics
			// 
			this.miViewStatistics.Name = "miViewStatistics";
			this.miViewStatistics.Size = new System.Drawing.Size(128, 22);
			this.miViewStatistics.Text = "Statistics";
			this.miViewStatistics.Click += new System.EventHandler(this.miViewStatistics_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEditPreview,
            this.miEditEdit,
            this.miEditDelete,
            this.toolStripSeparator4,
            this.miEditOptions});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// miEditPreview
			// 
			this.miEditPreview.Name = "miEditPreview";
			this.miEditPreview.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.miEditPreview.Size = new System.Drawing.Size(187, 22);
			this.miEditPreview.Text = "Preview";
			this.miEditPreview.Click += new System.EventHandler(this.miEditPreview_Click);
			// 
			// miEditEdit
			// 
			this.miEditEdit.Name = "miEditEdit";
			this.miEditEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.miEditEdit.Size = new System.Drawing.Size(187, 22);
			this.miEditEdit.Text = "Edit Externally";
			this.miEditEdit.Click += new System.EventHandler(this.miEditEdit_Click);
			// 
			// miEditDelete
			// 
			this.miEditDelete.Name = "miEditDelete";
			this.miEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.miEditDelete.Size = new System.Drawing.Size(187, 22);
			this.miEditDelete.Text = "Delete Selected";
			this.miEditDelete.Click += new System.EventHandler(this.miEditDelete_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
			// 
			// miEditOptions
			// 
			this.miEditOptions.Name = "miEditOptions";
			this.miEditOptions.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.miEditOptions.Size = new System.Drawing.Size(187, 22);
			this.miEditOptions.Text = "Options";
			this.miEditOptions.Click += new System.EventHandler(this.miEditOptions_Click);
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
			this.miAboutHelp.Size = new System.Drawing.Size(126, 22);
			this.miAboutHelp.Text = "Help";
			this.miAboutHelp.Click += new System.EventHandler(this.miAboutHelp_Click);
			// 
			// miAboutAbout
			// 
			this.miAboutAbout.Name = "miAboutAbout";
			this.miAboutAbout.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.miAboutAbout.Size = new System.Drawing.Size(126, 22);
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
            this.miNotifyAuto,
            this.miNotifyAbout,
            this.miNotifyExit});
			this.msNotifyMenu.Name = "msNotifyMenu";
			this.msNotifyMenu.Size = new System.Drawing.Size(143, 70);
			this.msNotifyMenu.Opening += new System.ComponentModel.CancelEventHandler(this.msNotifyMenu_Opening);
			// 
			// miNotifyAuto
			// 
			this.miNotifyAuto.CheckOnClick = true;
			this.miNotifyAuto.Name = "miNotifyAuto";
			this.miNotifyAuto.Size = new System.Drawing.Size(142, 22);
			this.miNotifyAuto.Text = "Auto Refresh";
			this.miNotifyAuto.Click += new System.EventHandler(this.miNotifyAuto_Click);
			// 
			// miNotifyAbout
			// 
			this.miNotifyAbout.Name = "miNotifyAbout";
			this.miNotifyAbout.Size = new System.Drawing.Size(142, 22);
			this.miNotifyAbout.Text = "About";
			this.miNotifyAbout.Click += new System.EventHandler(this.miNotifyAbout_Click);
			// 
			// miNotifyExit
			// 
			this.miNotifyExit.Name = "miNotifyExit";
			this.miNotifyExit.Size = new System.Drawing.Size(142, 22);
			this.miNotifyExit.Text = "Exit";
			this.miNotifyExit.Click += new System.EventHandler(this.miNotifyExit_Click);
			// 
			// tcProjects
			// 
			this.tcProjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcProjects.Location = new System.Drawing.Point(0, 24);
			this.tcProjects.Name = "tcProjects";
			this.tcProjects.SelectedIndex = 0;
			this.tcProjects.Size = new System.Drawing.Size(784, 538);
			this.tcProjects.TabIndex = 1;
			this.tcProjects.TabMouseDown += new CellSharpControls.EditableTabControl.TabMouseEvent(tcProjects_TabMouseDown);
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
		private System.Windows.Forms.ToolStripMenuItem miFileSave;
		private System.Windows.Forms.ToolStripMenuItem miFileSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem miFileRead;
		private System.Windows.Forms.ToolStripMenuItem miFileRefresh;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem miFileExport;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem miFileExit;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem displayAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miViewTable;
		private System.Windows.Forms.ToolStripMenuItem miViewTree;
		private System.Windows.Forms.ToolStripMenuItem miViewStatistics;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miEditPreview;
		private System.Windows.Forms.ToolStripMenuItem miEditEdit;
		private System.Windows.Forms.ToolStripMenuItem miEditDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem miEditOptions;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miAboutHelp;
		private System.Windows.Forms.ToolStripMenuItem miAboutAbout;
		private System.Windows.Forms.ToolStripMenuItem miExportXml;
		private System.Windows.Forms.ToolStripMenuItem miExportJson;
		private System.Windows.Forms.NotifyIcon niMainNotify;
		private System.Windows.Forms.ContextMenuStrip msNotifyMenu;
		private System.Windows.Forms.ToolStripMenuItem miNotifyAuto;
		private System.Windows.Forms.ToolStripMenuItem miNotifyAbout;
		private System.Windows.Forms.ToolStripMenuItem miNotifyExit;
		private System.Windows.Forms.ToolStripMenuItem miFileAutoRefresh;
		private System.Windows.Forms.ToolStripMenuItem miFileRecentProjects;
		private System.Windows.Forms.ToolStripMenuItem miFileRecentSearches;
		private CellSharpControls.EditableTabControl tcProjects;
	}
}

