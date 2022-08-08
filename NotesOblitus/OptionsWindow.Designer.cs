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
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.bGeneralCheckUpdate = new System.Windows.Forms.Button();
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
            this.tpPreview = new System.Windows.Forms.TabPage();
            this.tbPreviewEditor = new NotesOblitus.Controls.TextBoxPlaceHolder();
            this.nPreviewLineCount = new System.Windows.Forms.NumericUpDown();
            this.lPreviewLineCount = new System.Windows.Forms.Label();
            this.lPreviewMacros = new System.Windows.Forms.Label();
            this.cbPreviewMacros = new System.Windows.Forms.ComboBox();
            this.bPreviewEditor = new System.Windows.Forms.Button();
            this.tbPreviewArgs = new System.Windows.Forms.TextBox();
            this.lPreviewArgs = new System.Windows.Forms.Label();
            this.tpFilters = new System.Windows.Forms.TabPage();
            this.bFiltersInvert = new System.Windows.Forms.Button();
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
            this.tpProxy = new System.Windows.Forms.TabPage();
            this.cProxyUseProxy = new System.Windows.Forms.CheckBox();
            this.cProxyDefaultProxy = new System.Windows.Forms.CheckBox();
            this.cProxyShowPwd = new System.Windows.Forms.CheckBox();
            this.cProxyDefaultCreds = new System.Windows.Forms.CheckBox();
            this.tbProxyPassword = new NotesOblitus.Controls.TextBoxPlaceHolder();
            this.tbProxyUsername = new NotesOblitus.Controls.TextBoxPlaceHolder();
            this.tbProxyPort = new NotesOblitus.Controls.TextBoxPlaceHolder();
            this.tbProxyAddress = new NotesOblitus.Controls.TextBoxPlaceHolder();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGeneralDepth)).BeginInit();
            this.tpPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPreviewLineCount)).BeginInit();
            this.tpFilters.SuspendLayout();
            this.tpProxy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpGeneral);
            this.tabControl1.Controls.Add(this.tpPreview);
            this.tabControl1.Controls.Add(this.tpFilters);
            this.tabControl1.Controls.Add(this.tpProxy);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 262);
            this.tabControl1.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.bGeneralCheckUpdate);
            this.tpGeneral.Controls.Add(this.bGeneralReplace);
            this.tpGeneral.Controls.Add(this.lGeneralEnd);
            this.tpGeneral.Controls.Add(this.lGeneralStart);
            this.tpGeneral.Controls.Add(this.tbGeneralEnd);
            this.tpGeneral.Controls.Add(this.tbGeneralStart);
            this.tpGeneral.Controls.Add(this.cbGeneralUpdate);
            this.tpGeneral.Controls.Add(this.bGeneralUpdate);
            this.tpGeneral.Controls.Add(this.lGeneralDelete);
            this.tpGeneral.Controls.Add(this.cGeneralDelete);
            this.tpGeneral.Controls.Add(this.lGeneralDepth);
            this.tpGeneral.Controls.Add(this.nGeneralDepth);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(276, 236);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // bGeneralCheckUpdate
            // 
            this.bGeneralCheckUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bGeneralCheckUpdate.Location = new System.Drawing.Point(6, 207);
            this.bGeneralCheckUpdate.Name = "bGeneralCheckUpdate";
            this.bGeneralCheckUpdate.Size = new System.Drawing.Size(129, 23);
            this.bGeneralCheckUpdate.TabIndex = 28;
            this.bGeneralCheckUpdate.Text = "Check for updates";
            this.bGeneralCheckUpdate.UseVisualStyleBackColor = true;
            this.bGeneralCheckUpdate.Click += new System.EventHandler(this.bGeneralCheckUpdate_Click);
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
            this.bGeneralUpdate.CausesValidation = false;
            this.bGeneralUpdate.ForeColor = System.Drawing.Color.Firebrick;
            this.bGeneralUpdate.Location = new System.Drawing.Point(141, 207);
            this.bGeneralUpdate.Name = "bGeneralUpdate";
            this.bGeneralUpdate.Size = new System.Drawing.Size(129, 23);
            this.bGeneralUpdate.TabIndex = 20;
            this.bGeneralUpdate.Text = "No update available";
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
            // tpPreview
            // 
            this.tpPreview.Controls.Add(this.tbPreviewEditor);
            this.tpPreview.Controls.Add(this.nPreviewLineCount);
            this.tpPreview.Controls.Add(this.lPreviewLineCount);
            this.tpPreview.Controls.Add(this.lPreviewMacros);
            this.tpPreview.Controls.Add(this.cbPreviewMacros);
            this.tpPreview.Controls.Add(this.bPreviewEditor);
            this.tpPreview.Controls.Add(this.tbPreviewArgs);
            this.tpPreview.Controls.Add(this.lPreviewArgs);
            this.tpPreview.Location = new System.Drawing.Point(4, 22);
            this.tpPreview.Name = "tpPreview";
            this.tpPreview.Padding = new System.Windows.Forms.Padding(3);
            this.tpPreview.Size = new System.Drawing.Size(276, 236);
            this.tpPreview.TabIndex = 1;
            this.tpPreview.Text = "Preview";
            this.tpPreview.UseVisualStyleBackColor = true;
            // 
            // tbPreviewEditor
            // 
            this.tbPreviewEditor.Location = new System.Drawing.Point(6, 37);
            this.tbPreviewEditor.Name = "tbPreviewEditor";
            this.tbPreviewEditor.PlaceHolder = "Editor executable path";
            this.tbPreviewEditor.Size = new System.Drawing.Size(264, 20);
            this.tbPreviewEditor.TabIndex = 33;
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
            // tpFilters
            // 
            this.tpFilters.Controls.Add(this.bFiltersInvert);
            this.tpFilters.Controls.Add(this.cFiltersFilter);
            this.tpFilters.Controls.Add(this.bFiltersRemoveTag);
            this.tpFilters.Controls.Add(this.cbFiltersTags);
            this.tpFilters.Controls.Add(this.bFiltersAddTag);
            this.tpFilters.Controls.Add(this.lFiltersTags);
            this.tpFilters.Controls.Add(this.bFiltersAcceptPaths);
            this.tpFilters.Controls.Add(this.lFiltersTypes);
            this.tpFilters.Controls.Add(this.cbFiltersTypes);
            this.tpFilters.Controls.Add(this.bFiltersRemoveType);
            this.tpFilters.Controls.Add(this.bFiltersAddType);
            this.tpFilters.Location = new System.Drawing.Point(4, 22);
            this.tpFilters.Name = "tpFilters";
            this.tpFilters.Padding = new System.Windows.Forms.Padding(3);
            this.tpFilters.Size = new System.Drawing.Size(276, 236);
            this.tpFilters.TabIndex = 2;
            this.tpFilters.Text = "Filters";
            this.tpFilters.UseVisualStyleBackColor = true;
            // 
            // bFiltersInvert
            // 
            this.bFiltersInvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bFiltersInvert.Location = new System.Drawing.Point(6, 187);
            this.bFiltersInvert.Name = "bFiltersInvert";
            this.bFiltersInvert.Size = new System.Drawing.Size(262, 23);
            this.bFiltersInvert.TabIndex = 25;
            this.bFiltersInvert.Text = "Invert tag filter";
            this.bFiltersInvert.UseVisualStyleBackColor = true;
            this.bFiltersInvert.Click += new System.EventHandler(this.bFiltersInvert_Click);
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
            // tpProxy
            // 
            this.tpProxy.Controls.Add(this.cProxyUseProxy);
            this.tpProxy.Controls.Add(this.cProxyDefaultProxy);
            this.tpProxy.Controls.Add(this.cProxyShowPwd);
            this.tpProxy.Controls.Add(this.cProxyDefaultCreds);
            this.tpProxy.Controls.Add(this.tbProxyPassword);
            this.tpProxy.Controls.Add(this.tbProxyUsername);
            this.tpProxy.Controls.Add(this.tbProxyPort);
            this.tpProxy.Controls.Add(this.tbProxyAddress);
            this.tpProxy.Controls.Add(this.label1);
            this.tpProxy.Location = new System.Drawing.Point(4, 22);
            this.tpProxy.Name = "tpProxy";
            this.tpProxy.Padding = new System.Windows.Forms.Padding(3);
            this.tpProxy.Size = new System.Drawing.Size(276, 236);
            this.tpProxy.TabIndex = 3;
            this.tpProxy.Text = "Proxy";
            this.tpProxy.UseVisualStyleBackColor = true;
            // 
            // cProxyUseProxy
            // 
            this.cProxyUseProxy.AutoSize = true;
            this.cProxyUseProxy.Location = new System.Drawing.Point(6, 7);
            this.cProxyUseProxy.Name = "cProxyUseProxy";
            this.cProxyUseProxy.Size = new System.Drawing.Size(73, 17);
            this.cProxyUseProxy.TabIndex = 8;
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
            this.cProxyDefaultProxy.Location = new System.Drawing.Point(159, 6);
            this.cProxyDefaultProxy.Name = "cProxyDefaultProxy";
            this.cProxyDefaultProxy.Size = new System.Drawing.Size(108, 17);
            this.cProxyDefaultProxy.TabIndex = 7;
            this.cProxyDefaultProxy.Text = "Use default proxy";
            this.cProxyDefaultProxy.UseVisualStyleBackColor = true;
            this.cProxyDefaultProxy.CheckedChanged += new System.EventHandler(this.cProxyDefaultProxy_CheckedChanged);
            this.cProxyDefaultProxy.EnabledChanged += new System.EventHandler(this.cProxyDefaultProxy_EnabledChanged);
            // 
            // cProxyShowPwd
            // 
            this.cProxyShowPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cProxyShowPwd.AutoSize = true;
            this.cProxyShowPwd.Location = new System.Drawing.Point(168, 82);
            this.cProxyShowPwd.Name = "cProxyShowPwd";
            this.cProxyShowPwd.Size = new System.Drawing.Size(101, 17);
            this.cProxyShowPwd.TabIndex = 6;
            this.cProxyShowPwd.Text = "Show password";
            this.cProxyShowPwd.UseVisualStyleBackColor = true;
            this.cProxyShowPwd.CheckedChanged += new System.EventHandler(this.cProxyShowPwd_CheckedChanged);
            // 
            // cProxyDefaultCreds
            // 
            this.cProxyDefaultCreds.AutoSize = true;
            this.cProxyDefaultCreds.Location = new System.Drawing.Point(6, 82);
            this.cProxyDefaultCreds.Name = "cProxyDefaultCreds";
            this.cProxyDefaultCreds.Size = new System.Drawing.Size(134, 17);
            this.cProxyDefaultCreds.TabIndex = 5;
            this.cProxyDefaultCreds.Text = "Use default credentials";
            this.cProxyDefaultCreds.UseVisualStyleBackColor = true;
            this.cProxyDefaultCreds.CheckedChanged += new System.EventHandler(this.cProxyDefaultCreds_CheckedChanged);
            this.cProxyDefaultCreds.EnabledChanged += new System.EventHandler(this.cProxyDefaultCreds_EnabledChanged);
            // 
            // tbProxyPassword
            // 
            this.tbProxyPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProxyPassword.Location = new System.Drawing.Point(6, 131);
            this.tbProxyPassword.Name = "tbProxyPassword";
            this.tbProxyPassword.PlaceHolder = "Password";
            this.tbProxyPassword.Size = new System.Drawing.Size(263, 20);
            this.tbProxyPassword.TabIndex = 4;
            // 
            // tbProxyUsername
            // 
            this.tbProxyUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProxyUsername.Location = new System.Drawing.Point(6, 105);
            this.tbProxyUsername.Name = "tbProxyUsername";
            this.tbProxyUsername.PlaceHolder = "User name";
            this.tbProxyUsername.Size = new System.Drawing.Size(263, 20);
            this.tbProxyUsername.TabIndex = 3;
            // 
            // tbProxyPort
            // 
            this.tbProxyPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProxyPort.Location = new System.Drawing.Point(6, 56);
            this.tbProxyPort.Name = "tbProxyPort";
            this.tbProxyPort.PlaceHolder = "Proxy port";
            this.tbProxyPort.Size = new System.Drawing.Size(263, 20);
            this.tbProxyPort.TabIndex = 2;
            // 
            // tbProxyAddress
            // 
            this.tbProxyAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProxyAddress.Location = new System.Drawing.Point(6, 30);
            this.tbProxyAddress.Name = "tbProxyAddress";
            this.tbProxyAddress.PlaceHolder = "Proxy address";
            this.tbProxyAddress.Size = new System.Drawing.Size(263, 20);
            this.tbProxyAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
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
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGeneralDepth)).EndInit();
            this.tpPreview.ResumeLayout(false);
            this.tpPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPreviewLineCount)).EndInit();
            this.tpFilters.ResumeLayout(false);
            this.tpFilters.PerformLayout();
            this.tpProxy.ResumeLayout(false);
            this.tpProxy.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpGeneral;
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
		private System.Windows.Forms.TabPage tpPreview;
		private System.Windows.Forms.TabPage tpFilters;
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
		private Controls.TextBoxPlaceHolder tbPreviewEditor;
		private System.Windows.Forms.Button bGeneralCheckUpdate;
		private System.Windows.Forms.Button bFiltersInvert;
		private System.Windows.Forms.TabPage tpProxy;
		private Controls.TextBoxPlaceHolder tbProxyAddress;
		private System.Windows.Forms.Label label1;
		private Controls.TextBoxPlaceHolder tbProxyPassword;
		private Controls.TextBoxPlaceHolder tbProxyUsername;
		private Controls.TextBoxPlaceHolder tbProxyPort;
		private System.Windows.Forms.CheckBox cProxyDefaultProxy;
		private System.Windows.Forms.CheckBox cProxyShowPwd;
		private System.Windows.Forms.CheckBox cProxyDefaultCreds;
		private System.Windows.Forms.CheckBox cProxyUseProxy;
	}
}