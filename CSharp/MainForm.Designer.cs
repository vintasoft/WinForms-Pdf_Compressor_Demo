namespace PdfCompressorDemo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspectSpaceUsageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useMultithreadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceFileSizeProgressBar = new System.Windows.Forms.ProgressBar();
            this.compressedFileSizeProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceFileSizeLabel = new System.Windows.Forms.Label();
            this.compressedFileSizeLabel = new System.Windows.Forms.Label();
            this.compressionProgressBar = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.taskGroupsTabControl = new System.Windows.Forms.TabControl();
            this.imagesTabPage = new System.Windows.Forms.TabPage();
            this.imagesPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.detectBitonalImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maxInaccuracyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.detectIndexedImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.detectGrayscaleImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.detectBlackWhiteImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.colorImagesGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colorImagesMinResolutionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.colorImagesDownscaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorImagesCompressionSettingsButton = new System.Windows.Forms.Button();
            this.compressColorImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.colorCompressionComboBox = new System.Windows.Forms.ComboBox();
            this.downscaleColorImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.blackWhiteImagesMinResolutionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.blackWhiteImagesDownscaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blackWhiteImagesCompressionSettingsButton = new System.Windows.Forms.Button();
            this.compressBlackWhiteImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.blackWhiteCompressionComboBox = new System.Windows.Forms.ComboBox();
            this.downscaleBlackWhiteImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grayImagesMinResolutionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.grayImagesDownscaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.grayImagesCompressionSettingsButton = new System.Windows.Forms.Button();
            this.compressGrayImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.grayCompressionComboBox = new System.Windows.Forms.ComboBox();
            this.downscaleGrayImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.resourcesTabPage = new System.Windows.Forms.TabPage();
            this.resourcesPanel = new System.Windows.Forms.Panel();
            this.useFlateInstreadLzwCheckBox = new System.Windows.Forms.CheckBox();
            this.recompressFlateUsingBestCompressionCheckBox = new System.Windows.Forms.CheckBox();
            this.useFlateInstreadNoneCheckBox = new System.Windows.Forms.CheckBox();
            this.cleanUpTabPage = new System.Windows.Forms.TabPage();
            this.cleanUpPanel = new System.Windows.Forms.Panel();
            this.flattenAnnotationsCheckBox = new System.Windows.Forms.CheckBox();
            this.optimizeFontSubsetsCheckBox = new System.Windows.Forms.CheckBox();
            this.removeStuctureTreeCheckBox = new System.Windows.Forms.CheckBox();
            this.removeInteractiveFormCheckBox = new System.Windows.Forms.CheckBox();
            this.cleanupContentStreamsCheckBox = new System.Windows.Forms.CheckBox();
            this.removeResourceDuplicatesCheckBox = new System.Windows.Forms.CheckBox();
            this.removeUnusedResourcesCheckBox = new System.Windows.Forms.CheckBox();
            this.subsetFontsCheckBox = new System.Windows.Forms.CheckBox();
            this.removeUnusedPagesCheckBox = new System.Windows.Forms.CheckBox();
            this.cleanupNameDictionaryCheckBox = new System.Windows.Forms.CheckBox();
            this.removeMetadataCheckBox = new System.Windows.Forms.CheckBox();
            this.removeInvalidLinksCheckBox = new System.Windows.Forms.CheckBox();
            this.removeAnnotationsCheckBox = new System.Windows.Forms.CheckBox();
            this.removeBookmarksCheckBox = new System.Windows.Forms.CheckBox();
            this.removeInvalidBookmarksCheckBox = new System.Windows.Forms.CheckBox();
            this.removeEmbeddedThumbnailsCheckBox = new System.Windows.Forms.CheckBox();
            this.removeFileAttachementsCheckBox = new System.Windows.Forms.CheckBox();
            this.removeDocumentInformationCheckBox = new System.Windows.Forms.CheckBox();
            this.outputDocumentFormatTabPage = new System.Windows.Forms.TabPage();
            this.documentOutputFormatPanel = new System.Windows.Forms.Panel();
            this.sourceFormatLabel = new System.Windows.Forms.Label();
            this.useCompressedXrefCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.useTextDocumentFormatCheckBox = new System.Windows.Forms.CheckBox();
            this.compressedDocumentFormatComboBox = new System.Windows.Forms.ComboBox();
            this.taskGroupsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.executeCompressionButton = new System.Windows.Forms.Button();
            this.pdfDocumentCompressionBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.taskGroupsTabControl.SuspendLayout();
            this.imagesTabPage.SuspendLayout();
            this.imagesPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxInaccuracyNumericUpDown)).BeginInit();
            this.colorImagesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorImagesMinResolutionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorImagesDownscaleNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blackWhiteImagesMinResolutionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackWhiteImagesDownscaleNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grayImagesMinResolutionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayImagesDownscaleNumericUpDown)).BeginInit();
            this.resourcesTabPage.SuspendLayout();
            this.resourcesPanel.SuspendLayout();
            this.cleanUpTabPage.SuspendLayout();
            this.cleanUpPanel.SuspendLayout();
            this.outputDocumentFormatTabPage.SuspendLayout();
            this.documentOutputFormatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToToolStripMenuItem
            // 
            this.saveToToolStripMenuItem.Name = "saveToToolStripMenuItem";
            this.saveToToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveToToolStripMenuItem.Text = "Save To...";
            this.saveToToolStripMenuItem.Click += new System.EventHandler(this.saveToToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inspectSpaceUsageToolStripMenuItem,
            this.useMultithreadingToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // inspectSpaceUsageToolStripMenuItem
            // 
            this.inspectSpaceUsageToolStripMenuItem.Name = "inspectSpaceUsageToolStripMenuItem";
            this.inspectSpaceUsageToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.inspectSpaceUsageToolStripMenuItem.Text = "Inspect space usage";
            this.inspectSpaceUsageToolStripMenuItem.Click += new System.EventHandler(this.inspectSpaceUsageToolStripMenuItem_Click);
            // 
            // useMultithreadingToolStripMenuItem
            // 
            this.useMultithreadingToolStripMenuItem.Checked = true;
            this.useMultithreadingToolStripMenuItem.CheckOnClick = true;
            this.useMultithreadingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useMultithreadingToolStripMenuItem.Name = "useMultithreadingToolStripMenuItem";
            this.useMultithreadingToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.useMultithreadingToolStripMenuItem.Text = "Use Multithreading";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // sourceFileSizeProgressBar
            // 
            this.sourceFileSizeProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceFileSizeProgressBar.Location = new System.Drawing.Point(160, 38);
            this.sourceFileSizeProgressBar.Name = "sourceFileSizeProgressBar";
            this.sourceFileSizeProgressBar.Size = new System.Drawing.Size(554, 23);
            this.sourceFileSizeProgressBar.TabIndex = 1;
            // 
            // compressedFileSizeProgressBar
            // 
            this.compressedFileSizeProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compressedFileSizeProgressBar.Location = new System.Drawing.Point(160, 67);
            this.compressedFileSizeProgressBar.Name = "compressedFileSizeProgressBar";
            this.compressedFileSizeProgressBar.Size = new System.Drawing.Size(554, 23);
            this.compressedFileSizeProgressBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Source File Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Compressed File Size";
            // 
            // sourceFileSizeLabel
            // 
            this.sourceFileSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceFileSizeLabel.AutoSize = true;
            this.sourceFileSizeLabel.Location = new System.Drawing.Point(719, 45);
            this.sourceFileSizeLabel.Name = "sourceFileSizeLabel";
            this.sourceFileSizeLabel.Size = new System.Drawing.Size(38, 13);
            this.sourceFileSizeLabel.TabIndex = 5;
            this.sourceFileSizeLabel.Text = "{0} KB";
            // 
            // compressedFileSizeLabel
            // 
            this.compressedFileSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.compressedFileSizeLabel.AutoSize = true;
            this.compressedFileSizeLabel.Location = new System.Drawing.Point(719, 72);
            this.compressedFileSizeLabel.Name = "compressedFileSizeLabel";
            this.compressedFileSizeLabel.Size = new System.Drawing.Size(38, 13);
            this.compressedFileSizeLabel.TabIndex = 6;
            this.compressedFileSizeLabel.Text = "{0} KB";
            // 
            // compressionProgressBar
            // 
            this.compressionProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compressionProgressBar.Location = new System.Drawing.Point(160, 422);
            this.compressionProgressBar.Name = "compressionProgressBar";
            this.compressionProgressBar.Size = new System.Drawing.Size(667, 23);
            this.compressionProgressBar.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "PDF Files|*.pdf";
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.logTextBox.Location = new System.Drawing.Point(8, 451);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.Size = new System.Drawing.Size(819, 221);
            this.logTextBox.TabIndex = 10;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PDF Files|*.pdf";
            // 
            // taskGroupsTabControl
            // 
            this.taskGroupsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskGroupsTabControl.Controls.Add(this.imagesTabPage);
            this.taskGroupsTabControl.Controls.Add(this.resourcesTabPage);
            this.taskGroupsTabControl.Controls.Add(this.cleanUpTabPage);
            this.taskGroupsTabControl.Controls.Add(this.outputDocumentFormatTabPage);
            this.taskGroupsTabControl.Location = new System.Drawing.Point(160, 96);
            this.taskGroupsTabControl.Name = "taskGroupsTabControl";
            this.taskGroupsTabControl.SelectedIndex = 0;
            this.taskGroupsTabControl.Size = new System.Drawing.Size(667, 320);
            this.taskGroupsTabControl.TabIndex = 12;
            // 
            // imagesTabPage
            // 
            this.imagesTabPage.Controls.Add(this.imagesPanel);
            this.imagesTabPage.Location = new System.Drawing.Point(4, 22);
            this.imagesTabPage.Name = "imagesTabPage";
            this.imagesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.imagesTabPage.Size = new System.Drawing.Size(659, 294);
            this.imagesTabPage.TabIndex = 0;
            this.imagesTabPage.Text = "Images";
            this.imagesTabPage.UseVisualStyleBackColor = true;
            // 
            // imagesPanel
            // 
            this.imagesPanel.Controls.Add(this.groupBox3);
            this.imagesPanel.Controls.Add(this.colorImagesGroupBox);
            this.imagesPanel.Controls.Add(this.groupBox2);
            this.imagesPanel.Controls.Add(this.groupBox1);
            this.imagesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesPanel.Location = new System.Drawing.Point(3, 3);
            this.imagesPanel.Name = "imagesPanel";
            this.imagesPanel.Size = new System.Drawing.Size(653, 288);
            this.imagesPanel.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.detectBitonalImagesCheckBox);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.detectIndexedImagesCheckBox);
            this.groupBox3.Controls.Add(this.detectGrayscaleImagesCheckBox);
            this.groupBox3.Controls.Add(this.detectBlackWhiteImagesCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(3, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(647, 71);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image Real Color Depth Detection (Reduce Image Color Depth)";
            // 
            // detectBitonalImagesCheckBox
            // 
            this.detectBitonalImagesCheckBox.AutoSize = true;
            this.detectBitonalImagesCheckBox.Checked = true;
            this.detectBitonalImagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detectBitonalImagesCheckBox.Location = new System.Drawing.Point(197, 21);
            this.detectBitonalImagesCheckBox.Name = "detectBitonalImagesCheckBox";
            this.detectBitonalImagesCheckBox.Size = new System.Drawing.Size(183, 17);
            this.detectBitonalImagesCheckBox.TabIndex = 11;
            this.detectBitonalImagesCheckBox.Text = "Detect Indexed1 (Bitonal) Images";
            this.detectBitonalImagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.maxInaccuracyNumericUpDown);
            this.groupBox4.Location = new System.Drawing.Point(416, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(223, 53);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detection Maximal Inaccuracy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "(distance in RGB space)";
            // 
            // maxInaccuracyNumericUpDown
            // 
            this.maxInaccuracyNumericUpDown.Location = new System.Drawing.Point(9, 21);
            this.maxInaccuracyNumericUpDown.Maximum = new decimal(new int[] {
            440,
            0,
            0,
            0});
            this.maxInaccuracyNumericUpDown.Name = "maxInaccuracyNumericUpDown";
            this.maxInaccuracyNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.maxInaccuracyNumericUpDown.TabIndex = 8;
            this.maxInaccuracyNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // detectIndexedImagesCheckBox
            // 
            this.detectIndexedImagesCheckBox.AutoSize = true;
            this.detectIndexedImagesCheckBox.Location = new System.Drawing.Point(197, 42);
            this.detectIndexedImagesCheckBox.Name = "detectIndexedImagesCheckBox";
            this.detectIndexedImagesCheckBox.Size = new System.Drawing.Size(200, 17);
            this.detectIndexedImagesCheckBox.TabIndex = 7;
            this.detectIndexedImagesCheckBox.Text = "Detect Indexed8 (256 colors) Images";
            this.detectIndexedImagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // detectGrayscaleImagesCheckBox
            // 
            this.detectGrayscaleImagesCheckBox.AutoSize = true;
            this.detectGrayscaleImagesCheckBox.Checked = true;
            this.detectGrayscaleImagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detectGrayscaleImagesCheckBox.Location = new System.Drawing.Point(10, 42);
            this.detectGrayscaleImagesCheckBox.Name = "detectGrayscaleImagesCheckBox";
            this.detectGrayscaleImagesCheckBox.Size = new System.Drawing.Size(145, 17);
            this.detectGrayscaleImagesCheckBox.TabIndex = 6;
            this.detectGrayscaleImagesCheckBox.Text = "Detect Grayscale Images";
            this.detectGrayscaleImagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // detectBlackWhiteImagesCheckBox
            // 
            this.detectBlackWhiteImagesCheckBox.AutoSize = true;
            this.detectBlackWhiteImagesCheckBox.Checked = true;
            this.detectBlackWhiteImagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detectBlackWhiteImagesCheckBox.Location = new System.Drawing.Point(10, 21);
            this.detectBlackWhiteImagesCheckBox.Name = "detectBlackWhiteImagesCheckBox";
            this.detectBlackWhiteImagesCheckBox.Size = new System.Drawing.Size(158, 17);
            this.detectBlackWhiteImagesCheckBox.TabIndex = 5;
            this.detectBlackWhiteImagesCheckBox.Text = "Detect Black/White Images";
            this.detectBlackWhiteImagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // colorImagesGroupBox
            // 
            this.colorImagesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorImagesGroupBox.Controls.Add(this.label4);
            this.colorImagesGroupBox.Controls.Add(this.colorImagesMinResolutionNumericUpDown);
            this.colorImagesGroupBox.Controls.Add(this.label3);
            this.colorImagesGroupBox.Controls.Add(this.colorImagesDownscaleNumericUpDown);
            this.colorImagesGroupBox.Controls.Add(this.colorImagesCompressionSettingsButton);
            this.colorImagesGroupBox.Controls.Add(this.compressColorImagesCheckBox);
            this.colorImagesGroupBox.Controls.Add(this.colorCompressionComboBox);
            this.colorImagesGroupBox.Controls.Add(this.downscaleColorImagesCheckBox);
            this.colorImagesGroupBox.Location = new System.Drawing.Point(3, 81);
            this.colorImagesGroupBox.Name = "colorImagesGroupBox";
            this.colorImagesGroupBox.Size = new System.Drawing.Size(647, 64);
            this.colorImagesGroupBox.TabIndex = 0;
            this.colorImagesGroupBox.TabStop = false;
            this.colorImagesGroupBox.Text = "Color Images";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "DPI";
            // 
            // colorImagesMinResolutionNumericUpDown
            // 
            this.colorImagesMinResolutionNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colorImagesMinResolutionNumericUpDown.Location = new System.Drawing.Point(308, 38);
            this.colorImagesMinResolutionNumericUpDown.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.colorImagesMinResolutionNumericUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.colorImagesMinResolutionNumericUpDown.Name = "colorImagesMinResolutionNumericUpDown";
            this.colorImagesMinResolutionNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.colorImagesMinResolutionNumericUpDown.TabIndex = 8;
            this.colorImagesMinResolutionNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DPI for images above";
            // 
            // colorImagesDownscaleNumericUpDown
            // 
            this.colorImagesDownscaleNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colorImagesDownscaleNumericUpDown.Location = new System.Drawing.Point(106, 38);
            this.colorImagesDownscaleNumericUpDown.Maximum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.colorImagesDownscaleNumericUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.colorImagesDownscaleNumericUpDown.Name = "colorImagesDownscaleNumericUpDown";
            this.colorImagesDownscaleNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.colorImagesDownscaleNumericUpDown.TabIndex = 6;
            this.colorImagesDownscaleNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.colorImagesDownscaleNumericUpDown.ValueChanged += new System.EventHandler(this.colorImagesDownscaleNumericUpDown_ValueChanged);
            // 
            // colorImagesCompressionSettingsButton
            // 
            this.colorImagesCompressionSettingsButton.Location = new System.Drawing.Point(296, 11);
            this.colorImagesCompressionSettingsButton.Name = "colorImagesCompressionSettingsButton";
            this.colorImagesCompressionSettingsButton.Size = new System.Drawing.Size(77, 23);
            this.colorImagesCompressionSettingsButton.TabIndex = 5;
            this.colorImagesCompressionSettingsButton.Text = "Settings...";
            this.colorImagesCompressionSettingsButton.UseVisualStyleBackColor = true;
            this.colorImagesCompressionSettingsButton.Click += new System.EventHandler(this.colorImagesCompressionSettingsButton_Click);
            // 
            // compressColorImagesCheckBox
            // 
            this.compressColorImagesCheckBox.AutoSize = true;
            this.compressColorImagesCheckBox.Checked = true;
            this.compressColorImagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compressColorImagesCheckBox.Location = new System.Drawing.Point(10, 15);
            this.compressColorImagesCheckBox.Name = "compressColorImagesCheckBox";
            this.compressColorImagesCheckBox.Size = new System.Drawing.Size(86, 17);
            this.compressColorImagesCheckBox.TabIndex = 4;
            this.compressColorImagesCheckBox.Text = "Compression";
            this.compressColorImagesCheckBox.UseVisualStyleBackColor = true;
            this.compressColorImagesCheckBox.CheckedChanged += new System.EventHandler(this.UpdateUI_Handler);
            // 
            // colorCompressionComboBox
            // 
            this.colorCompressionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorCompressionComboBox.FormattingEnabled = true;
            this.colorCompressionComboBox.Location = new System.Drawing.Point(106, 13);
            this.colorCompressionComboBox.Name = "colorCompressionComboBox";
            this.colorCompressionComboBox.Size = new System.Drawing.Size(184, 21);
            this.colorCompressionComboBox.TabIndex = 2;
            this.colorCompressionComboBox.SelectedIndexChanged += new System.EventHandler(this.UpdateUI_Handler);
            // 
            // downscaleColorImagesCheckBox
            // 
            this.downscaleColorImagesCheckBox.AutoSize = true;
            this.downscaleColorImagesCheckBox.Checked = true;
            this.downscaleColorImagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.downscaleColorImagesCheckBox.Location = new System.Drawing.Point(10, 40);
            this.downscaleColorImagesCheckBox.Name = "downscaleColorImagesCheckBox";
            this.downscaleColorImagesCheckBox.Size = new System.Drawing.Size(79, 17);
            this.downscaleColorImagesCheckBox.TabIndex = 0;
            this.downscaleColorImagesCheckBox.Text = "Downscale";
            this.downscaleColorImagesCheckBox.UseVisualStyleBackColor = true;
            this.downscaleColorImagesCheckBox.CheckedChanged += new System.EventHandler(this.UpdateUI_Handler);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.blackWhiteImagesMinResolutionNumericUpDown);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.blackWhiteImagesDownscaleNumericUpDown);
            this.groupBox2.Controls.Add(this.blackWhiteImagesCompressionSettingsButton);
            this.groupBox2.Controls.Add(this.compressBlackWhiteImagesCheckBox);
            this.groupBox2.Controls.Add(this.blackWhiteCompressionComboBox);
            this.groupBox2.Controls.Add(this.downscaleBlackWhiteImagesCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 64);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Black&&White / Bitonal Images";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "DPI";
            // 
            // blackWhiteImagesMinResolutionNumericUpDown
            // 
            this.blackWhiteImagesMinResolutionNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.blackWhiteImagesMinResolutionNumericUpDown.Location = new System.Drawing.Point(308, 38);
            this.blackWhiteImagesMinResolutionNumericUpDown.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.blackWhiteImagesMinResolutionNumericUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.blackWhiteImagesMinResolutionNumericUpDown.Name = "blackWhiteImagesMinResolutionNumericUpDown";
            this.blackWhiteImagesMinResolutionNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.blackWhiteImagesMinResolutionNumericUpDown.TabIndex = 8;
            this.blackWhiteImagesMinResolutionNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "DPI for images above";
            // 
            // blackWhiteImagesDownscaleNumericUpDown
            // 
            this.blackWhiteImagesDownscaleNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.blackWhiteImagesDownscaleNumericUpDown.Location = new System.Drawing.Point(106, 38);
            this.blackWhiteImagesDownscaleNumericUpDown.Maximum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.blackWhiteImagesDownscaleNumericUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.blackWhiteImagesDownscaleNumericUpDown.Name = "blackWhiteImagesDownscaleNumericUpDown";
            this.blackWhiteImagesDownscaleNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.blackWhiteImagesDownscaleNumericUpDown.TabIndex = 6;
            this.blackWhiteImagesDownscaleNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.blackWhiteImagesDownscaleNumericUpDown.ValueChanged += new System.EventHandler(this.bitonalImagesDownscaleNumericUpDown_ValueChanged);
            // 
            // blackWhiteImagesCompressionSettingsButton
            // 
            this.blackWhiteImagesCompressionSettingsButton.Location = new System.Drawing.Point(296, 12);
            this.blackWhiteImagesCompressionSettingsButton.Name = "blackWhiteImagesCompressionSettingsButton";
            this.blackWhiteImagesCompressionSettingsButton.Size = new System.Drawing.Size(77, 23);
            this.blackWhiteImagesCompressionSettingsButton.TabIndex = 5;
            this.blackWhiteImagesCompressionSettingsButton.Text = "Settings...";
            this.blackWhiteImagesCompressionSettingsButton.UseVisualStyleBackColor = true;
            this.blackWhiteImagesCompressionSettingsButton.Click += new System.EventHandler(this.blackWhiteImagesCompressionSettingsButton_Click);
            // 
            // compressBlackWhiteImagesCheckBox
            // 
            this.compressBlackWhiteImagesCheckBox.AutoSize = true;
            this.compressBlackWhiteImagesCheckBox.Checked = true;
            this.compressBlackWhiteImagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compressBlackWhiteImagesCheckBox.Location = new System.Drawing.Point(10, 16);
            this.compressBlackWhiteImagesCheckBox.Name = "compressBlackWhiteImagesCheckBox";
            this.compressBlackWhiteImagesCheckBox.Size = new System.Drawing.Size(86, 17);
            this.compressBlackWhiteImagesCheckBox.TabIndex = 4;
            this.compressBlackWhiteImagesCheckBox.Text = "Compression";
            this.compressBlackWhiteImagesCheckBox.UseVisualStyleBackColor = true;
            this.compressBlackWhiteImagesCheckBox.CheckedChanged += new System.EventHandler(this.UpdateUI_Handler);
            // 
            // blackWhiteCompressionComboBox
            // 
            this.blackWhiteCompressionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blackWhiteCompressionComboBox.FormattingEnabled = true;
            this.blackWhiteCompressionComboBox.Location = new System.Drawing.Point(106, 14);
            this.blackWhiteCompressionComboBox.Name = "blackWhiteCompressionComboBox";
            this.blackWhiteCompressionComboBox.Size = new System.Drawing.Size(184, 21);
            this.blackWhiteCompressionComboBox.TabIndex = 3;
            this.blackWhiteCompressionComboBox.SelectedIndexChanged += new System.EventHandler(this.UpdateUI_Handler);
            // 
            // downscaleBlackWhiteImagesCheckBox
            // 
            this.downscaleBlackWhiteImagesCheckBox.AutoSize = true;
            this.downscaleBlackWhiteImagesCheckBox.Checked = true;
            this.downscaleBlackWhiteImagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.downscaleBlackWhiteImagesCheckBox.Location = new System.Drawing.Point(10, 40);
            this.downscaleBlackWhiteImagesCheckBox.Name = "downscaleBlackWhiteImagesCheckBox";
            this.downscaleBlackWhiteImagesCheckBox.Size = new System.Drawing.Size(79, 17);
            this.downscaleBlackWhiteImagesCheckBox.TabIndex = 0;
            this.downscaleBlackWhiteImagesCheckBox.Text = "Downscale";
            this.downscaleBlackWhiteImagesCheckBox.UseVisualStyleBackColor = true;
            this.downscaleBlackWhiteImagesCheckBox.CheckedChanged += new System.EventHandler(this.UpdateUI_Handler);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.grayImagesMinResolutionNumericUpDown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.grayImagesDownscaleNumericUpDown);
            this.groupBox1.Controls.Add(this.grayImagesCompressionSettingsButton);
            this.groupBox1.Controls.Add(this.compressGrayImagesCheckBox);
            this.groupBox1.Controls.Add(this.grayCompressionComboBox);
            this.groupBox1.Controls.Add(this.downscaleGrayImagesCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grayscale Images";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "DPI";
            // 
            // grayImagesMinResolutionNumericUpDown
            // 
            this.grayImagesMinResolutionNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.grayImagesMinResolutionNumericUpDown.Location = new System.Drawing.Point(308, 38);
            this.grayImagesMinResolutionNumericUpDown.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.grayImagesMinResolutionNumericUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.grayImagesMinResolutionNumericUpDown.Name = "grayImagesMinResolutionNumericUpDown";
            this.grayImagesMinResolutionNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.grayImagesMinResolutionNumericUpDown.TabIndex = 8;
            this.grayImagesMinResolutionNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "DPI for images above";
            // 
            // grayImagesDownscaleNumericUpDown
            // 
            this.grayImagesDownscaleNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.grayImagesDownscaleNumericUpDown.Location = new System.Drawing.Point(106, 38);
            this.grayImagesDownscaleNumericUpDown.Maximum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.grayImagesDownscaleNumericUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.grayImagesDownscaleNumericUpDown.Name = "grayImagesDownscaleNumericUpDown";
            this.grayImagesDownscaleNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.grayImagesDownscaleNumericUpDown.TabIndex = 6;
            this.grayImagesDownscaleNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.grayImagesDownscaleNumericUpDown.ValueChanged += new System.EventHandler(this.grayImagesDownscaleNumericUpDown_ValueChanged);
            // 
            // grayImagesCompressionSettingsButton
            // 
            this.grayImagesCompressionSettingsButton.Location = new System.Drawing.Point(296, 12);
            this.grayImagesCompressionSettingsButton.Name = "grayImagesCompressionSettingsButton";
            this.grayImagesCompressionSettingsButton.Size = new System.Drawing.Size(77, 23);
            this.grayImagesCompressionSettingsButton.TabIndex = 5;
            this.grayImagesCompressionSettingsButton.Text = "Settings...";
            this.grayImagesCompressionSettingsButton.UseVisualStyleBackColor = true;
            this.grayImagesCompressionSettingsButton.Click += new System.EventHandler(this.grayImagesCompressionSettingsButton_Click);
            // 
            // compressGrayImagesCheckBox
            // 
            this.compressGrayImagesCheckBox.AutoSize = true;
            this.compressGrayImagesCheckBox.Checked = true;
            this.compressGrayImagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compressGrayImagesCheckBox.Location = new System.Drawing.Point(10, 16);
            this.compressGrayImagesCheckBox.Name = "compressGrayImagesCheckBox";
            this.compressGrayImagesCheckBox.Size = new System.Drawing.Size(86, 17);
            this.compressGrayImagesCheckBox.TabIndex = 4;
            this.compressGrayImagesCheckBox.Text = "Compression";
            this.compressGrayImagesCheckBox.UseVisualStyleBackColor = true;
            this.compressGrayImagesCheckBox.CheckedChanged += new System.EventHandler(this.UpdateUI_Handler);
            // 
            // grayCompressionComboBox
            // 
            this.grayCompressionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grayCompressionComboBox.FormattingEnabled = true;
            this.grayCompressionComboBox.Location = new System.Drawing.Point(106, 14);
            this.grayCompressionComboBox.Name = "grayCompressionComboBox";
            this.grayCompressionComboBox.Size = new System.Drawing.Size(184, 21);
            this.grayCompressionComboBox.TabIndex = 2;
            this.grayCompressionComboBox.SelectedIndexChanged += new System.EventHandler(this.UpdateUI_Handler);
            // 
            // downscaleGrayImagesCheckBox
            // 
            this.downscaleGrayImagesCheckBox.AutoSize = true;
            this.downscaleGrayImagesCheckBox.Checked = true;
            this.downscaleGrayImagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.downscaleGrayImagesCheckBox.Location = new System.Drawing.Point(10, 40);
            this.downscaleGrayImagesCheckBox.Name = "downscaleGrayImagesCheckBox";
            this.downscaleGrayImagesCheckBox.Size = new System.Drawing.Size(79, 17);
            this.downscaleGrayImagesCheckBox.TabIndex = 0;
            this.downscaleGrayImagesCheckBox.Text = "Downscale";
            this.downscaleGrayImagesCheckBox.UseVisualStyleBackColor = true;
            this.downscaleGrayImagesCheckBox.CheckedChanged += new System.EventHandler(this.UpdateUI_Handler);
            // 
            // resourcesTabPage
            // 
            this.resourcesTabPage.Controls.Add(this.resourcesPanel);
            this.resourcesTabPage.Location = new System.Drawing.Point(4, 22);
            this.resourcesTabPage.Name = "resourcesTabPage";
            this.resourcesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.resourcesTabPage.Size = new System.Drawing.Size(659, 294);
            this.resourcesTabPage.TabIndex = 1;
            this.resourcesTabPage.Text = "Resources";
            this.resourcesTabPage.UseVisualStyleBackColor = true;
            // 
            // resourcesPanel
            // 
            this.resourcesPanel.Controls.Add(this.useFlateInstreadLzwCheckBox);
            this.resourcesPanel.Controls.Add(this.recompressFlateUsingBestCompressionCheckBox);
            this.resourcesPanel.Controls.Add(this.useFlateInstreadNoneCheckBox);
            this.resourcesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesPanel.Location = new System.Drawing.Point(3, 3);
            this.resourcesPanel.Name = "resourcesPanel";
            this.resourcesPanel.Size = new System.Drawing.Size(653, 288);
            this.resourcesPanel.TabIndex = 5;
            // 
            // useFlateInstreadLzwCheckBox
            // 
            this.useFlateInstreadLzwCheckBox.AutoSize = true;
            this.useFlateInstreadLzwCheckBox.Checked = true;
            this.useFlateInstreadLzwCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useFlateInstreadLzwCheckBox.Location = new System.Drawing.Point(7, 7);
            this.useFlateInstreadLzwCheckBox.Name = "useFlateInstreadLzwCheckBox";
            this.useFlateInstreadLzwCheckBox.Size = new System.Drawing.Size(294, 17);
            this.useFlateInstreadLzwCheckBox.TabIndex = 2;
            this.useFlateInstreadLzwCheckBox.Text = "Use Flate(ZIP) compression instead of LZW compression";
            this.useFlateInstreadLzwCheckBox.UseVisualStyleBackColor = true;
            // 
            // recompressFlateUsingBestCompressionCheckBox
            // 
            this.recompressFlateUsingBestCompressionCheckBox.AutoSize = true;
            this.recompressFlateUsingBestCompressionCheckBox.Location = new System.Drawing.Point(7, 53);
            this.recompressFlateUsingBestCompressionCheckBox.Name = "recompressFlateUsingBestCompressionCheckBox";
            this.recompressFlateUsingBestCompressionCheckBox.Size = new System.Drawing.Size(436, 17);
            this.recompressFlateUsingBestCompressionCheckBox.TabIndex = 4;
            this.recompressFlateUsingBestCompressionCheckBox.Text = "Recompress all resources that use Flate(ZIP) compression using max compression le" +
    "vel";
            this.recompressFlateUsingBestCompressionCheckBox.UseVisualStyleBackColor = true;
            // 
            // useFlateInstreadNoneCheckBox
            // 
            this.useFlateInstreadNoneCheckBox.AutoSize = true;
            this.useFlateInstreadNoneCheckBox.Checked = true;
            this.useFlateInstreadNoneCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useFlateInstreadNoneCheckBox.Location = new System.Drawing.Point(7, 30);
            this.useFlateInstreadNoneCheckBox.Name = "useFlateInstreadNoneCheckBox";
            this.useFlateInstreadNoneCheckBox.Size = new System.Drawing.Size(292, 17);
            this.useFlateInstreadNoneCheckBox.TabIndex = 3;
            this.useFlateInstreadNoneCheckBox.Text = "Use Flate(ZIP) compression for uncompressed resources";
            this.useFlateInstreadNoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // cleanUpTabPage
            // 
            this.cleanUpTabPage.Controls.Add(this.cleanUpPanel);
            this.cleanUpTabPage.Location = new System.Drawing.Point(4, 22);
            this.cleanUpTabPage.Name = "cleanUpTabPage";
            this.cleanUpTabPage.Size = new System.Drawing.Size(659, 294);
            this.cleanUpTabPage.TabIndex = 2;
            this.cleanUpTabPage.Text = "Clean Up / Discard";
            this.cleanUpTabPage.UseVisualStyleBackColor = true;
            // 
            // cleanUpPanel
            // 
            this.cleanUpPanel.Controls.Add(this.flattenAnnotationsCheckBox);
            this.cleanUpPanel.Controls.Add(this.optimizeFontSubsetsCheckBox);
            this.cleanUpPanel.Controls.Add(this.removeStuctureTreeCheckBox);
            this.cleanUpPanel.Controls.Add(this.removeInteractiveFormCheckBox);
            this.cleanUpPanel.Controls.Add(this.cleanupContentStreamsCheckBox);
            this.cleanUpPanel.Controls.Add(this.removeResourceDuplicatesCheckBox);
            this.cleanUpPanel.Controls.Add(this.removeUnusedResourcesCheckBox);
            this.cleanUpPanel.Controls.Add(this.subsetFontsCheckBox);
            this.cleanUpPanel.Controls.Add(this.removeUnusedPagesCheckBox);
            this.cleanUpPanel.Controls.Add(this.cleanupNameDictionaryCheckBox);
            this.cleanUpPanel.Controls.Add(this.removeMetadataCheckBox);
            this.cleanUpPanel.Controls.Add(this.removeInvalidLinksCheckBox);
            this.cleanUpPanel.Controls.Add(this.removeAnnotationsCheckBox);
            this.cleanUpPanel.Controls.Add(this.removeBookmarksCheckBox);
            this.cleanUpPanel.Controls.Add(this.removeInvalidBookmarksCheckBox);
            this.cleanUpPanel.Controls.Add(this.removeEmbeddedThumbnailsCheckBox);
            this.cleanUpPanel.Controls.Add(this.removeFileAttachementsCheckBox);
            this.cleanUpPanel.Controls.Add(this.removeDocumentInformationCheckBox);
            this.cleanUpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cleanUpPanel.Location = new System.Drawing.Point(0, 0);
            this.cleanUpPanel.Name = "cleanUpPanel";
            this.cleanUpPanel.Size = new System.Drawing.Size(659, 294);
            this.cleanUpPanel.TabIndex = 15;
            // 
            // flattenAnnotationsCheckBox
            // 
            this.flattenAnnotationsCheckBox.AutoSize = true;
            this.flattenAnnotationsCheckBox.Location = new System.Drawing.Point(204, 10);
            this.flattenAnnotationsCheckBox.Name = "flattenAnnotationsCheckBox";
            this.flattenAnnotationsCheckBox.Size = new System.Drawing.Size(116, 17);
            this.flattenAnnotationsCheckBox.TabIndex = 27;
            this.flattenAnnotationsCheckBox.Text = "Flatten annotations";
            this.flattenAnnotationsCheckBox.UseVisualStyleBackColor = true;
            // 
            // optimizeFontSubsetsCheckBox
            // 
            this.optimizeFontSubsetsCheckBox.AutoSize = true;
            this.optimizeFontSubsetsCheckBox.Location = new System.Drawing.Point(3, 10);
            this.optimizeFontSubsetsCheckBox.Name = "optimizeFontSubsetsCheckBox";
            this.optimizeFontSubsetsCheckBox.Size = new System.Drawing.Size(126, 17);
            this.optimizeFontSubsetsCheckBox.TabIndex = 26;
            this.optimizeFontSubsetsCheckBox.Text = "Optimize font subsets";
            this.optimizeFontSubsetsCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeStuctureTreeCheckBox
            // 
            this.removeStuctureTreeCheckBox.AutoSize = true;
            this.removeStuctureTreeCheckBox.Location = new System.Drawing.Point(204, 194);
            this.removeStuctureTreeCheckBox.Name = "removeStuctureTreeCheckBox";
            this.removeStuctureTreeCheckBox.Size = new System.Drawing.Size(131, 17);
            this.removeStuctureTreeCheckBox.TabIndex = 25;
            this.removeStuctureTreeCheckBox.Text = "Remove structure tree";
            this.removeStuctureTreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeInteractiveFormCheckBox
            // 
            this.removeInteractiveFormCheckBox.AutoSize = true;
            this.removeInteractiveFormCheckBox.Location = new System.Drawing.Point(204, 171);
            this.removeInteractiveFormCheckBox.Name = "removeInteractiveFormCheckBox";
            this.removeInteractiveFormCheckBox.Size = new System.Drawing.Size(141, 17);
            this.removeInteractiveFormCheckBox.TabIndex = 24;
            this.removeInteractiveFormCheckBox.Text = "Remove interactive form";
            this.removeInteractiveFormCheckBox.UseVisualStyleBackColor = true;
            // 
            // cleanupContentStreamsCheckBox
            // 
            this.cleanupContentStreamsCheckBox.AutoSize = true;
            this.cleanupContentStreamsCheckBox.Checked = true;
            this.cleanupContentStreamsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cleanupContentStreamsCheckBox.Location = new System.Drawing.Point(3, 194);
            this.cleanupContentStreamsCheckBox.Name = "cleanupContentStreamsCheckBox";
            this.cleanupContentStreamsCheckBox.Size = new System.Drawing.Size(143, 17);
            this.cleanupContentStreamsCheckBox.TabIndex = 23;
            this.cleanupContentStreamsCheckBox.Text = "Cleanup content streams";
            this.cleanupContentStreamsCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeResourceDuplicatesCheckBox
            // 
            this.removeResourceDuplicatesCheckBox.AutoSize = true;
            this.removeResourceDuplicatesCheckBox.Checked = true;
            this.removeResourceDuplicatesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeResourceDuplicatesCheckBox.Location = new System.Drawing.Point(3, 171);
            this.removeResourceDuplicatesCheckBox.Name = "removeResourceDuplicatesCheckBox";
            this.removeResourceDuplicatesCheckBox.Size = new System.Drawing.Size(161, 17);
            this.removeResourceDuplicatesCheckBox.TabIndex = 22;
            this.removeResourceDuplicatesCheckBox.Text = "Remove resource duplicates";
            this.removeResourceDuplicatesCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeUnusedResourcesCheckBox
            // 
            this.removeUnusedResourcesCheckBox.AutoSize = true;
            this.removeUnusedResourcesCheckBox.Checked = true;
            this.removeUnusedResourcesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeUnusedResourcesCheckBox.Location = new System.Drawing.Point(3, 148);
            this.removeUnusedResourcesCheckBox.Name = "removeUnusedResourcesCheckBox";
            this.removeUnusedResourcesCheckBox.Size = new System.Drawing.Size(153, 17);
            this.removeUnusedResourcesCheckBox.TabIndex = 21;
            this.removeUnusedResourcesCheckBox.Text = "Remove unused resources";
            this.removeUnusedResourcesCheckBox.UseVisualStyleBackColor = true;
            // 
            // subsetFontsCheckBox
            // 
            this.subsetFontsCheckBox.AutoSize = true;
            this.subsetFontsCheckBox.Checked = true;
            this.subsetFontsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.subsetFontsCheckBox.Location = new System.Drawing.Point(3, 33);
            this.subsetFontsCheckBox.Name = "subsetFontsCheckBox";
            this.subsetFontsCheckBox.Size = new System.Drawing.Size(85, 17);
            this.subsetFontsCheckBox.TabIndex = 20;
            this.subsetFontsCheckBox.Text = "Subset fonts";
            this.subsetFontsCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeUnusedPagesCheckBox
            // 
            this.removeUnusedPagesCheckBox.AutoSize = true;
            this.removeUnusedPagesCheckBox.Checked = true;
            this.removeUnusedPagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeUnusedPagesCheckBox.Location = new System.Drawing.Point(3, 102);
            this.removeUnusedPagesCheckBox.Name = "removeUnusedPagesCheckBox";
            this.removeUnusedPagesCheckBox.Size = new System.Drawing.Size(136, 17);
            this.removeUnusedPagesCheckBox.TabIndex = 19;
            this.removeUnusedPagesCheckBox.Text = "Remove unused pages";
            this.removeUnusedPagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // cleanupNameDictionaryCheckBox
            // 
            this.cleanupNameDictionaryCheckBox.AutoSize = true;
            this.cleanupNameDictionaryCheckBox.Checked = true;
            this.cleanupNameDictionaryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cleanupNameDictionaryCheckBox.Location = new System.Drawing.Point(3, 125);
            this.cleanupNameDictionaryCheckBox.Name = "cleanupNameDictionaryCheckBox";
            this.cleanupNameDictionaryCheckBox.Size = new System.Drawing.Size(142, 17);
            this.cleanupNameDictionaryCheckBox.TabIndex = 18;
            this.cleanupNameDictionaryCheckBox.Text = "Cleanup name dictionary";
            this.cleanupNameDictionaryCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeMetadataCheckBox
            // 
            this.removeMetadataCheckBox.AutoSize = true;
            this.removeMetadataCheckBox.Location = new System.Drawing.Point(204, 148);
            this.removeMetadataCheckBox.Name = "removeMetadataCheckBox";
            this.removeMetadataCheckBox.Size = new System.Drawing.Size(113, 17);
            this.removeMetadataCheckBox.TabIndex = 17;
            this.removeMetadataCheckBox.Text = "Remove metadata";
            this.removeMetadataCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeInvalidLinksCheckBox
            // 
            this.removeInvalidLinksCheckBox.AutoSize = true;
            this.removeInvalidLinksCheckBox.Checked = true;
            this.removeInvalidLinksCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeInvalidLinksCheckBox.Location = new System.Drawing.Point(3, 79);
            this.removeInvalidLinksCheckBox.Name = "removeInvalidLinksCheckBox";
            this.removeInvalidLinksCheckBox.Size = new System.Drawing.Size(123, 17);
            this.removeInvalidLinksCheckBox.TabIndex = 16;
            this.removeInvalidLinksCheckBox.Text = "Remove invalid links";
            this.removeInvalidLinksCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeAnnotationsCheckBox
            // 
            this.removeAnnotationsCheckBox.AutoSize = true;
            this.removeAnnotationsCheckBox.Location = new System.Drawing.Point(204, 33);
            this.removeAnnotationsCheckBox.Name = "removeAnnotationsCheckBox";
            this.removeAnnotationsCheckBox.Size = new System.Drawing.Size(124, 17);
            this.removeAnnotationsCheckBox.TabIndex = 15;
            this.removeAnnotationsCheckBox.Text = "Remove annotations";
            this.removeAnnotationsCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeBookmarksCheckBox
            // 
            this.removeBookmarksCheckBox.AutoSize = true;
            this.removeBookmarksCheckBox.Location = new System.Drawing.Point(204, 56);
            this.removeBookmarksCheckBox.Name = "removeBookmarksCheckBox";
            this.removeBookmarksCheckBox.Size = new System.Drawing.Size(121, 17);
            this.removeBookmarksCheckBox.TabIndex = 14;
            this.removeBookmarksCheckBox.Text = "Remove bookmarks";
            this.removeBookmarksCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeInvalidBookmarksCheckBox
            // 
            this.removeInvalidBookmarksCheckBox.AutoSize = true;
            this.removeInvalidBookmarksCheckBox.Checked = true;
            this.removeInvalidBookmarksCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeInvalidBookmarksCheckBox.Location = new System.Drawing.Point(3, 56);
            this.removeInvalidBookmarksCheckBox.Name = "removeInvalidBookmarksCheckBox";
            this.removeInvalidBookmarksCheckBox.Size = new System.Drawing.Size(154, 17);
            this.removeInvalidBookmarksCheckBox.TabIndex = 13;
            this.removeInvalidBookmarksCheckBox.Text = "Remove invalid bookmarks";
            this.removeInvalidBookmarksCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeEmbeddedThumbnailsCheckBox
            // 
            this.removeEmbeddedThumbnailsCheckBox.AutoSize = true;
            this.removeEmbeddedThumbnailsCheckBox.Location = new System.Drawing.Point(204, 79);
            this.removeEmbeddedThumbnailsCheckBox.Name = "removeEmbeddedThumbnailsCheckBox";
            this.removeEmbeddedThumbnailsCheckBox.Size = new System.Drawing.Size(199, 17);
            this.removeEmbeddedThumbnailsCheckBox.TabIndex = 9;
            this.removeEmbeddedThumbnailsCheckBox.Text = "Remove embedded page thumbnails";
            this.removeEmbeddedThumbnailsCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeFileAttachementsCheckBox
            // 
            this.removeFileAttachementsCheckBox.AutoSize = true;
            this.removeFileAttachementsCheckBox.Location = new System.Drawing.Point(204, 125);
            this.removeFileAttachementsCheckBox.Name = "removeFileAttachementsCheckBox";
            this.removeFileAttachementsCheckBox.Size = new System.Drawing.Size(143, 17);
            this.removeFileAttachementsCheckBox.TabIndex = 10;
            this.removeFileAttachementsCheckBox.Text = "Remove file attachments";
            this.removeFileAttachementsCheckBox.UseVisualStyleBackColor = true;
            // 
            // removeDocumentInformationCheckBox
            // 
            this.removeDocumentInformationCheckBox.AutoSize = true;
            this.removeDocumentInformationCheckBox.Location = new System.Drawing.Point(204, 102);
            this.removeDocumentInformationCheckBox.Name = "removeDocumentInformationCheckBox";
            this.removeDocumentInformationCheckBox.Size = new System.Drawing.Size(170, 17);
            this.removeDocumentInformationCheckBox.TabIndex = 12;
            this.removeDocumentInformationCheckBox.Text = "Remove document information";
            this.removeDocumentInformationCheckBox.UseVisualStyleBackColor = true;
            // 
            // outputDocumentFormatTabPage
            // 
            this.outputDocumentFormatTabPage.Controls.Add(this.documentOutputFormatPanel);
            this.outputDocumentFormatTabPage.Location = new System.Drawing.Point(4, 22);
            this.outputDocumentFormatTabPage.Name = "outputDocumentFormatTabPage";
            this.outputDocumentFormatTabPage.Size = new System.Drawing.Size(659, 294);
            this.outputDocumentFormatTabPage.TabIndex = 3;
            this.outputDocumentFormatTabPage.Text = "Output Document Format";
            this.outputDocumentFormatTabPage.UseVisualStyleBackColor = true;
            // 
            // documentOutputFormatPanel
            // 
            this.documentOutputFormatPanel.Controls.Add(this.sourceFormatLabel);
            this.documentOutputFormatPanel.Controls.Add(this.useCompressedXrefCheckBox);
            this.documentOutputFormatPanel.Controls.Add(this.label9);
            this.documentOutputFormatPanel.Controls.Add(this.useTextDocumentFormatCheckBox);
            this.documentOutputFormatPanel.Controls.Add(this.compressedDocumentFormatComboBox);
            this.documentOutputFormatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentOutputFormatPanel.Location = new System.Drawing.Point(0, 0);
            this.documentOutputFormatPanel.Name = "documentOutputFormatPanel";
            this.documentOutputFormatPanel.Size = new System.Drawing.Size(659, 294);
            this.documentOutputFormatPanel.TabIndex = 8;
            // 
            // sourceFormatLabel
            // 
            this.sourceFormatLabel.AutoSize = true;
            this.sourceFormatLabel.Location = new System.Drawing.Point(224, 11);
            this.sourceFormatLabel.Name = "sourceFormatLabel";
            this.sourceFormatLabel.Size = new System.Drawing.Size(94, 13);
            this.sourceFormatLabel.TabIndex = 15;
            this.sourceFormatLabel.Text = "(source format {0})";
            // 
            // useCompressedXrefCheckBox
            // 
            this.useCompressedXrefCheckBox.AutoSize = true;
            this.useCompressedXrefCheckBox.Checked = true;
            this.useCompressedXrefCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useCompressedXrefCheckBox.Location = new System.Drawing.Point(14, 37);
            this.useCompressedXrefCheckBox.Name = "useCompressedXrefCheckBox";
            this.useCompressedXrefCheckBox.Size = new System.Drawing.Size(162, 17);
            this.useCompressedXrefCheckBox.TabIndex = 6;
            this.useCompressedXrefCheckBox.Text = "Use compressed XREF table";
            this.useCompressedXrefCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Output document format";
            // 
            // useTextDocumentFormatCheckBox
            // 
            this.useTextDocumentFormatCheckBox.AutoSize = true;
            this.useTextDocumentFormatCheckBox.Location = new System.Drawing.Point(14, 60);
            this.useTextDocumentFormatCheckBox.Name = "useTextDocumentFormatCheckBox";
            this.useTextDocumentFormatCheckBox.Size = new System.Drawing.Size(305, 17);
            this.useTextDocumentFormatCheckBox.TabIndex = 7;
            this.useTextDocumentFormatCheckBox.Text = "Use text document format and add ASCII filter to all streams";
            this.useTextDocumentFormatCheckBox.UseVisualStyleBackColor = true;
            // 
            // compressedDocumentFormatComboBox
            // 
            this.compressedDocumentFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compressedDocumentFormatComboBox.FormattingEnabled = true;
            this.compressedDocumentFormatComboBox.Location = new System.Drawing.Point(159, 8);
            this.compressedDocumentFormatComboBox.Name = "compressedDocumentFormatComboBox";
            this.compressedDocumentFormatComboBox.Size = new System.Drawing.Size(59, 21);
            this.compressedDocumentFormatComboBox.TabIndex = 14;
            this.compressedDocumentFormatComboBox.SelectedIndexChanged += new System.EventHandler(this.documentFormatComboBox_SelectedIndexChanged);
            // 
            // taskGroupsCheckedListBox
            // 
            this.taskGroupsCheckedListBox.FormattingEnabled = true;
            this.taskGroupsCheckedListBox.Location = new System.Drawing.Point(8, 96);
            this.taskGroupsCheckedListBox.Name = "taskGroupsCheckedListBox";
            this.taskGroupsCheckedListBox.Size = new System.Drawing.Size(146, 304);
            this.taskGroupsCheckedListBox.TabIndex = 13;
            this.taskGroupsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.taskGroupsCheckedListBox_ItemCheck);
            this.taskGroupsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.taskGroupsCheckedListBox_SelectedIndexChanged);
            // 
            // executeCompressionButton
            // 
            this.executeCompressionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.executeCompressionButton.Location = new System.Drawing.Point(8, 420);
            this.executeCompressionButton.Name = "executeCompressionButton";
            this.executeCompressionButton.Size = new System.Drawing.Size(146, 27);
            this.executeCompressionButton.TabIndex = 10;
            this.executeCompressionButton.Text = "Execute Compression";
            this.executeCompressionButton.UseVisualStyleBackColor = true;
            this.executeCompressionButton.Click += new System.EventHandler(this.executeCompressionButton_Click);
            // 
            // pdfDocumentCompressionBackgroundWorker
            // 
            this.pdfDocumentCompressionBackgroundWorker.WorkerReportsProgress = true;
            this.pdfDocumentCompressionBackgroundWorker.WorkerSupportsCancellation = true;
            this.pdfDocumentCompressionBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.pdfDocumentCompressionBackgroundWorker_DoWork);
            this.pdfDocumentCompressionBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.pdfDocumentCompressionBackgroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(834, 677);
            this.Controls.Add(this.executeCompressionButton);
            this.Controls.Add(this.taskGroupsCheckedListBox);
            this.Controls.Add(this.taskGroupsTabControl);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.compressionProgressBar);
            this.Controls.Add(this.compressedFileSizeLabel);
            this.Controls.Add(this.sourceFileSizeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compressedFileSizeProgressBar);
            this.Controls.Add(this.sourceFileSizeProgressBar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Compressor Demo";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.taskGroupsTabControl.ResumeLayout(false);
            this.imagesTabPage.ResumeLayout(false);
            this.imagesPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxInaccuracyNumericUpDown)).EndInit();
            this.colorImagesGroupBox.ResumeLayout(false);
            this.colorImagesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorImagesMinResolutionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorImagesDownscaleNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blackWhiteImagesMinResolutionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackWhiteImagesDownscaleNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grayImagesMinResolutionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayImagesDownscaleNumericUpDown)).EndInit();
            this.resourcesTabPage.ResumeLayout(false);
            this.resourcesPanel.ResumeLayout(false);
            this.resourcesPanel.PerformLayout();
            this.cleanUpTabPage.ResumeLayout(false);
            this.cleanUpPanel.ResumeLayout(false);
            this.cleanUpPanel.PerformLayout();
            this.outputDocumentFormatTabPage.ResumeLayout(false);
            this.documentOutputFormatPanel.ResumeLayout(false);
            this.documentOutputFormatPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ProgressBar sourceFileSizeProgressBar;
        private System.Windows.Forms.ProgressBar compressedFileSizeProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sourceFileSizeLabel;
        private System.Windows.Forms.Label compressedFileSizeLabel;
        private System.Windows.Forms.ProgressBar compressionProgressBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl taskGroupsTabControl;
        private System.Windows.Forms.TabPage imagesTabPage;
        private System.Windows.Forms.TabPage resourcesTabPage;
        private System.Windows.Forms.CheckedListBox taskGroupsCheckedListBox;
        private System.Windows.Forms.GroupBox colorImagesGroupBox;
        private System.Windows.Forms.NumericUpDown colorImagesDownscaleNumericUpDown;
        private System.Windows.Forms.Button colorImagesCompressionSettingsButton;
        private System.Windows.Forms.CheckBox compressColorImagesCheckBox;
        private System.Windows.Forms.ComboBox colorCompressionComboBox;
        private System.Windows.Forms.CheckBox downscaleColorImagesCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown blackWhiteImagesMinResolutionNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown blackWhiteImagesDownscaleNumericUpDown;
        private System.Windows.Forms.Button blackWhiteImagesCompressionSettingsButton;
        private System.Windows.Forms.CheckBox compressBlackWhiteImagesCheckBox;
        private System.Windows.Forms.ComboBox blackWhiteCompressionComboBox;
        private System.Windows.Forms.CheckBox downscaleBlackWhiteImagesCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown grayImagesMinResolutionNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown grayImagesDownscaleNumericUpDown;
        private System.Windows.Forms.Button grayImagesCompressionSettingsButton;
        private System.Windows.Forms.CheckBox compressGrayImagesCheckBox;
        private System.Windows.Forms.ComboBox grayCompressionComboBox;
        private System.Windows.Forms.CheckBox downscaleGrayImagesCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown colorImagesMinResolutionNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox compressedDocumentFormatComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button executeCompressionButton;
        private System.Windows.Forms.CheckBox useFlateInstreadLzwCheckBox;
        private System.Windows.Forms.CheckBox recompressFlateUsingBestCompressionCheckBox;
        private System.Windows.Forms.CheckBox useFlateInstreadNoneCheckBox;
        private System.Windows.Forms.TabPage cleanUpTabPage;
        private System.Windows.Forms.CheckBox removeFileAttachementsCheckBox;
        private System.Windows.Forms.CheckBox removeEmbeddedThumbnailsCheckBox;
        private System.Windows.Forms.TabPage outputDocumentFormatTabPage;
        private System.Windows.Forms.CheckBox useCompressedXrefCheckBox;
        private System.Windows.Forms.CheckBox useTextDocumentFormatCheckBox;
        private System.Windows.Forms.CheckBox removeInvalidBookmarksCheckBox;
        private System.Windows.Forms.Label sourceFormatLabel;
        private System.Windows.Forms.Panel imagesPanel;
        private System.Windows.Forms.Panel resourcesPanel;
        private System.Windows.Forms.Panel cleanUpPanel;
        private System.Windows.Forms.Panel documentOutputFormatPanel;
        private System.Windows.Forms.CheckBox removeDocumentInformationCheckBox;
        private System.Windows.Forms.CheckBox removeBookmarksCheckBox;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inspectSpaceUsageToolStripMenuItem;
        private System.Windows.Forms.CheckBox removeInvalidLinksCheckBox;
        private System.Windows.Forms.CheckBox removeAnnotationsCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox detectIndexedImagesCheckBox;
        private System.Windows.Forms.CheckBox detectGrayscaleImagesCheckBox;
        private System.Windows.Forms.CheckBox detectBlackWhiteImagesCheckBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown maxInaccuracyNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox detectBitonalImagesCheckBox;
        private System.Windows.Forms.CheckBox removeMetadataCheckBox;
        private System.Windows.Forms.CheckBox removeUnusedPagesCheckBox;
        private System.Windows.Forms.CheckBox cleanupNameDictionaryCheckBox;
        private System.Windows.Forms.CheckBox subsetFontsCheckBox;
        private System.Windows.Forms.CheckBox removeUnusedResourcesCheckBox;
        private System.Windows.Forms.CheckBox removeResourceDuplicatesCheckBox;
        private System.ComponentModel.BackgroundWorker pdfDocumentCompressionBackgroundWorker;
        private System.Windows.Forms.CheckBox cleanupContentStreamsCheckBox;
        private System.Windows.Forms.CheckBox removeInteractiveFormCheckBox;
        private System.Windows.Forms.CheckBox removeStuctureTreeCheckBox;
        private System.Windows.Forms.CheckBox optimizeFontSubsetsCheckBox;
        private System.Windows.Forms.ToolStripMenuItem useMultithreadingToolStripMenuItem;
        private System.Windows.Forms.CheckBox flattenAnnotationsCheckBox;
    }
}