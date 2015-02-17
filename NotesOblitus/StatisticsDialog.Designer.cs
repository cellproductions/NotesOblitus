namespace NotesOblitus
{
	partial class StatisticsDialog
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lFilesAvgEmptyCount = new System.Windows.Forms.Label();
			this.lFilesEmptyCount = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dgTagsView = new System.Windows.Forms.DataGridView();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lTagsTagCount = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dgFilesView = new System.Windows.Forms.DataGridView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lNotesScanTime = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lNotesNoteCount = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.lDirsAvgNote = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.lDirsAvgFile = new System.Windows.Forms.Label();
			this.lDirsDirCount = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.dgDirsView = new System.Windows.Forms.DataGridView();
			this.label11 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lFilesCharCount = new System.Windows.Forms.Label();
			this.lFilesLineCount = new System.Windows.Forms.Label();
			this.lFilesAvgNote = new System.Windows.Forms.Label();
			this.lFilesFileCount = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.exportAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miExportXml = new System.Windows.Forms.ToolStripMenuItem();
			this.miExportJson = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lines = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.chars = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.todos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmptyLines = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgTagsView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFilesView)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgDirsView)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lFilesAvgEmptyCount
			// 
			this.lFilesAvgEmptyCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lFilesAvgEmptyCount.Location = new System.Drawing.Point(186, 78);
			this.lFilesAvgEmptyCount.Name = "lFilesAvgEmptyCount";
			this.lFilesAvgEmptyCount.Size = new System.Drawing.Size(204, 13);
			this.lFilesAvgEmptyCount.TabIndex = 15;
			this.lFilesAvgEmptyCount.Text = "lFilesAvgEmptyCount";
			this.lFilesAvgEmptyCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lFilesEmptyCount
			// 
			this.lFilesEmptyCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lFilesEmptyCount.Location = new System.Drawing.Point(186, 63);
			this.lFilesEmptyCount.Name = "lFilesEmptyCount";
			this.lFilesEmptyCount.Size = new System.Drawing.Size(204, 13);
			this.lFilesEmptyCount.TabIndex = 13;
			this.lFilesEmptyCount.Text = "lFilesEmptyCount";
			this.lFilesEmptyCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 63);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(114, 13);
			this.label10.TabIndex = 12;
			this.label10.Text = "Total empty line count:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 78);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(164, 13);
			this.label12.TabIndex = 14;
			this.label12.Text = "Average empty line count per file:";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.dgTagsView);
			this.tabPage3.Controls.Add(this.lTagsTagCount);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(396, 312);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Tags";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// dgTagsView
			// 
			this.dgTagsView.AllowUserToAddRows = false;
			this.dgTagsView.AllowUserToDeleteRows = false;
			this.dgTagsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgTagsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgTagsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.count});
			this.dgTagsView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgTagsView.Location = new System.Drawing.Point(6, 86);
			this.dgTagsView.Name = "dgTagsView";
			this.dgTagsView.ReadOnly = true;
			this.dgTagsView.RowHeadersVisible = false;
			this.dgTagsView.RowHeadersWidth = 20;
			this.dgTagsView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgTagsView.Size = new System.Drawing.Size(384, 219);
			this.dgTagsView.TabIndex = 10;
			// 
			// name
			// 
			this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.name.HeaderText = "Name";
			this.name.Name = "name";
			this.name.ReadOnly = true;
			// 
			// count
			// 
			this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.count.HeaderText = "Todos";
			this.count.Name = "count";
			this.count.ReadOnly = true;
			// 
			// lTagsTagCount
			// 
			this.lTagsTagCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lTagsTagCount.Location = new System.Drawing.Point(290, 3);
			this.lTagsTagCount.Name = "lTagsTagCount";
			this.lTagsTagCount.Size = new System.Drawing.Size(100, 13);
			this.lTagsTagCount.TabIndex = 9;
			this.lTagsTagCount.Text = "lTagsTagCount";
			this.lTagsTagCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 70);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(34, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "Tags:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Total tag count: ";
			// 
			// dgFilesView
			// 
			this.dgFilesView.AllowUserToAddRows = false;
			this.dgFilesView.AllowUserToDeleteRows = false;
			this.dgFilesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgFilesView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgFilesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgFilesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.lines,
            this.chars,
            this.todos,
            this.EmptyLines});
			this.dgFilesView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgFilesView.Location = new System.Drawing.Point(6, 121);
			this.dgFilesView.Name = "dgFilesView";
			this.dgFilesView.ReadOnly = true;
			this.dgFilesView.RowHeadersVisible = false;
			this.dgFilesView.RowHeadersWidth = 20;
			this.dgFilesView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgFilesView.Size = new System.Drawing.Size(384, 185);
			this.dgFilesView.TabIndex = 11;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(404, 338);
			this.tabControl1.TabIndex = 3;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.lNotesScanTime);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.lNotesNoteCount);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(396, 312);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Notes";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// lNotesScanTime
			// 
			this.lNotesScanTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lNotesScanTime.Location = new System.Drawing.Point(290, 20);
			this.lNotesScanTime.Name = "lNotesScanTime";
			this.lNotesScanTime.Size = new System.Drawing.Size(100, 13);
			this.lNotesScanTime.TabIndex = 3;
			this.lNotesScanTime.Text = "lNotesScanTime";
			this.lNotesScanTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(82, 13);
			this.label9.TabIndex = 2;
			this.label9.Text = "Total scan time:";
			// 
			// lNotesNoteCount
			// 
			this.lNotesNoteCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lNotesNoteCount.Location = new System.Drawing.Point(290, 3);
			this.lNotesNoteCount.Name = "lNotesNoteCount";
			this.lNotesNoteCount.Size = new System.Drawing.Size(100, 13);
			this.lNotesNoteCount.TabIndex = 1;
			this.lNotesNoteCount.Text = "lNotesNoteCount";
			this.lNotesNoteCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Total note count: ";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.lDirsAvgNote);
			this.tabPage4.Controls.Add(this.label18);
			this.tabPage4.Controls.Add(this.lDirsAvgFile);
			this.tabPage4.Controls.Add(this.lDirsDirCount);
			this.tabPage4.Controls.Add(this.label15);
			this.tabPage4.Controls.Add(this.label16);
			this.tabPage4.Controls.Add(this.dgDirsView);
			this.tabPage4.Controls.Add(this.label11);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(396, 312);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Directories";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// lDirsAvgNote
			// 
			this.lDirsAvgNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lDirsAvgNote.Location = new System.Drawing.Point(186, 33);
			this.lDirsAvgNote.Name = "lDirsAvgNote";
			this.lDirsAvgNote.Size = new System.Drawing.Size(204, 13);
			this.lDirsAvgNote.TabIndex = 19;
			this.lDirsAvgNote.Text = "lDirsAvgNote";
			this.lDirsAvgNote.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(3, 33);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(168, 13);
			this.label18.TabIndex = 18;
			this.label18.Text = "Average note count per directory: ";
			// 
			// lDirsAvgFile
			// 
			this.lDirsAvgFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lDirsAvgFile.Location = new System.Drawing.Point(186, 18);
			this.lDirsAvgFile.Name = "lDirsAvgFile";
			this.lDirsAvgFile.Size = new System.Drawing.Size(204, 13);
			this.lDirsAvgFile.TabIndex = 17;
			this.lDirsAvgFile.Text = "lDirsAvgFile";
			this.lDirsAvgFile.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lDirsDirCount
			// 
			this.lDirsDirCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lDirsDirCount.Location = new System.Drawing.Point(186, 3);
			this.lDirsDirCount.Name = "lDirsDirCount";
			this.lDirsDirCount.Size = new System.Drawing.Size(204, 13);
			this.lDirsDirCount.TabIndex = 16;
			this.lDirsDirCount.Text = "lDirsDirCount";
			this.lDirsDirCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(3, 3);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(110, 13);
			this.label15.TabIndex = 15;
			this.label15.Text = "Total directory count: ";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(3, 18);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(160, 13);
			this.label16.TabIndex = 14;
			this.label16.Text = "Average file count per directory: ";
			// 
			// dgDirsView
			// 
			this.dgDirsView.AllowUserToAddRows = false;
			this.dgDirsView.AllowUserToDeleteRows = false;
			this.dgDirsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgDirsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgDirsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDirsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.dgDirsView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgDirsView.Location = new System.Drawing.Point(6, 121);
			this.dgDirsView.Name = "dgDirsView";
			this.dgDirsView.ReadOnly = true;
			this.dgDirsView.RowHeadersVisible = false;
			this.dgDirsView.RowHeadersWidth = 20;
			this.dgDirsView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgDirsView.Size = new System.Drawing.Size(384, 185);
			this.dgDirsView.TabIndex = 13;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 105);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 13);
			this.label11.TabIndex = 12;
			this.label11.Text = "Directories:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.lFilesAvgEmptyCount);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.lFilesEmptyCount);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.dgFilesView);
			this.tabPage2.Controls.Add(this.lFilesCharCount);
			this.tabPage2.Controls.Add(this.lFilesLineCount);
			this.tabPage2.Controls.Add(this.lFilesAvgNote);
			this.tabPage2.Controls.Add(this.lFilesFileCount);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(396, 312);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Files";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// lFilesCharCount
			// 
			this.lFilesCharCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lFilesCharCount.Location = new System.Drawing.Point(186, 48);
			this.lFilesCharCount.Name = "lFilesCharCount";
			this.lFilesCharCount.Size = new System.Drawing.Size(204, 13);
			this.lFilesCharCount.TabIndex = 10;
			this.lFilesCharCount.Text = "lFilesCharCount";
			this.lFilesCharCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lFilesLineCount
			// 
			this.lFilesLineCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lFilesLineCount.Location = new System.Drawing.Point(186, 33);
			this.lFilesLineCount.Name = "lFilesLineCount";
			this.lFilesLineCount.Size = new System.Drawing.Size(204, 13);
			this.lFilesLineCount.TabIndex = 9;
			this.lFilesLineCount.Text = "lFilesLineCount";
			this.lFilesLineCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lFilesAvgNote
			// 
			this.lFilesAvgNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lFilesAvgNote.Location = new System.Drawing.Point(186, 18);
			this.lFilesAvgNote.Name = "lFilesAvgNote";
			this.lFilesAvgNote.Size = new System.Drawing.Size(204, 13);
			this.lFilesAvgNote.TabIndex = 8;
			this.lFilesAvgNote.Text = "lFilesAvgNote";
			this.lFilesAvgNote.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lFilesFileCount
			// 
			this.lFilesFileCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lFilesFileCount.Location = new System.Drawing.Point(186, 3);
			this.lFilesFileCount.Name = "lFilesFileCount";
			this.lFilesFileCount.Size = new System.Drawing.Size(204, 13);
			this.lFilesFileCount.TabIndex = 7;
			this.lFilesFileCount.Text = "lFilesFileCount";
			this.lFilesFileCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 105);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Files:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Total file count: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Total character count: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Total line count: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(141, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Average note count per file: ";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(404, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// exportAsToolStripMenuItem
			// 
			this.exportAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExportXml,
            this.miExportJson});
			this.exportAsToolStripMenuItem.Name = "exportAsToolStripMenuItem";
			this.exportAsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.exportAsToolStripMenuItem.Text = "Export As...";
			// 
			// miExportXml
			// 
			this.miExportXml.Name = "miExportXml";
			this.miExportXml.Size = new System.Drawing.Size(152, 22);
			this.miExportXml.Text = "XML";
			this.miExportXml.Click += new System.EventHandler(this.miExportXml_Click);
			// 
			// miExportJson
			// 
			this.miExportJson.Name = "miExportJson";
			this.miExportJson.Size = new System.Drawing.Size(152, 22);
			this.miExportJson.Text = "Json";
			this.miExportJson.Click += new System.EventHandler(this.miExportJson_Click);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.HeaderText = "Directory Name";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Files";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 57;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Lines";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 57;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Notes";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 62;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Empty Lines";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 57;
			// 
			// fileName
			// 
			this.fileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.fileName.HeaderText = "File Name";
			this.fileName.Name = "fileName";
			this.fileName.ReadOnly = true;
			// 
			// lines
			// 
			this.lines.HeaderText = "Lines";
			this.lines.Name = "lines";
			this.lines.ReadOnly = true;
			this.lines.Width = 57;
			// 
			// chars
			// 
			this.chars.HeaderText = "Characters";
			this.chars.Name = "chars";
			this.chars.ReadOnly = true;
			this.chars.Width = 83;
			// 
			// todos
			// 
			this.todos.HeaderText = "Notes";
			this.todos.Name = "todos";
			this.todos.ReadOnly = true;
			this.todos.Width = 62;
			// 
			// EmptyLines
			// 
			this.EmptyLines.HeaderText = "Empty Lines";
			this.EmptyLines.Name = "EmptyLines";
			this.EmptyLines.ReadOnly = true;
			this.EmptyLines.Width = 57;
			// 
			// StatisticsDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 362);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.HelpButton = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "StatisticsDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Statistics";
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgTagsView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgFilesView)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgDirsView)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lFilesAvgEmptyCount;
		private System.Windows.Forms.Label lFilesEmptyCount;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.DataGridView dgTagsView;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn count;
		private System.Windows.Forms.Label lTagsTagCount;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dgFilesView;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label lNotesScanTime;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lNotesNoteCount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label lDirsAvgNote;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label lDirsAvgFile;
		private System.Windows.Forms.Label lDirsDirCount;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.DataGridView dgDirsView;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label lFilesCharCount;
		private System.Windows.Forms.Label lFilesLineCount;
		private System.Windows.Forms.Label lFilesAvgNote;
		private System.Windows.Forms.Label lFilesFileCount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem exportAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miExportXml;
		private System.Windows.Forms.ToolStripMenuItem miExportJson;
		private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
		private System.Windows.Forms.DataGridViewTextBoxColumn lines;
		private System.Windows.Forms.DataGridViewTextBoxColumn chars;
		private System.Windows.Forms.DataGridViewTextBoxColumn todos;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmptyLines;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
	}
}