using System;
using System.Drawing;

namespace NotesOblitus
{
    partial class PreviewDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewDialog));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.bOk = new System.Windows.Forms.Button();
			this.bOpen = new System.Windows.Forms.Button();
			this.bRemove = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.rtbLines = new System.Windows.Forms.RichTextBox();
			this.rtbPreview = new System.Windows.Forms.RichTextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 462);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
			this.tableLayoutPanel3.Controls.Add(this.bOk, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.bOpen, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.bRemove, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 430);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(478, 29);
			this.tableLayoutPanel3.TabIndex = 2;
			// 
			// bOk
			// 
			this.bOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.bOk.Location = new System.Drawing.Point(3, 3);
			this.bOk.Name = "bOk";
			this.bOk.Size = new System.Drawing.Size(78, 23);
			this.bOk.TabIndex = 0;
			this.bOk.Text = "Ok";
			this.bOk.UseVisualStyleBackColor = true;
			// 
			// bOpen
			// 
			this.bOpen.Location = new System.Drawing.Point(371, 3);
			this.bOpen.Name = "bOpen";
			this.bOpen.Size = new System.Drawing.Size(104, 23);
			this.bOpen.TabIndex = 2;
			this.bOpen.Text = "Open in Editor";
			this.bOpen.UseVisualStyleBackColor = true;
			this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
			// 
			// bRemove
			// 
			this.bRemove.Location = new System.Drawing.Point(87, 3);
			this.bRemove.Name = "bRemove";
			this.bRemove.Size = new System.Drawing.Size(121, 23);
			this.bRemove.TabIndex = 3;
			this.bRemove.Text = "Remove From Source";
			this.bRemove.UseVisualStyleBackColor = true;
			this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.tableLayoutPanel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(478, 421);
			this.panel1.TabIndex = 3;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.rtbLines, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.rtbPreview, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(474, 417);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// rtbLines
			// 
			this.rtbLines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.rtbLines.BackColor = System.Drawing.Color.White;
			this.rtbLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbLines.DetectUrls = false;
			this.rtbLines.Enabled = false;
			this.rtbLines.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbLines.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.rtbLines.Location = new System.Drawing.Point(4, 4);
			this.rtbLines.Name = "rtbLines";
			this.rtbLines.ReadOnly = true;
			this.rtbLines.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.rtbLines.Size = new System.Drawing.Size(38, 409);
			this.rtbLines.TabIndex = 4;
			this.rtbLines.Text = "1";
			this.rtbLines.WordWrap = false;
			// 
			// rtbPreview
			// 
			this.rtbPreview.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.rtbPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbPreview.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbPreview.Location = new System.Drawing.Point(50, 4);
			this.rtbPreview.Name = "rtbPreview";
			this.rtbPreview.ReadOnly = true;
			this.rtbPreview.Size = new System.Drawing.Size(420, 409);
			this.rtbPreview.TabIndex = 1;
			this.rtbPreview.Text = "";
			this.rtbPreview.WordWrap = false;
			this.rtbPreview.VScroll += new System.EventHandler(this.rtbPreview_VScroll);
			// 
			// PreviewDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(484, 462);
			this.Controls.Add(this.tableLayoutPanel1);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PreviewDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Preview";
			this.Resize += new System.EventHandler(this.onResize);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion


		public void onResize(object sender, EventArgs e)
	    {
		    rtbPreview.Size = Size - new Size(40, 91);
		    bOpen.Left = Size.Width - 132;
	    }

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button bOk;
		private System.Windows.Forms.Button bOpen;
		private System.Windows.Forms.Button bRemove;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.RichTextBox rtbLines;
		private System.Windows.Forms.RichTextBox rtbPreview;
    }
}