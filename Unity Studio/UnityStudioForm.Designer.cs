﻿namespace Unity_Studio
{
    partial class UnityStudioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnityStudioForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.extractBundleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniqueNames = new System.Windows.Forms.ToolStripMenuItem();
            this.enablePreview = new System.Windows.Forms.ToolStripMenuItem();
            this.displayInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.openAfterExport = new System.Windows.Forms.ToolStripMenuItem();
            this.assetGroupOptions = new System.Windows.Forms.ToolStripComboBox();
            this.showExpOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAll3DMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelected3DMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportAllAssetsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSelectedAssetsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFilteredAssetsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeSearch = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.assetListView = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSearch = new System.Windows.Forms.TextBox();
            this.progressbarPanel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.assetInfoLabel = new System.Windows.Forms.Label();
            this.FMODpanel = new System.Windows.Forms.Panel();
            this.FMODinfoLabel = new System.Windows.Forms.Label();
            this.FMODtimerLabel = new System.Windows.Forms.Label();
            this.FMODstatusLabel = new System.Windows.Forms.Label();
            this.FMODprogressBar = new System.Windows.Forms.TrackBar();
            this.FMODvolumeBar = new System.Windows.Forms.TrackBar();
            this.FMODloopButton = new System.Windows.Forms.CheckBox();
            this.FMODstopButton = new System.Windows.Forms.Button();
            this.FMODpauseButton = new System.Windows.Forms.Button();
            this.FMODplayButton = new System.Windows.Forms.Button();
            this.fontPreviewBox = new System.Windows.Forms.RichTextBox();
            this.textPreviewBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFolderDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFolderDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.treeTip = new System.Windows.Forms.ToolTip(this.components);
            this.sceneTreeView = new Unity_Studio.GOHierarchy();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.progressbarPanel.SuspendLayout();
            this.previewPanel.SuspendLayout();
            this.FMODpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FMODprogressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FMODvolumeBar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.loadFolderToolStripMenuItem,
            this.toolStripMenuItem1,
            this.extractBundleToolStripMenuItem,
            this.extractFolderToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.loadFileToolStripMenuItem.Text = "Load file...";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // loadFolderToolStripMenuItem
            // 
            this.loadFolderToolStripMenuItem.Name = "loadFolderToolStripMenuItem";
            this.loadFolderToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.loadFolderToolStripMenuItem.Text = "Load folder...";
            this.loadFolderToolStripMenuItem.Click += new System.EventHandler(this.loadFolder_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
            // 
            // extractBundleToolStripMenuItem
            // 
            this.extractBundleToolStripMenuItem.Name = "extractBundleToolStripMenuItem";
            this.extractBundleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.extractBundleToolStripMenuItem.Text = "Extract bundle...";
            this.extractBundleToolStripMenuItem.Click += new System.EventHandler(this.extractBundleToolStripMenuItem_Click);
            // 
            // extractFolderToolStripMenuItem
            // 
            this.extractFolderToolStripMenuItem.Name = "extractFolderToolStripMenuItem";
            this.extractFolderToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.extractFolderToolStripMenuItem.Text = "Extract folder...";
            this.extractFolderToolStripMenuItem.Click += new System.EventHandler(this.extractFolderToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uniqueNames,
            this.enablePreview,
            this.displayInfo,
            this.openAfterExport,
            this.assetGroupOptions,
            this.showExpOpt});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // uniqueNames
            // 
            this.uniqueNames.Checked = true;
            this.uniqueNames.CheckOnClick = true;
            this.uniqueNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uniqueNames.Name = "uniqueNames";
            this.uniqueNames.Size = new System.Drawing.Size(252, 22);
            this.uniqueNames.Text = "Unique exported filenames";
            this.uniqueNames.ToolTipText = resources.GetString("uniqueNames.ToolTipText");
            this.uniqueNames.CheckedChanged += new System.EventHandler(this.MenuItem_CheckedChanged);
            // 
            // enablePreview
            // 
            this.enablePreview.Checked = true;
            this.enablePreview.CheckOnClick = true;
            this.enablePreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enablePreview.Name = "enablePreview";
            this.enablePreview.Size = new System.Drawing.Size(252, 22);
            this.enablePreview.Text = "Enable preview";
            this.enablePreview.ToolTipText = "Toggle the loading and preview of readable assets, such as images, sounds, text, " +
    "etc.\r\nDisable preview if you have performance or compatibility issues.";
            this.enablePreview.CheckedChanged += new System.EventHandler(this.enablePreview_Check);
            // 
            // displayInfo
            // 
            this.displayInfo.Checked = true;
            this.displayInfo.CheckOnClick = true;
            this.displayInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayInfo.Name = "displayInfo";
            this.displayInfo.Size = new System.Drawing.Size(252, 22);
            this.displayInfo.Text = "Display asset infromation";
            this.displayInfo.ToolTipText = "Toggle the overlay that shows information about each asset, eg. image size, forma" +
    "t, audio bitrate, etc.";
            this.displayInfo.CheckedChanged += new System.EventHandler(this.displayAssetInfo_Check);
            // 
            // openAfterExport
            // 
            this.openAfterExport.Checked = true;
            this.openAfterExport.CheckOnClick = true;
            this.openAfterExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openAfterExport.Name = "openAfterExport";
            this.openAfterExport.Size = new System.Drawing.Size(252, 22);
            this.openAfterExport.Text = "Open file/folder after export";
            this.openAfterExport.CheckedChanged += new System.EventHandler(this.MenuItem_CheckedChanged);
            // 
            // assetGroupOptions
            // 
            this.assetGroupOptions.Items.AddRange(new object[] {
            "Group exported assets by type",
            "Group exported assets by source file",
            "Do not group exported assets"});
            this.assetGroupOptions.Name = "assetGroupOptions";
            this.assetGroupOptions.Size = new System.Drawing.Size(192, 23);
            this.assetGroupOptions.SelectedIndexChanged += new System.EventHandler(this.assetGroupOptions_SelectedIndexChanged);
            // 
            // showExpOpt
            // 
            this.showExpOpt.Name = "showExpOpt";
            this.showExpOpt.Size = new System.Drawing.Size(252, 22);
            this.showExpOpt.Text = "Export options...";
            this.showExpOpt.Click += new System.EventHandler(this.showExpOpt_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAll3DMenuItem,
            this.exportSelected3DMenuItem,
            this.toolStripSeparator1,
            this.exportAllAssetsMenuItem,
            this.exportSelectedAssetsMenuItem,
            this.exportFilteredAssetsMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportAll3DMenuItem
            // 
            this.exportAll3DMenuItem.Name = "exportAll3DMenuItem";
            this.exportAll3DMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exportAll3DMenuItem.Text = "All 3D objects";
            this.exportAll3DMenuItem.Click += new System.EventHandler(this.Export3DObjects_Click);
            // 
            // exportSelected3DMenuItem
            // 
            this.exportSelected3DMenuItem.Name = "exportSelected3DMenuItem";
            this.exportSelected3DMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exportSelected3DMenuItem.Text = "Selected 3D objects";
            this.exportSelected3DMenuItem.Click += new System.EventHandler(this.Export3DObjects_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // exportAllAssetsMenuItem
            // 
            this.exportAllAssetsMenuItem.Name = "exportAllAssetsMenuItem";
            this.exportAllAssetsMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exportAllAssetsMenuItem.Text = "All assets";
            this.exportAllAssetsMenuItem.Click += new System.EventHandler(this.ExportAssets_Click);
            // 
            // exportSelectedAssetsMenuItem
            // 
            this.exportSelectedAssetsMenuItem.Name = "exportSelectedAssetsMenuItem";
            this.exportSelectedAssetsMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exportSelectedAssetsMenuItem.Text = "Selected assets";
            this.exportSelectedAssetsMenuItem.Click += new System.EventHandler(this.ExportAssets_Click);
            // 
            // exportFilteredAssetsMenuItem
            // 
            this.exportFilteredAssetsMenuItem.Name = "exportFilteredAssetsMenuItem";
            this.exportFilteredAssetsMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exportFilteredAssetsMenuItem.Text = "Filtered assets";
            this.exportFilteredAssetsMenuItem.Click += new System.EventHandler(this.ExportAssets_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.progressbarPanel);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.previewPanel);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2MinSize = 400;
            this.splitContainer1.Size = new System.Drawing.Size(1264, 658);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.TabStop = false;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            this.splitContainer1.Resize += new System.EventHandler(this.splitContainer1_Resize);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(17, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(418, 634);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabPageSelected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sceneTreeView);
            this.tabPage1.Controls.Add(this.treeSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(410, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scene Hierarchy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeSearch
            // 
            this.treeSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.treeSearch.Location = new System.Drawing.Point(0, 0);
            this.treeSearch.Name = "treeSearch";
            this.treeSearch.Size = new System.Drawing.Size(410, 20);
            this.treeSearch.TabIndex = 0;
            this.treeSearch.Text = " Search ";
            this.treeSearch.Enter += new System.EventHandler(this.treeSearch_Enter);
            this.treeSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeSearch_KeyDown);
            this.treeSearch.Leave += new System.EventHandler(this.treeSearch_Leave);
            this.treeSearch.MouseEnter += new System.EventHandler(this.treeSearch_MouseEnter);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.assetListView);
            this.tabPage2.Controls.Add(this.listSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(410, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asset List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // assetListView
            // 
            this.assetListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderType,
            this.columnHeaderSize});
            this.assetListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetListView.FullRowSelect = true;
            this.assetListView.GridLines = true;
            this.assetListView.HideSelection = false;
            this.assetListView.LabelEdit = true;
            this.assetListView.Location = new System.Drawing.Point(0, 20);
            this.assetListView.Name = "assetListView";
            this.assetListView.Size = new System.Drawing.Size(410, 588);
            this.assetListView.TabIndex = 1;
            this.assetListView.UseCompatibleStateImageBehavior = false;
            this.assetListView.View = System.Windows.Forms.View.Details;
            this.assetListView.VirtualMode = true;
            this.assetListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.assetListView_ColumnClick);
            this.assetListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.selectAsset);
            this.assetListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.assetListView_RetrieveVirtualItem);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 240;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Type";
            this.columnHeaderType.Width = 88;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Size";
            // 
            // listSearch
            // 
            this.listSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.listSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.listSearch.Location = new System.Drawing.Point(0, 0);
            this.listSearch.Name = "listSearch";
            this.listSearch.Size = new System.Drawing.Size(410, 20);
            this.listSearch.TabIndex = 0;
            this.listSearch.Text = " Filter ";
            this.listSearch.TextChanged += new System.EventHandler(this.ListSearchTextChanged);
            this.listSearch.Enter += new System.EventHandler(this.listSearch_Enter);
            this.listSearch.Leave += new System.EventHandler(this.listSearch_Leave);
            // 
            // progressbarPanel
            // 
            this.progressbarPanel.Controls.Add(this.progressBar1);
            this.progressbarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressbarPanel.Location = new System.Drawing.Point(0, 634);
            this.progressbarPanel.Name = "progressbarPanel";
            this.progressbarPanel.Padding = new System.Windows.Forms.Padding(1, 3, 1, 1);
            this.progressbarPanel.Size = new System.Drawing.Size(418, 22);
            this.progressbarPanel.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(1, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(416, 18);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 1;
            // 
            // previewPanel
            // 
            this.previewPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.previewPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previewPanel.BackgroundImage")));
            this.previewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.previewPanel.Controls.Add(this.assetInfoLabel);
            this.previewPanel.Controls.Add(this.FMODpanel);
            this.previewPanel.Controls.Add(this.fontPreviewBox);
            this.previewPanel.Controls.Add(this.textPreviewBox);
            this.previewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPanel.Location = new System.Drawing.Point(0, 0);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(838, 634);
            this.previewPanel.TabIndex = 1;
            // 
            // assetInfoLabel
            // 
            this.assetInfoLabel.AutoSize = true;
            this.assetInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.assetInfoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.assetInfoLabel.Location = new System.Drawing.Point(4, 8);
            this.assetInfoLabel.Name = "assetInfoLabel";
            this.assetInfoLabel.Size = new System.Drawing.Size(0, 13);
            this.assetInfoLabel.TabIndex = 0;
            // 
            // FMODpanel
            // 
            this.FMODpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FMODpanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FMODpanel.Controls.Add(this.FMODinfoLabel);
            this.FMODpanel.Controls.Add(this.FMODtimerLabel);
            this.FMODpanel.Controls.Add(this.FMODstatusLabel);
            this.FMODpanel.Controls.Add(this.FMODprogressBar);
            this.FMODpanel.Controls.Add(this.FMODvolumeBar);
            this.FMODpanel.Controls.Add(this.FMODloopButton);
            this.FMODpanel.Controls.Add(this.FMODstopButton);
            this.FMODpanel.Controls.Add(this.FMODpauseButton);
            this.FMODpanel.Controls.Add(this.FMODplayButton);
            this.FMODpanel.Location = new System.Drawing.Point(220, 209);
            this.FMODpanel.Name = "FMODpanel";
            this.FMODpanel.Size = new System.Drawing.Size(400, 200);
            this.FMODpanel.TabIndex = 2;
            this.FMODpanel.Visible = false;
            // 
            // FMODinfoLabel
            // 
            this.FMODinfoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FMODinfoLabel.Location = new System.Drawing.Point(82, 54);
            this.FMODinfoLabel.Name = "FMODinfoLabel";
            this.FMODinfoLabel.Size = new System.Drawing.Size(176, 13);
            this.FMODinfoLabel.TabIndex = 8;
            // 
            // FMODtimerLabel
            // 
            this.FMODtimerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FMODtimerLabel.Location = new System.Drawing.Point(264, 54);
            this.FMODtimerLabel.Name = "FMODtimerLabel";
            this.FMODtimerLabel.Size = new System.Drawing.Size(99, 13);
            this.FMODtimerLabel.TabIndex = 7;
            this.FMODtimerLabel.Text = "0:00.0 / 0:00.0";
            this.FMODtimerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FMODstatusLabel
            // 
            this.FMODstatusLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FMODstatusLabel.Location = new System.Drawing.Point(26, 54);
            this.FMODstatusLabel.Name = "FMODstatusLabel";
            this.FMODstatusLabel.Size = new System.Drawing.Size(50, 13);
            this.FMODstatusLabel.TabIndex = 6;
            this.FMODstatusLabel.Text = "Stopped";
            // 
            // FMODprogressBar
            // 
            this.FMODprogressBar.AutoSize = false;
            this.FMODprogressBar.Location = new System.Drawing.Point(29, 73);
            this.FMODprogressBar.Maximum = 1000;
            this.FMODprogressBar.Name = "FMODprogressBar";
            this.FMODprogressBar.Size = new System.Drawing.Size(348, 24);
            this.FMODprogressBar.TabIndex = 5;
            this.FMODprogressBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.FMODprogressBar.Scroll += new System.EventHandler(this.FMODprogressBar_Scroll);
            this.FMODprogressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FMODprogressBar_MouseDown);
            this.FMODprogressBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FMODprogressBar_MouseUp);
            // 
            // FMODvolumeBar
            // 
            this.FMODvolumeBar.LargeChange = 2;
            this.FMODvolumeBar.Location = new System.Drawing.Point(273, 103);
            this.FMODvolumeBar.Name = "FMODvolumeBar";
            this.FMODvolumeBar.Size = new System.Drawing.Size(104, 45);
            this.FMODvolumeBar.TabIndex = 4;
            this.FMODvolumeBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.FMODvolumeBar.Value = 8;
            this.FMODvolumeBar.ValueChanged += new System.EventHandler(this.FMODvolumeBar_ValueChanged);
            // 
            // FMODloopButton
            // 
            this.FMODloopButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.FMODloopButton.Location = new System.Drawing.Point(212, 103);
            this.FMODloopButton.Name = "FMODloopButton";
            this.FMODloopButton.Size = new System.Drawing.Size(55, 45);
            this.FMODloopButton.TabIndex = 3;
            this.FMODloopButton.Text = "Loop";
            this.FMODloopButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FMODloopButton.UseVisualStyleBackColor = true;
            this.FMODloopButton.CheckedChanged += new System.EventHandler(this.FMODloopButton_CheckedChanged);
            // 
            // FMODstopButton
            // 
            this.FMODstopButton.Location = new System.Drawing.Point(151, 103);
            this.FMODstopButton.Name = "FMODstopButton";
            this.FMODstopButton.Size = new System.Drawing.Size(55, 45);
            this.FMODstopButton.TabIndex = 2;
            this.FMODstopButton.Text = "Stop";
            this.FMODstopButton.UseVisualStyleBackColor = true;
            this.FMODstopButton.Click += new System.EventHandler(this.FMODstopButton_Click);
            // 
            // FMODpauseButton
            // 
            this.FMODpauseButton.Location = new System.Drawing.Point(90, 103);
            this.FMODpauseButton.Name = "FMODpauseButton";
            this.FMODpauseButton.Size = new System.Drawing.Size(55, 45);
            this.FMODpauseButton.TabIndex = 1;
            this.FMODpauseButton.Text = "Pause";
            this.FMODpauseButton.UseVisualStyleBackColor = true;
            this.FMODpauseButton.Click += new System.EventHandler(this.FMODpauseButton_Click);
            // 
            // FMODplayButton
            // 
            this.FMODplayButton.Location = new System.Drawing.Point(29, 103);
            this.FMODplayButton.Name = "FMODplayButton";
            this.FMODplayButton.Size = new System.Drawing.Size(55, 45);
            this.FMODplayButton.TabIndex = 0;
            this.FMODplayButton.Text = "Play";
            this.FMODplayButton.UseVisualStyleBackColor = true;
            this.FMODplayButton.Click += new System.EventHandler(this.FMODplayButton_Click);
            // 
            // fontPreviewBox
            // 
            this.fontPreviewBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fontPreviewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fontPreviewBox.Location = new System.Drawing.Point(0, 0);
            this.fontPreviewBox.Name = "fontPreviewBox";
            this.fontPreviewBox.ReadOnly = true;
            this.fontPreviewBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.fontPreviewBox.Size = new System.Drawing.Size(838, 634);
            this.fontPreviewBox.TabIndex = 0;
            this.fontPreviewBox.Text = resources.GetString("fontPreviewBox.Text");
            this.fontPreviewBox.Visible = false;
            this.fontPreviewBox.WordWrap = false;
            // 
            // textPreviewBox
            // 
            this.textPreviewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPreviewBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPreviewBox.Location = new System.Drawing.Point(0, 0);
            this.textPreviewBox.Multiline = true;
            this.textPreviewBox.Name = "textPreviewBox";
            this.textPreviewBox.ReadOnly = true;
            this.textPreviewBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textPreviewBox.Size = new System.Drawing.Size(838, 634);
            this.textPreviewBox.TabIndex = 2;
            this.textPreviewBox.Visible = false;
            this.textPreviewBox.WordWrap = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 634);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(838, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(823, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Ready to go";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Unity asset files|level*; mainData; CustomAssetBundle-*; CAB-*; BuildPlayer-*; *." +
    "assets; *.sharedAssets|Unity bundle files|*.unity3d; *.unity3d.lz4; *.assetbundle; *.bundle; *." +
    "bytes";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // openFolderDialog1
            // 
            this.openFolderDialog1.AddExtension = false;
            this.openFolderDialog1.CheckFileExists = false;
            this.openFolderDialog1.FileName = "Select folder";
            this.openFolderDialog1.Filter = "Folders|*.";
            this.openFolderDialog1.RestoreDirectory = true;
            this.openFolderDialog1.Title = "Browse for folder";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "FBX file|*.fbx|Collada|*.dae";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // saveFolderDialog1
            // 
            this.saveFolderDialog1.AddExtension = false;
            this.saveFolderDialog1.FileName = "Select folder or write folder name to create";
            this.saveFolderDialog1.Filter = "Folders|*.";
            this.saveFolderDialog1.RestoreDirectory = true;
            this.saveFolderDialog1.Title = "Browse for folder";
            // 
            // sceneTreeView
            // 
            this.sceneTreeView.CheckBoxes = true;
            this.sceneTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sceneTreeView.HideSelection = false;
            this.sceneTreeView.Location = new System.Drawing.Point(0, 20);
            this.sceneTreeView.Name = "sceneTreeView";
            this.sceneTreeView.Size = new System.Drawing.Size(410, 588);
            this.sceneTreeView.TabIndex = 1;
            this.sceneTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.sceneTreeView_AfterCheck);
            // 
            // UnityStudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(620, 400);
            this.Name = "UnityStudioForm";
            this.Text = "Unity Studio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnityStudioForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.progressbarPanel.ResumeLayout(false);
            this.previewPanel.ResumeLayout(false);
            this.previewPanel.PerformLayout();
            this.FMODpanel.ResumeLayout(false);
            this.FMODpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FMODprogressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FMODvolumeBar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox treeSearch;
        private System.Windows.Forms.TextBox listSearch;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFolderToolStripMenuItem;
        private System.Windows.Forms.ListView assetListView;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllAssetsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSelectedAssetsMenuItem;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel progressbarPanel;
        private System.Windows.Forms.ToolStripMenuItem exportFilteredAssetsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label assetInfoLabel;
        private System.Windows.Forms.TextBox textPreviewBox;
        private System.Windows.Forms.RichTextBox fontPreviewBox;
        private System.Windows.Forms.Panel FMODpanel;
        private System.Windows.Forms.TrackBar FMODvolumeBar;
        private System.Windows.Forms.CheckBox FMODloopButton;
        private System.Windows.Forms.Button FMODstopButton;
        private System.Windows.Forms.Button FMODpauseButton;
        private System.Windows.Forms.Button FMODplayButton;
        private System.Windows.Forms.TrackBar FMODprogressBar;
        private System.Windows.Forms.Label FMODstatusLabel;
        private System.Windows.Forms.Label FMODtimerLabel;
        private System.Windows.Forms.Label FMODinfoLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uniqueNames;
        private System.Windows.Forms.ToolStripMenuItem enablePreview;
        private System.Windows.Forms.ToolStripMenuItem displayInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem extractBundleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAll3DMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSelected3DMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFolderDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFolderDialog1;
        private System.Windows.Forms.ToolStripComboBox assetGroupOptions;
        private System.Windows.Forms.ToolStripMenuItem openAfterExport;
        private System.Windows.Forms.ToolStripMenuItem showExpOpt;
        private GOHierarchy sceneTreeView;
        private System.Windows.Forms.ToolTip treeTip;
    }
}
