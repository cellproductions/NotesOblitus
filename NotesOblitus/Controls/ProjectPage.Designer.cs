namespace NotesOblitus.Controls
{
	partial class ProjectPage
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
			this.tableLayoutPanel1.SuspendLayout();
			this.htcMainView.SuspendLayout();
			this.tpTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgListNotes)).BeginInit();
			this.tpTree.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tbInitialPath, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.htcMainView, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(545, 425);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// tbInitialPath
			// 
			this.tbInitialPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbInitialPath.Location = new System.Drawing.Point(3, 3);
			this.tbInitialPath.Name = "tbInitialPath";
			this.tbInitialPath.PlaceHolder = "Project search path";
			this.tbInitialPath.Size = new System.Drawing.Size(539, 20);
			this.tbInitialPath.TabIndex = 0;
			// 
			// htcMainView
			// 
			this.htcMainView.Controls.Add(this.tpTable);
			this.htcMainView.Controls.Add(this.tpTree);
			this.htcMainView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.htcMainView.Location = new System.Drawing.Point(3, 28);
			this.htcMainView.Name = "htcMainView";
			this.htcMainView.SelectedIndex = 0;
			this.htcMainView.Size = new System.Drawing.Size(539, 394);
			this.htcMainView.TabIndex = 1;
			// 
			// tpTable
			// 
			this.tpTable.Controls.Add(this.dgListNotes);
			this.tpTable.Location = new System.Drawing.Point(4, 22);
			this.tpTable.Name = "tpTable";
			this.tpTable.Size = new System.Drawing.Size(531, 368);
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
			this.dgListNotes.Size = new System.Drawing.Size(531, 368);
			this.dgListNotes.TabIndex = 0;
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
			// 
			// ProjecPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ProjecPage";
			this.Size = new System.Drawing.Size(545, 425);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.htcMainView.ResumeLayout(false);
			this.tpTable.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgListNotes)).EndInit();
			this.tpTree.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private TextBoxPlaceHolder tbInitialPath;
		private HiddenTabControl htcMainView;
		private System.Windows.Forms.TabPage tpTable;
		private System.Windows.Forms.DataGridView dgListNotes;
		private System.Windows.Forms.DataGridViewTextBoxColumn cFile;
		private System.Windows.Forms.DataGridViewTextBoxColumn cLine;
		private System.Windows.Forms.DataGridViewTextBoxColumn cTag;
		private System.Windows.Forms.DataGridViewTextBoxColumn cMessage;
		private System.Windows.Forms.TabPage tpTree;
		private System.Windows.Forms.TreeView tvListNotes;
	}
}
