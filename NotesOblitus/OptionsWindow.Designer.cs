namespace NotesOblitus
{
	partial class OptionsWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsWindow));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lGeneralSeconds = new System.Windows.Forms.Label();
			this.bGeneralReplace = new System.Windows.Forms.Button();
			this.lGeneralEnd = new System.Windows.Forms.Label();
			this.lGeneralStart = new System.Windows.Forms.Label();
			this.tbGeneralEnd = new System.Windows.Forms.TextBox();
			this.tbGeneralStart = new System.Windows.Forms.TextBox();
			this.cbGeneralUpdate = new System.Windows.Forms.ComboBox();
			this.bGeneralUpdate = new System.Windows.Forms.Button();
			this.lGeneralDelete = new System.Windows.Forms.Label();
			this.cGeneralDelete = new System.Windows.Forms.CheckBox();
			this.lGeneralDepth = new System.Windows.Forms.Label();
			this.nGeneralDepth = new System.Windows.Forms.NumericUpDown();
			this.lGeneralInterval = new System.Windows.Forms.Label();
			this.nGeneralInterval = new System.Windows.Forms.NumericUpDown();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.nPreviewLineCount = new System.Windows.Forms.NumericUpDown();
			this.lPreviewLineCount = new System.Windows.Forms.Label();
			this.lPreviewMacros = new System.Windows.Forms.Label();
			this.cbPreviewMacros = new System.Windows.Forms.ComboBox();
			this.bPreviewEditor = new System.Windows.Forms.Button();
			this.tbPreviewArgs = new System.Windows.Forms.TextBox();
			this.lPreviewArgs = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.cFiltersFilter = new System.Windows.Forms.CheckBox();
			this.bFiltersRemoveTag = new System.Windows.Forms.Button();
			this.cbFiltersTags = new System.Windows.Forms.ComboBox();
			this.bFiltersAddTag = new System.Windows.Forms.Button();
			this.lFiltersTags = new System.Windows.Forms.Label();
			this.bFiltersAcceptPaths = new System.Windows.Forms.Button();
			this.lFiltersTypes = new System.Windows.Forms.Label();
			this.cbFiltersTypes = new System.Windows.Forms.ComboBox();
			this.bFiltersRemoveType = new System.Windows.Forms.Button();
			this.bFiltersAddType = new System.Windows.Forms.Button();
			this.tbPreviewEditor = new NotesOblitus.Controls.TextBoxPlaceHolder();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nGeneralDepth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nGeneralInterval)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nPreviewLineCount)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(284, 262);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.lGeneralSeconds);
			this.tabPage1.Controls.Add(this.bGeneralReplace);
			this.tabPage1.Controls.Add(this.lGeneralEnd);
			this.tabPage1.Controls.Add(this.lGeneralStart);
			this.tabPage1.Controls.Add(this.tbGeneralEnd);
			this.tabPage1.Controls.Add(this.tbGeneralStart);
			this.tabPage1.Controls.Add(this.cbGeneralUpdate);
			this.tabPage1.Controls.Add(this.bGeneralUpdate);
			this.tabPage1.Controls.Add(this.lGeneralDelete);
			this.tabPage1.Controls.Add(this.cGeneralDelete);
			this.tabPage1.Controls.Add(this.lGeneralDepth);
			this.tabPage1.Controls.Add(this.nGeneralDepth);
			this.tabPage1.Controls.Add(this.lGeneralInterval);
			this.tabPage1.Controls.Add(this.nGeneralInterval);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(276, 236);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "General";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// lGeneralSeconds
			// 
			this.lGeneralSeconds.AutoSize = true;
			this.lGeneralSeconds.Location = new System.Drawing.Point(166, 113);
			this.lGeneralSeconds.Name = "lGeneralSeconds";
			this.lGeneralSeconds.Size = new System.Drawing.Size(47, 13);
			this.lGeneralSeconds.TabIndex = 27;
			this.lGeneralSeconds.Text = "seconds";
			// 
			// bGeneralReplace
			// 
			this.bGeneralReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bGeneralReplace.Location = new System.Drawing.Point(154, 6);
			this.bGeneralReplace.Name = "bGeneralReplace";
			this.bGeneralReplace.Size = new System.Drawing.Size(116, 23);
			this.bGeneralReplace.TabIndex = 26;
			this.bGeneralReplace.Text = "Replace old styles";
			this.bGeneralReplace.UseVisualStyleBackColor = true;
			this.bGeneralReplace.Click += new System.EventHandler(this.bGeneralReplace_Click);
			// 
			// lGeneralEnd
			// 
			this.lGeneralEnd.AutoSize = true;
			this.lGeneralEnd.Location = new System.Drawing.Point(3, 62);
			this.lGeneralEnd.Name = "lGeneralEnd";
			this.lGeneralEnd.Size = new System.Drawing.Size(78, 13);
			this.lGeneralEnd.TabIndex = 25;
			this.lGeneralEnd.Text = "Note end style:";
			// 
			// lGeneralStart
			// 
			this.lGeneralStart.AutoSize = true;
			this.lGeneralStart.Location = new System.Drawing.Point(3, 36);
			this.lGeneralStart.Name = "lGeneralStart";
			this.lGeneralStart.Size = new System.Drawing.Size(80, 13);
			this.lGeneralStart.TabIndex = 24;
			this.lGeneralStart.Text = "Note start style:";
			// 
			// tbGeneralEnd
			// 
			this.tbGeneralEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbGeneralEnd.Location = new System.Drawing.Point(89, 59);
			this.tbGeneralEnd.Name = "tbGeneralEnd";
			this.tbGeneralEnd.Size = new System.Drawing.Size(181, 20);
			this.tbGeneralEnd.TabIndex = 23;
			// 
			// tbGeneralStart
			// 
			this.tbGeneralStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbGeneralStart.Location = new System.Drawing.Point(89, 33);
			this.tbGeneralStart.Name = "tbGeneralStart";
			this.tbGeneralStart.Size = new System.Drawing.Size(181, 20);
			this.tbGeneralStart.TabIndex = 22;
			// 
			// cbGeneralUpdate
			// 
			this.cbGeneralUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbGeneralUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGeneralUpdate.Enabled = false;
			this.cbGeneralUpdate.FormattingEnabled = true;
			this.cbGeneralUpdate.Items.AddRange(new object[] {
            "Automatically update",
            "Notify me of an update",
            "Do not check for updates"});
			this.cbGeneralUpdate.Location = new System.Drawing.Point(6, 180);
			this.cbGeneralUpdate.Name = "cbGeneralUpdate";
			this.cbGeneralUpdate.Size = new System.Drawing.Size(264, 21);
			this.cbGeneralUpdate.TabIndex = 21;
			// 
			// bGeneralUpdate
			// 
			this.bGeneralUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bGeneralUpdate.Enabled = false;
			this.bGeneralUpdate.ForeColor = System.Drawing.Color.ForestGreen;
			this.bGeneralUpdate.Location = new System.Drawing.Point(6, 207);
			this.bGeneralUpdate.Name = "bGeneralUpdate";
			this.bGeneralUpdate.Size = new System.Drawing.Size(264, 23);
			this.bGeneralUpdate.TabIndex = 20;
			this.bGeneralUpdate.Text = "No update available.";
			this.bGeneralUpdate.UseVisualStyleBackColor = true;
			// 
			// lGeneralDelete
			// 
			this.lGeneralDelete.AutoSize = true;
			this.lGeneralDelete.Location = new System.Drawing.Point(3, 11);
			this.lGeneralDelete.Name = "lGeneralDelete";
			this.lGeneralDelete.Size = new System.Drawing.Size(99, 13);
			this.lGeneralDelete.TabIndex = 14;
			this.lGeneralDelete.Text = "Delete from source:";
			// 
			// cGeneralDelete
			// 
			this.cGeneralDelete.AutoSize = true;
			this.cGeneralDelete.Location = new System.Drawing.Point(108, 10);
			this.cGeneralDelete.Name = "cGeneralDelete";
			this.cGeneralDelete.Size = new System.Drawing.Size(40, 17);
			this.cGeneralDelete.TabIndex = 15;
			this.cGeneralDelete.Text = "Off";
			this.cGeneralDelete.UseVisualStyleBackColor = true;
			this.cGeneralDelete.CheckedChanged += new System.EventHandler(this.cGeneralDelete_CheckedChanged);
			// 
			// lGeneralDepth
			// 
			this.lGeneralDepth.AutoSize = true;
			this.lGeneralDepth.Location = new System.Drawing.Point(3, 87);
			this.lGeneralDepth.Name = "lGeneralDepth";
			this.lGeneralDepth.Size = new System.Drawing.Size(74, 13);
			this.lGeneralDepth.TabIndex = 16;
			this.lGeneralDepth.Text = "Search depth:";
			// 
			// nGeneralDepth
			// 
			this.nGeneralDepth.Location = new System.Drawing.Point(89, 85);
			this.nGeneralDepth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nGeneralDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nGeneralDepth.Name = "nGeneralDepth";
			this.nGeneralDepth.ReadOnly = true;
			this.nGeneralDepth.Size = new System.Drawing.Size(71, 20);
			this.nGeneralDepth.TabIndex = 17;
			this.nGeneralDepth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// lGeneralInterval
			// 
			this.lGeneralInterval.AutoSize = true;
			this.lGeneralInterval.Location = new System.Drawing.Point(3, 113);
			this.lGeneralInterval.Name = "lGeneralInterval";
			this.lGeneralInterval.Size = new System.Drawing.Size(69, 13);
			this.lGeneralInterval.TabIndex = 18;
			this.lGeneralInterval.Text = "Auto interval:";
			// 
			// nGeneralInterval
			// 
			this.nGeneralInterval.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nGeneralInterval.Location = new System.Drawing.Point(89, 111);
			this.nGeneralInterval.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.nGeneralInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nGeneralInterval.Name = "nGeneralInterval";
			this.nGeneralInterval.ReadOnly = true;
			this.nGeneralInterval.Size = new System.Drawing.Size(71, 20);
			this.nGeneralInterval.TabIndex = 19;
			this.nGeneralInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tbPreviewEditor);
			this.tabPage2.Controls.Add(this.nPreviewLineCount);
			this.tabPage2.Controls.Add(this.lPreviewLineCount);
			this.tabPage2.Controls.Add(this.lPreviewMacros);
			this.tabPage2.Controls.Add(this.cbPreviewMacros);
			this.tabPage2.Controls.Add(this.bPreviewEditor);
			this.tabPage2.Controls.Add(this.tbPreviewArgs);
			this.tabPage2.Controls.Add(this.lPreviewArgs);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(276, 236);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Preview";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// nPreviewLineCount
			// 
			this.nPreviewLineCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.nPreviewLineCount.Location = new System.Drawing.Point(73, 102);
			this.nPreviewLineCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nPreviewLineCount.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.nPreviewLineCount.Name = "nPreviewLineCount";
			this.nPreviewLineCount.Size = new System.Drawing.Size(197, 20);
			this.nPreviewLineCount.TabIndex = 32;
			this.nPreviewLineCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// lPreviewLineCount
			// 
			this.lPreviewLineCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lPreviewLineCount.AutoSize = true;
			this.lPreviewLineCount.Location = new System.Drawing.Point(3, 104);
			this.lPreviewLineCount.Name = "lPreviewLineCount";
			this.lPreviewLineCount.Size = new System.Drawing.Size(64, 13);
			this.lPreviewLineCount.TabIndex = 31;
			this.lPreviewLineCount.Text = "Visible lines:";
			// 
			// lPreviewMacros
			// 
			this.lPreviewMacros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lPreviewMacros.AutoSize = true;
			this.lPreviewMacros.Location = new System.Drawing.Point(3, 191);
			this.lPreviewMacros.Name = "lPreviewMacros";
			this.lPreviewMacros.Size = new System.Drawing.Size(45, 13);
			this.lPreviewMacros.TabIndex = 30;
			this.lPreviewMacros.Text = "Macros:";
			// 
			// cbPreviewMacros
			// 
			this.cbPreviewMacros.AllowDrop = true;
			this.cbPreviewMacros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbPreviewMacros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPreviewMacros.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPreviewMacros.FormattingEnabled = true;
			this.cbPreviewMacros.Location = new System.Drawing.Point(6, 207);
			this.cbPreviewMacros.Name = "cbPreviewMacros";
			this.cbPreviewMacros.Size = new System.Drawing.Size(264, 23);
			this.cbPreviewMacros.TabIndex = 29;
			this.cbPreviewMacros.SelectedIndexChanged += new System.EventHandler(this.cbPreviewMacros_SelectedIndexChanged);
			// 
			// bPreviewEditor
			// 
			this.bPreviewEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bPreviewEditor.Location = new System.Drawing.Point(6, 6);
			this.bPreviewEditor.Name = "bPreviewEditor";
			this.bPreviewEditor.Size = new System.Drawing.Size(264, 25);
			this.bPreviewEditor.TabIndex = 26;
			this.bPreviewEditor.Text = "Editor target";
			this.bPreviewEditor.UseVisualStyleBackColor = true;
			this.bPreviewEditor.Click += new System.EventHandler(this.bPreviewEditor_Click);
			// 
			// tbPreviewArgs
			// 
			this.tbPreviewArgs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPreviewArgs.Location = new System.Drawing.Point(6, 76);
			this.tbPreviewArgs.Name = "tbPreviewArgs";
			this.tbPreviewArgs.Size = new System.Drawing.Size(264, 20);
			this.tbPreviewArgs.TabIndex = 28;
			// 
			// lPreviewArgs
			// 
			this.lPreviewArgs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lPreviewArgs.AutoSize = true;
			this.lPreviewArgs.Location = new System.Drawing.Point(3, 60);
			this.lPreviewArgs.Name = "lPreviewArgs";
			this.lPreviewArgs.Size = new System.Drawing.Size(89, 13);
			this.lPreviewArgs.TabIndex = 27;
			this.lPreviewArgs.Text = "Editor arguments:";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.cFiltersFilter);
			this.tabPage3.Controls.Add(this.bFiltersRemoveTag);
			this.tabPage3.Controls.Add(this.cbFiltersTags);
			this.tabPage3.Controls.Add(this.bFiltersAddTag);
			this.tabPage3.Controls.Add(this.lFiltersTags);
			this.tabPage3.Controls.Add(this.bFiltersAcceptPaths);
			this.tabPage3.Controls.Add(this.lFiltersTypes);
			this.tabPage3.Controls.Add(this.cbFiltersTypes);
			this.tabPage3.Controls.Add(this.bFiltersRemoveType);
			this.tabPage3.Controls.Add(this.bFiltersAddType);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(276, 236);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Filters";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// cFiltersFilter
			// 
			this.cFiltersFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cFiltersFilter.AutoSize = true;
			this.cFiltersFilter.Location = new System.Drawing.Point(197, 106);
			this.cFiltersFilter.Name = "cFiltersFilter";
			this.cFiltersFilter.Size = new System.Drawing.Size(71, 17);
			this.cFiltersFilter.TabIndex = 20;
			this.cFiltersFilter.Text = "Filter tags";
			this.cFiltersFilter.UseVisualStyleBackColor = true;
			// 
			// bFiltersRemoveTag
			// 
			this.bFiltersRemoveTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bFiltersRemoveTag.Location = new System.Drawing.Point(6, 158);
			this.bFiltersRemoveTag.Name = "bFiltersRemoveTag";
			this.bFiltersRemoveTag.Size = new System.Drawing.Size(264, 23);
			this.bFiltersRemoveTag.TabIndex = 24;
			this.bFiltersRemoveTag.Text = "Remove selected tag";
			this.bFiltersRemoveTag.UseVisualStyleBackColor = true;
			this.bFiltersRemoveTag.Click += new System.EventHandler(this.bFiltersRemoveTag_Click);
			// 
			// cbFiltersTags
			// 
			this.cbFiltersTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbFiltersTags.FormattingEnabled = true;
			this.cbFiltersTags.Location = new System.Drawing.Point(6, 129);
			this.cbFiltersTags.Name = "cbFiltersTags";
			this.cbFiltersTags.Size = new System.Drawing.Size(185, 21);
			this.cbFiltersTags.TabIndex = 21;
			this.cbFiltersTags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbFiltersTags_KeyDown);
			this.cbFiltersTags.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbFiltersTags_KeyUp);
			// 
			// bFiltersAddTag
			// 
			this.bFiltersAddTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bFiltersAddTag.Location = new System.Drawing.Point(197, 129);
			this.bFiltersAddTag.Name = "bFiltersAddTag";
			this.bFiltersAddTag.Size = new System.Drawing.Size(73, 23);
			this.bFiltersAddTag.TabIndex = 23;
			this.bFiltersAddTag.Text = "Add tag";
			this.bFiltersAddTag.UseVisualStyleBackColor = true;
			this.bFiltersAddTag.Click += new System.EventHandler(this.bFiltersAddTag_Click);
			// 
			// lFiltersTags
			// 
			this.lFiltersTags.AutoSize = true;
			this.lFiltersTags.Location = new System.Drawing.Point(3, 107);
			this.lFiltersTags.Name = "lFiltersTags";
			this.lFiltersTags.Size = new System.Drawing.Size(92, 13);
			this.lFiltersTags.TabIndex = 22;
			this.lFiltersTags.Text = "Unaccepted tags:";
			// 
			// bFiltersAcceptPaths
			// 
			this.bFiltersAcceptPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bFiltersAcceptPaths.Location = new System.Drawing.Point(6, 77);
			this.bFiltersAcceptPaths.Name = "bFiltersAcceptPaths";
			this.bFiltersAcceptPaths.Size = new System.Drawing.Size(264, 23);
			this.bFiltersAcceptPaths.TabIndex = 19;
			this.bFiltersAcceptPaths.Text = "Accepted files and folders";
			this.bFiltersAcceptPaths.UseVisualStyleBackColor = true;
			this.bFiltersAcceptPaths.Click += new System.EventHandler(this.bFiltersAcceptPaths_Click);
			// 
			// lFiltersTypes
			// 
			this.lFiltersTypes.AutoSize = true;
			this.lFiltersTypes.Location = new System.Drawing.Point(3, 3);
			this.lFiltersTypes.Name = "lFiltersTypes";
			this.lFiltersTypes.Size = new System.Drawing.Size(100, 13);
			this.lFiltersTypes.TabIndex = 15;
			this.lFiltersTypes.Text = "Accepted file types:";
			// 
			// cbFiltersTypes
			// 
			this.cbFiltersTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbFiltersTypes.FormattingEnabled = true;
			this.cbFiltersTypes.Location = new System.Drawing.Point(6, 19);
			this.cbFiltersTypes.MaxDropDownItems = 5;
			this.cbFiltersTypes.Name = "cbFiltersTypes";
			this.cbFiltersTypes.Size = new System.Drawing.Size(185, 21);
			this.cbFiltersTypes.Sorted = true;
			this.cbFiltersTypes.TabIndex = 16;
			this.cbFiltersTypes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbFiltersTypes_KeyDown);
			this.cbFiltersTypes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbFiltersTypes_KeyUp);
			// 
			// bFiltersRemoveType
			// 
			this.bFiltersRemoveType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bFiltersRemoveType.Location = new System.Drawing.Point(6, 48);
			this.bFiltersRemoveType.Name = "bFiltersRemoveType";
			this.bFiltersRemoveType.Size = new System.Drawing.Size(264, 23);
			this.bFiltersRemoveType.TabIndex = 17;
			this.bFiltersRemoveType.Text = "Remove selected type";
			this.bFiltersRemoveType.UseVisualStyleBackColor = true;
			this.bFiltersRemoveType.Click += new System.EventHandler(this.bFiltersRemoveType_Click);
			// 
			// bFiltersAddType
			// 
			this.bFiltersAddType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bFiltersAddType.Location = new System.Drawing.Point(197, 19);
			this.bFiltersAddType.Name = "bFiltersAddType";
			this.bFiltersAddType.Size = new System.Drawing.Size(73, 23);
			this.bFiltersAddType.TabIndex = 18;
			this.bFiltersAddType.Text = "Add type";
			this.bFiltersAddType.UseVisualStyleBackColor = true;
			this.bFiltersAddType.Click += new System.EventHandler(this.bFiltersAddType_Click);
			// 
			// tbPreviewEditor
			// 
			this.tbPreviewEditor.Location = new System.Drawing.Point(6, 37);
			this.tbPreviewEditor.Name = "tbPreviewEditor";
			this.tbPreviewEditor.PlaceHolder = "Editor executable path";
			this.tbPreviewEditor.Size = new System.Drawing.Size(264, 20);
			this.tbPreviewEditor.TabIndex = 33;
			// 
			// OptionsWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "OptionsWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Options";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nGeneralDepth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nGeneralInterval)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nPreviewLineCount)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button bGeneralReplace;
		private System.Windows.Forms.Label lGeneralEnd;
		private System.Windows.Forms.Label lGeneralStart;
		public System.Windows.Forms.TextBox tbGeneralEnd;
		public System.Windows.Forms.TextBox tbGeneralStart;
		public System.Windows.Forms.ComboBox cbGeneralUpdate;
		public System.Windows.Forms.Button bGeneralUpdate;
		private System.Windows.Forms.Label lGeneralDelete;
		public System.Windows.Forms.CheckBox cGeneralDelete;
		private System.Windows.Forms.Label lGeneralDepth;
		public System.Windows.Forms.NumericUpDown nGeneralDepth;
		private System.Windows.Forms.Label lGeneralInterval;
		public System.Windows.Forms.NumericUpDown nGeneralInterval;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		public System.Windows.Forms.NumericUpDown nPreviewLineCount;
		private System.Windows.Forms.Label lPreviewLineCount;
		private System.Windows.Forms.Label lPreviewMacros;
		public System.Windows.Forms.ComboBox cbPreviewMacros;
		private System.Windows.Forms.Button bPreviewEditor;
		public System.Windows.Forms.TextBox tbPreviewArgs;
		private System.Windows.Forms.Label lPreviewArgs;
		public System.Windows.Forms.CheckBox cFiltersFilter;
		private System.Windows.Forms.Button bFiltersRemoveTag;
		public System.Windows.Forms.ComboBox cbFiltersTags;
		private System.Windows.Forms.Button bFiltersAddTag;
		private System.Windows.Forms.Label lFiltersTags;
		private System.Windows.Forms.Button bFiltersAcceptPaths;
		private System.Windows.Forms.Label lFiltersTypes;
		public System.Windows.Forms.ComboBox cbFiltersTypes;
		private System.Windows.Forms.Button bFiltersRemoveType;
		private System.Windows.Forms.Button bFiltersAddType;
		private System.Windows.Forms.Label lGeneralSeconds;
		private Controls.TextBoxPlaceHolder tbPreviewEditor;
	}
}