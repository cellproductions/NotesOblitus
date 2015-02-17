namespace NotesOblitus
{
	partial class ReplaceNotesDialog
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lMessage = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.bNo = new System.Windows.Forms.Button();
			this.bYes = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tbNoteStart = new NotesOblitus.Controls.TextBoxPlaceHolder();
			this.tbNoteEnd = new NotesOblitus.Controls.TextBoxPlaceHolder();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.lMessage, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 132);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lMessage
			// 
			this.lMessage.AutoSize = true;
			this.lMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lMessage.Location = new System.Drawing.Point(3, 4);
			this.lMessage.Name = "lMessage";
			this.lMessage.Size = new System.Drawing.Size(278, 26);
			this.lMessage.TabIndex = 0;
			this.lMessage.Text = "This will edit your original files. Are you sure you would like to continue?";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.bNo);
			this.flowLayoutPanel1.Controls.Add(this.bYes);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 100);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(278, 29);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// bNo
			// 
			this.bNo.DialogResult = System.Windows.Forms.DialogResult.No;
			this.bNo.Location = new System.Drawing.Point(200, 3);
			this.bNo.Name = "bNo";
			this.bNo.Size = new System.Drawing.Size(75, 23);
			this.bNo.TabIndex = 0;
			this.bNo.Text = "No";
			this.bNo.UseVisualStyleBackColor = true;
			// 
			// bYes
			// 
			this.bYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.bYes.Location = new System.Drawing.Point(119, 3);
			this.bYes.Name = "bYes";
			this.bYes.Size = new System.Drawing.Size(75, 23);
			this.bYes.TabIndex = 1;
			this.bYes.Text = "Yes";
			this.bYes.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.tbNoteStart, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tbNoteEnd, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(278, 61);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// tbNoteStart
			// 
			this.tbNoteStart.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tbNoteStart.Location = new System.Drawing.Point(3, 7);
			this.tbNoteStart.Name = "tbNoteStart";
			this.tbNoteStart.PlaceHolder = "Old note start style";
			this.tbNoteStart.Size = new System.Drawing.Size(272, 20);
			this.tbNoteStart.TabIndex = 0;
			// 
			// tbNoteEnd
			// 
			this.tbNoteEnd.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbNoteEnd.Location = new System.Drawing.Point(3, 33);
			this.tbNoteEnd.Name = "tbNoteEnd";
			this.tbNoteEnd.PlaceHolder = "Old note end style";
			this.tbNoteEnd.Size = new System.Drawing.Size(272, 20);
			this.tbNoteEnd.TabIndex = 1;
			// 
			// ReplaceNotesDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 132);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ReplaceNotesDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Replace Old Styles";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lMessage;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button bNo;
		private System.Windows.Forms.Button bYes;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private Controls.TextBoxPlaceHolder tbNoteStart;
		private Controls.TextBoxPlaceHolder tbNoteEnd;
	}
}