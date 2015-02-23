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
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.niMainNotify = new System.Windows.Forms.NotifyIcon(this.components);
			this.msNotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miNotifyAuto = new System.Windows.Forms.ToolStripMenuItem();
			this.miNotifyAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.miNotifyExit = new System.Windows.Forms.ToolStripMenuItem();
			this.tbInitialPath = new NotesOblitus.Controls.TextBoxPlaceHolder();
			this.htcMainView = new NotesOblitus.Controls.HiddenTabControl();
			this.tpTable = new System.Windows.Forms.TabPage();
			this.dgListNotes = new System.Windows.Forms.DataGridView();
			this.cFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tpTree = new System.Windows.Forms.TabPage();
			this.tvListNotes = new System.Windows.Forms.TreeView();
			this.msMainMenu.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.msNotifyMenu.SuspendLayout();
			this.htcMainView.SuspendLayout();
			this.tpTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgListNotes)).BeginInit();
			this.tpTree.SuspendLayout();
			this.SuspendLayout();
			// 
			// msMainMenu
			// 
			this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.msMainMenu.Location = new System.Drawing.Point(0, 0);
			this.msMainMenu.Name = "msMainMenu";
			this.msMainMenu.Size = new System.Drawing.Size(784, 24);
			this.msMainMenu.TabIndex = 0;
			this.msMainMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileOpen,
            this.miFileSave,
            this.miFileSaveAs,
            this.toolStripSeparator1,
            this.miFileRead,
            this.miFileRefresh,
            this.miFileAutoRefresh,
            this.toolStripSeparator2,
            this.miFileExport,
            this.toolStripSeparator3,
            this.miFileExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
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
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tbInitialPath, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.htcMainView, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 538);
			this.tableLayoutPanel1.TabIndex = 1;
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
			// tbInitialPath
			// 
			this.tbInitialPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbInitialPath.Location = new System.Drawing.Point(3, 3);
			this.tbInitialPath.Name = "tbInitialPath";
			this.tbInitialPath.PlaceHolder = "Project search path";
			this.tbInitialPath.Size = new System.Drawing.Size(778, 20);
			this.tbInitialPath.TabIndex = 0;
			this.tbInitialPath.TextChanged += new System.EventHandler(this.tbInitialPath_TextChanged);
			this.tbInitialPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInitialPath_KeyDown);
			this.tbInitialPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbInitialPath_KeyUp);
			// 
			// htcMainView
			// 
			this.htcMainView.Controls.Add(this.tpTable);
			this.htcMainView.Controls.Add(this.tpTree);
			this.htcMainView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.htcMainView.Location = new System.Drawing.Point(3, 28);
			this.htcMainView.Name = "htcMainView";
			this.htcMainView.SelectedIndex = 0;
			this.htcMainView.Size = new System.Drawing.Size(778, 507);
			this.htcMainView.TabIndex = 1;
			this.htcMainView.SelectedIndexChanged += new System.EventHandler(this.htcMainView_SelectedIndexChanged);
			// 
			// tpTable
			// 
			this.tpTable.Controls.Add(this.dgListNotes);
			this.tpTable.Location = new System.Drawing.Point(4, 22);
			this.tpTable.Name = "tpTable";
			this.tpTable.Size = new System.Drawing.Size(770, 481);
			this.tpTable.TabIndex = 0;
			this.tpTable.Text = "tpTable";
			this.tpTable.UseVisualStyleBackColor = true;
			// 
			// dgListNotes
			// 
			this.dgListNotes.AllowUserToAddRows = false;
			this.dgListNotes.AllowUserToDeleteRows = false;
			this.dgListNotes.AllowUserToResizeRows = false;
			this.dgListNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgListNotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgListNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgListNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cFile,
            this.cLine,
            this.cTag,
            this.cMessage});
			this.dgListNotes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgListNotes.Location = new System.Drawing.Point(0, 0);
			this.dgListNotes.MultiSelect = false;
			this.dgListNotes.Name = "dgListNotes";
			this.dgListNotes.ReadOnly = true;
			this.dgListNotes.RowHeadersVisible = false;
			this.dgListNotes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgListNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgListNotes.Size = new System.Drawing.Size(770, 481);
			this.dgListNotes.TabIndex = 0;
			this.dgListNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListNotes_CellDoubleClick);
			this.dgListNotes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgListNotes_CellMouseClick);
			this.dgListNotes.SelectionChanged += new System.EventHandler(this.dgListNotes_SelectionChanged);
			// 
			// cFile
			// 
			this.cFile.HeaderText = "File:";
			this.cFile.Name = "cFile";
			this.cFile.ReadOnly = true;
			// 
			// cLine
			// 
			this.cLine.FillWeight = 20F;
			this.cLine.HeaderText = "Line:";
			this.cLine.Name = "cLine";
			this.cLine.ReadOnly = true;
			// 
			// cTag
			// 
			this.cTag.FillWeight = 50F;
			this.cTag.HeaderText = "Tag:";
			this.cTag.Name = "cTag";
			this.cTag.ReadOnly = true;
			// 
			// cMessage
			// 
			this.cMessage.HeaderText = "Message:";
			this.cMessage.Name = "cMessage";
			this.cMessage.ReadOnly = true;
			// 
			// tpTree
			// 
			this.tpTree.Controls.Add(this.tvListNotes);
			this.tpTree.Location = new System.Drawing.Point(4, 22);
			this.tpTree.Name = "tpTree";
			this.tpTree.Size = new System.Drawing.Size(770, 481);
			this.tpTree.TabIndex = 1;
			this.tpTree.Text = "tpTree";
			this.tpTree.UseVisualStyleBackColor = true;
			// 
			// tvListNotes
			// 
			this.tvListNotes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvListNotes.Location = new System.Drawing.Point(0, 0);
			this.tvListNotes.Name = "tvListNotes";
			this.tvListNotes.ShowNodeToolTips = true;
			this.tvListNotes.Size = new System.Drawing.Size(770, 481);
			this.tvListNotes.TabIndex = 0;
			this.tvListNotes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvListNotes_AfterSelect);
			this.tvListNotes.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvListNotes_NodeMouseClick);
			this.tvListNotes.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvListNotes_NodeMouseDoubleClick);
			// 
			// NotesOblitusApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.tableLayoutPanel1);
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
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.msNotifyMenu.ResumeLayout(false);
			this.htcMainView.ResumeLayout(false);
			this.tpTable.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgListNotes)).EndInit();
			this.tpTree.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip msMainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
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
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TabPage tpTable;
		private System.Windows.Forms.TabPage tpTree;
		private System.Windows.Forms.DataGridView dgListNotes;
		private System.Windows.Forms.DataGridViewTextBoxColumn cFile;
		private System.Windows.Forms.DataGridViewTextBoxColumn cLine;
		private System.Windows.Forms.DataGridViewTextBoxColumn cTag;
		private System.Windows.Forms.DataGridViewTextBoxColumn cMessage;
		private System.Windows.Forms.TreeView tvListNotes;
		private System.Windows.Forms.ToolStripMenuItem miExportXml;
		private System.Windows.Forms.ToolStripMenuItem miExportJson;
		private System.Windows.Forms.NotifyIcon niMainNotify;
		private System.Windows.Forms.ContextMenuStrip msNotifyMenu;
		private System.Windows.Forms.ToolStripMenuItem miNotifyAuto;
		private System.Windows.Forms.ToolStripMenuItem miNotifyAbout;
		private System.Windows.Forms.ToolStripMenuItem miNotifyExit;
		private System.Windows.Forms.ToolStripMenuItem miFileAutoRefresh;
		private TextBoxPlaceHolder tbInitialPath;
		private HiddenTabControl htcMainView;
	}
}

