namespace MKVmergeBatcher
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBatcher = new System.Windows.Forms.TabPage();
            this.BTCClearQueueButton = new System.Windows.Forms.Button();
            this.BTCAddToQueueButton = new System.Windows.Forms.Button();
            this.BTCPathLabel = new System.Windows.Forms.Label();
            this.BTCExtensionsLabel = new System.Windows.Forms.Label();
            this.BTCExectuteNowButton = new System.Windows.Forms.Button();
            this.BTCModelsComboBox = new System.Windows.Forms.ComboBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTCCreateBatButton = new System.Windows.Forms.Button();
            this.BTCVideoFilesListBox = new System.Windows.Forms.ListBox();
            this.BTCVideoFilesListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BTCReverseSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTCCleanSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTCVideoExtensionsTextBox = new System.Windows.Forms.TextBox();
            this.batcherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BTCVideoBrowseButton = new System.Windows.Forms.Button();
            this.BTCFilePathTextBox = new System.Windows.Forms.TextBox();
            this.BTCMkvMergePathBrowseButton = new System.Windows.Forms.Button();
            this.BTCMkvMergePathLabel = new System.Windows.Forms.Label();
            this.BTCMkvMergePathTextBox = new System.Windows.Forms.TextBox();
            this.tabManageModels = new System.Windows.Forms.TabPage();
            this.MMSortByModelNameButton = new System.Windows.Forms.Button();
            this.MMMoveBottomButton = new System.Windows.Forms.Button();
            this.MMMoveTopButton = new System.Windows.Forms.Button();
            this.MMMoveDownButton = new System.Windows.Forms.Button();
            this.MMMoveUpButton = new System.Windows.Forms.Button();
            this.MMRemoveSelectedButton = new System.Windows.Forms.Button();
            this.MMSaveButton = new System.Windows.Forms.Button();
            this.MMModelContentTextBox = new System.Windows.Forms.TextBox();
            this.MMModelNameTextBox = new System.Windows.Forms.TextBox();
            this.MMListBox = new System.Windows.Forms.ListBox();
            this.tabModelCreator = new System.Windows.Forms.TabPage();
            this.additionalFlagsGroupBox = new System.Windows.Forms.GroupBox();
            this.MCAddChaptersCheckBox = new System.Windows.Forms.CheckBox();
            this.additionalFlagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MCAddAttachmentsCheckBox = new System.Windows.Forms.CheckBox();
            this.MCDisableCompressionCheckBox = new System.Windows.Forms.CheckBox();
            this.MCCleanTitleCheckBox = new System.Windows.Forms.CheckBox();
            this.MCNoAttachmentsCheckBox = new System.Windows.Forms.CheckBox();
            this.tracksGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MCLoadDefaultButton = new System.Windows.Forms.Button();
            this.MCSaveDefaultButton = new System.Windows.Forms.Button();
            this.MCExternalTrackMoveDownButton = new System.Windows.Forms.Button();
            this.MCExternalTrackRemoveSelectedButton = new System.Windows.Forms.Button();
            this.MCExternalTrackMoveUpButton = new System.Windows.Forms.Button();
            this.MCExternalTrackClearListButton = new System.Windows.Forms.Button();
            this.MCDataGridView = new System.Windows.Forms.DataGridView();
            this.MCDataGridViewType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MCPositionInOriginalFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCLanguageCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCLanguageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCExternalFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MCExtension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCSuffix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCDefaultFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MCForcedFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MCPreviewButton = new System.Windows.Forms.Button();
            this.tabQueue = new System.Windows.Forms.TabPage();
            this.QAutoClearErrorJobsCheckBox = new System.Windows.Forms.CheckBox();
            this.QAutoClearWarningJobsCheckBox = new System.Windows.Forms.CheckBox();
            this.QAutoClearOkJobsCheckBox = new System.Windows.Forms.CheckBox();
            this.QRemoveErrorButton = new System.Windows.Forms.Button();
            this.QRemoveWarningButton = new System.Windows.Forms.Button();
            this.QRemoveOkButton = new System.Windows.Forms.Button();
            this.QExecNowButton = new System.Windows.Forms.Button();
            this.QCreateBatButton = new System.Windows.Forms.Button();
            this.QClearQueueButton = new System.Windows.Forms.Button();
            this.QRemoveFromQueueButton = new System.Windows.Forms.Button();
            this.QDataGridView = new System.Windows.Forms.DataGridView();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.ODeleteIncompleteFileCheckBox = new System.Windows.Forms.CheckBox();
            this.optionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OReplaceExistingDestinationFileCheckBox = new System.Windows.Forms.CheckBox();
            this.OMoveWarningFilesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OMoveOkFilesTextBox = new System.Windows.Forms.TextBox();
            this.OMoveOkFilesLabel = new System.Windows.Forms.Label();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.aboutTextBox = new System.Windows.Forms.RichTextBox();
            this.tracksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelCreatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelManagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MCToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.OToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabBatcher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.BTCVideoFilesListContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batcherBindingSource)).BeginInit();
            this.tabManageModels.SuspendLayout();
            this.tabModelCreator.SuspendLayout();
            this.additionalFlagsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.additionalFlagsBindingSource)).BeginInit();
            this.tracksGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MCDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            this.tabQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueBindingSource)).BeginInit();
            this.tabOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBindingSource)).BeginInit();
            this.tabHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracksBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelCreatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelManagementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBatcher);
            this.tabControl1.Controls.Add(this.tabManageModels);
            this.tabControl1.Controls.Add(this.tabModelCreator);
            this.tabControl1.Controls.Add(this.tabQueue);
            this.tabControl1.Controls.Add(this.tabOptions);
            this.tabControl1.Controls.Add(this.tabHelp);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(3, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBatcher
            // 
            this.tabBatcher.AutoScroll = true;
            this.tabBatcher.Controls.Add(this.BTCClearQueueButton);
            this.tabBatcher.Controls.Add(this.BTCAddToQueueButton);
            this.tabBatcher.Controls.Add(this.BTCPathLabel);
            this.tabBatcher.Controls.Add(this.BTCExtensionsLabel);
            this.tabBatcher.Controls.Add(this.BTCExectuteNowButton);
            this.tabBatcher.Controls.Add(this.BTCModelsComboBox);
            this.tabBatcher.Controls.Add(this.BTCCreateBatButton);
            this.tabBatcher.Controls.Add(this.BTCVideoFilesListBox);
            this.tabBatcher.Controls.Add(this.BTCVideoExtensionsTextBox);
            this.tabBatcher.Controls.Add(this.BTCVideoBrowseButton);
            this.tabBatcher.Controls.Add(this.BTCFilePathTextBox);
            this.tabBatcher.Controls.Add(this.BTCMkvMergePathBrowseButton);
            this.tabBatcher.Controls.Add(this.BTCMkvMergePathLabel);
            this.tabBatcher.Controls.Add(this.BTCMkvMergePathTextBox);
            this.tabBatcher.Location = new System.Drawing.Point(4, 22);
            this.tabBatcher.Name = "tabBatcher";
            this.tabBatcher.Padding = new System.Windows.Forms.Padding(3);
            this.tabBatcher.Size = new System.Drawing.Size(916, 481);
            this.tabBatcher.TabIndex = 0;
            this.tabBatcher.Text = "Batcher";
            this.tabBatcher.UseVisualStyleBackColor = true;
            // 
            // BTCClearQueueButton
            // 
            this.BTCClearQueueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCClearQueueButton.Location = new System.Drawing.Point(562, 450);
            this.BTCClearQueueButton.Name = "BTCClearQueueButton";
            this.BTCClearQueueButton.Size = new System.Drawing.Size(89, 23);
            this.BTCClearQueueButton.TabIndex = 13;
            this.BTCClearQueueButton.Text = "Clear Queue";
            this.BTCClearQueueButton.UseVisualStyleBackColor = true;
            this.BTCClearQueueButton.Click += new System.EventHandler(this.BTCClearQueueButton_Click);
            // 
            // BTCAddToQueueButton
            // 
            this.BTCAddToQueueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCAddToQueueButton.Location = new System.Drawing.Point(657, 450);
            this.BTCAddToQueueButton.Name = "BTCAddToQueueButton";
            this.BTCAddToQueueButton.Size = new System.Drawing.Size(89, 23);
            this.BTCAddToQueueButton.TabIndex = 12;
            this.BTCAddToQueueButton.Text = "Add to Queue";
            this.BTCAddToQueueButton.UseVisualStyleBackColor = true;
            this.BTCAddToQueueButton.Click += new System.EventHandler(this.BTCAddToQueueButton_Click);
            // 
            // BTCPathLabel
            // 
            this.BTCPathLabel.AutoSize = true;
            this.BTCPathLabel.Location = new System.Drawing.Point(3, 35);
            this.BTCPathLabel.Name = "BTCPathLabel";
            this.BTCPathLabel.Size = new System.Drawing.Size(32, 13);
            this.BTCPathLabel.TabIndex = 11;
            this.BTCPathLabel.Text = "Path:";
            // 
            // BTCExtensionsLabel
            // 
            this.BTCExtensionsLabel.AutoSize = true;
            this.BTCExtensionsLabel.Location = new System.Drawing.Point(3, 61);
            this.BTCExtensionsLabel.Name = "BTCExtensionsLabel";
            this.BTCExtensionsLabel.Size = new System.Drawing.Size(61, 13);
            this.BTCExtensionsLabel.TabIndex = 10;
            this.BTCExtensionsLabel.Text = "Extensions:";
            // 
            // BTCExectuteNowButton
            // 
            this.BTCExectuteNowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCExectuteNowButton.Location = new System.Drawing.Point(752, 450);
            this.BTCExectuteNowButton.Name = "BTCExectuteNowButton";
            this.BTCExectuteNowButton.Size = new System.Drawing.Size(75, 23);
            this.BTCExectuteNowButton.TabIndex = 9;
            this.BTCExectuteNowButton.Text = "Exec Now";
            this.BTCExectuteNowButton.UseVisualStyleBackColor = true;
            this.BTCExectuteNowButton.Click += new System.EventHandler(this.BTCExectuteNowButton_Click);
            // 
            // BTCModelsComboBox
            // 
            this.BTCModelsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCModelsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BTCModelsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BTCModelsComboBox.DataSource = this.modelBindingSource;
            this.BTCModelsComboBox.DisplayMember = "modelName";
            this.BTCModelsComboBox.FormattingEnabled = true;
            this.BTCModelsComboBox.Location = new System.Drawing.Point(6, 423);
            this.BTCModelsComboBox.Name = "BTCModelsComboBox";
            this.BTCModelsComboBox.Size = new System.Drawing.Size(902, 21);
            this.BTCModelsComboBox.TabIndex = 7;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(MKVmergeBatcher.src.obj.UserData.ModelManagement.Model);
            // 
            // BTCCreateBatButton
            // 
            this.BTCCreateBatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCCreateBatButton.Location = new System.Drawing.Point(833, 450);
            this.BTCCreateBatButton.Name = "BTCCreateBatButton";
            this.BTCCreateBatButton.Size = new System.Drawing.Size(75, 23);
            this.BTCCreateBatButton.TabIndex = 8;
            this.BTCCreateBatButton.Text = "Create BAT";
            this.BTCCreateBatButton.UseVisualStyleBackColor = true;
            this.BTCCreateBatButton.Click += new System.EventHandler(this.BTCCreateBatButton_Click);
            // 
            // BTCVideoFilesListBox
            // 
            this.BTCVideoFilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCVideoFilesListBox.ContextMenuStrip = this.BTCVideoFilesListContextMenuStrip;
            this.BTCVideoFilesListBox.FormattingEnabled = true;
            this.BTCVideoFilesListBox.HorizontalScrollbar = true;
            this.BTCVideoFilesListBox.Location = new System.Drawing.Point(6, 84);
            this.BTCVideoFilesListBox.Name = "BTCVideoFilesListBox";
            this.BTCVideoFilesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.BTCVideoFilesListBox.Size = new System.Drawing.Size(902, 329);
            this.BTCVideoFilesListBox.TabIndex = 6;
            // 
            // BTCVideoFilesListContextMenuStrip
            // 
            this.BTCVideoFilesListContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BTCVideoFilesListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTCReverseSelectionToolStripMenuItem,
            this.BTCCleanSelectionToolStripMenuItem});
            this.BTCVideoFilesListContextMenuStrip.Name = "BTCVideoFilesListContextMenuStrip";
            this.BTCVideoFilesListContextMenuStrip.Size = new System.Drawing.Size(166, 48);
            // 
            // BTCReverseSelectionToolStripMenuItem
            // 
            this.BTCReverseSelectionToolStripMenuItem.Name = "BTCReverseSelectionToolStripMenuItem";
            this.BTCReverseSelectionToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.BTCReverseSelectionToolStripMenuItem.Text = "Reverse Selection";
            this.BTCReverseSelectionToolStripMenuItem.Click += new System.EventHandler(this.BTCReverseSelectionToolStripMenuItem_Click);
            // 
            // BTCCleanSelectionToolStripMenuItem
            // 
            this.BTCCleanSelectionToolStripMenuItem.Name = "BTCCleanSelectionToolStripMenuItem";
            this.BTCCleanSelectionToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.BTCCleanSelectionToolStripMenuItem.Text = "Clear Selection";
            this.BTCCleanSelectionToolStripMenuItem.Click += new System.EventHandler(this.BTCCleanSelectionToolStripMenuItem_Click);
            // 
            // BTCVideoExtensionsTextBox
            // 
            this.BTCVideoExtensionsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCVideoExtensionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batcherBindingSource, "videoExtensions", true));
            this.BTCVideoExtensionsTextBox.Location = new System.Drawing.Point(70, 58);
            this.BTCVideoExtensionsTextBox.Name = "BTCVideoExtensionsTextBox";
            this.BTCVideoExtensionsTextBox.Size = new System.Drawing.Size(838, 20);
            this.BTCVideoExtensionsTextBox.TabIndex = 5;
            this.BTCVideoExtensionsTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BTCVideoExtensionsTextBox_MouseClick);
            // 
            // batcherBindingSource
            // 
            this.batcherBindingSource.DataSource = typeof(MKVmergeBatcher.src.obj.UserData.Batcher);
            // 
            // BTCVideoBrowseButton
            // 
            this.BTCVideoBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCVideoBrowseButton.Location = new System.Drawing.Point(833, 32);
            this.BTCVideoBrowseButton.Name = "BTCVideoBrowseButton";
            this.BTCVideoBrowseButton.Size = new System.Drawing.Size(75, 20);
            this.BTCVideoBrowseButton.TabIndex = 4;
            this.BTCVideoBrowseButton.Text = "Browse";
            this.BTCVideoBrowseButton.UseVisualStyleBackColor = true;
            this.BTCVideoBrowseButton.Click += new System.EventHandler(this.BTCVideoBrowseButton_Click);
            // 
            // BTCFilePathTextBox
            // 
            this.BTCFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCFilePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batcherBindingSource, "lastVideoPath", true));
            this.BTCFilePathTextBox.Location = new System.Drawing.Point(70, 32);
            this.BTCFilePathTextBox.Name = "BTCFilePathTextBox";
            this.BTCFilePathTextBox.Size = new System.Drawing.Size(757, 20);
            this.BTCFilePathTextBox.TabIndex = 3;
            // 
            // BTCMkvMergePathBrowseButton
            // 
            this.BTCMkvMergePathBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCMkvMergePathBrowseButton.Location = new System.Drawing.Point(794, 6);
            this.BTCMkvMergePathBrowseButton.Name = "BTCMkvMergePathBrowseButton";
            this.BTCMkvMergePathBrowseButton.Size = new System.Drawing.Size(114, 20);
            this.BTCMkvMergePathBrowseButton.TabIndex = 2;
            this.BTCMkvMergePathBrowseButton.Text = "Browse MkvMerge";
            this.BTCMkvMergePathBrowseButton.UseVisualStyleBackColor = true;
            this.BTCMkvMergePathBrowseButton.Click += new System.EventHandler(this.BTCMkvMergePathBrowseButton_Click);
            // 
            // BTCMkvMergePathLabel
            // 
            this.BTCMkvMergePathLabel.AutoSize = true;
            this.BTCMkvMergePathLabel.Location = new System.Drawing.Point(3, 9);
            this.BTCMkvMergePathLabel.Name = "BTCMkvMergePathLabel";
            this.BTCMkvMergePathLabel.Size = new System.Drawing.Size(105, 13);
            this.BTCMkvMergePathLabel.TabIndex = 1;
            this.BTCMkvMergePathLabel.Text = "Mvkmerge.exe Path:";
            // 
            // BTCMkvMergePathTextBox
            // 
            this.BTCMkvMergePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCMkvMergePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batcherBindingSource, "mvkMergePath", true));
            this.BTCMkvMergePathTextBox.Location = new System.Drawing.Point(115, 6);
            this.BTCMkvMergePathTextBox.Name = "BTCMkvMergePathTextBox";
            this.BTCMkvMergePathTextBox.Size = new System.Drawing.Size(673, 20);
            this.BTCMkvMergePathTextBox.TabIndex = 0;
            // 
            // tabManageModels
            // 
            this.tabManageModels.Controls.Add(this.MMSortByModelNameButton);
            this.tabManageModels.Controls.Add(this.MMMoveBottomButton);
            this.tabManageModels.Controls.Add(this.MMMoveTopButton);
            this.tabManageModels.Controls.Add(this.MMMoveDownButton);
            this.tabManageModels.Controls.Add(this.MMMoveUpButton);
            this.tabManageModels.Controls.Add(this.MMRemoveSelectedButton);
            this.tabManageModels.Controls.Add(this.MMSaveButton);
            this.tabManageModels.Controls.Add(this.MMModelContentTextBox);
            this.tabManageModels.Controls.Add(this.MMModelNameTextBox);
            this.tabManageModels.Controls.Add(this.MMListBox);
            this.tabManageModels.Location = new System.Drawing.Point(4, 22);
            this.tabManageModels.Name = "tabManageModels";
            this.tabManageModels.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageModels.Size = new System.Drawing.Size(916, 481);
            this.tabManageModels.TabIndex = 1;
            this.tabManageModels.Text = "Manage Models";
            this.tabManageModels.UseVisualStyleBackColor = true;
            // 
            // MMSortByModelNameButton
            // 
            this.MMSortByModelNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MMSortByModelNameButton.Location = new System.Drawing.Point(806, 141);
            this.MMSortByModelNameButton.Name = "MMSortByModelNameButton";
            this.MMSortByModelNameButton.Size = new System.Drawing.Size(102, 36);
            this.MMSortByModelNameButton.TabIndex = 9;
            this.MMSortByModelNameButton.Text = "Sort by Model Name";
            this.MMSortByModelNameButton.UseVisualStyleBackColor = true;
            this.MMSortByModelNameButton.Click += new System.EventHandler(this.MMSortByModelNameButton_Click);
            // 
            // MMMoveBottomButton
            // 
            this.MMMoveBottomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MMMoveBottomButton.Location = new System.Drawing.Point(806, 114);
            this.MMMoveBottomButton.Name = "MMMoveBottomButton";
            this.MMMoveBottomButton.Size = new System.Drawing.Size(102, 21);
            this.MMMoveBottomButton.TabIndex = 8;
            this.MMMoveBottomButton.Text = "Move at Bottom";
            this.MMMoveBottomButton.UseVisualStyleBackColor = true;
            this.MMMoveBottomButton.Click += new System.EventHandler(this.MMMoveBottomButton_Click);
            // 
            // MMMoveTopButton
            // 
            this.MMMoveTopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MMMoveTopButton.Location = new System.Drawing.Point(806, 87);
            this.MMMoveTopButton.Name = "MMMoveTopButton";
            this.MMMoveTopButton.Size = new System.Drawing.Size(102, 21);
            this.MMMoveTopButton.TabIndex = 7;
            this.MMMoveTopButton.Text = "Move at Top";
            this.MMMoveTopButton.UseVisualStyleBackColor = true;
            this.MMMoveTopButton.Click += new System.EventHandler(this.MMMoveTopButton_Click);
            // 
            // MMMoveDownButton
            // 
            this.MMMoveDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MMMoveDownButton.Location = new System.Drawing.Point(806, 60);
            this.MMMoveDownButton.Name = "MMMoveDownButton";
            this.MMMoveDownButton.Size = new System.Drawing.Size(102, 21);
            this.MMMoveDownButton.TabIndex = 6;
            this.MMMoveDownButton.Text = "Move Down";
            this.MMMoveDownButton.UseVisualStyleBackColor = true;
            this.MMMoveDownButton.Click += new System.EventHandler(this.MMMoveDownButton_Click);
            // 
            // MMMoveUpButton
            // 
            this.MMMoveUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MMMoveUpButton.Location = new System.Drawing.Point(806, 33);
            this.MMMoveUpButton.Name = "MMMoveUpButton";
            this.MMMoveUpButton.Size = new System.Drawing.Size(102, 21);
            this.MMMoveUpButton.TabIndex = 5;
            this.MMMoveUpButton.Text = "Move Up";
            this.MMMoveUpButton.UseVisualStyleBackColor = true;
            this.MMMoveUpButton.Click += new System.EventHandler(this.MMMoveUpButton_Click);
            // 
            // MMRemoveSelectedButton
            // 
            this.MMRemoveSelectedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MMRemoveSelectedButton.Location = new System.Drawing.Point(806, 6);
            this.MMRemoveSelectedButton.Name = "MMRemoveSelectedButton";
            this.MMRemoveSelectedButton.Size = new System.Drawing.Size(102, 21);
            this.MMRemoveSelectedButton.TabIndex = 4;
            this.MMRemoveSelectedButton.Text = "Remove Selected";
            this.MMRemoveSelectedButton.UseVisualStyleBackColor = true;
            this.MMRemoveSelectedButton.Click += new System.EventHandler(this.MMRemoveSelectedButton_Click);
            // 
            // MMSaveButton
            // 
            this.MMSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MMSaveButton.Location = new System.Drawing.Point(806, 314);
            this.MMSaveButton.Name = "MMSaveButton";
            this.MMSaveButton.Size = new System.Drawing.Size(102, 21);
            this.MMSaveButton.TabIndex = 3;
            this.MMSaveButton.Text = "Save Changes";
            this.MMSaveButton.UseVisualStyleBackColor = true;
            this.MMSaveButton.Click += new System.EventHandler(this.MMSaveButton_Click);
            // 
            // MMModelContentTextBox
            // 
            this.MMModelContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MMModelContentTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMModelContentTextBox.Location = new System.Drawing.Point(8, 341);
            this.MMModelContentTextBox.Multiline = true;
            this.MMModelContentTextBox.Name = "MMModelContentTextBox";
            this.MMModelContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MMModelContentTextBox.Size = new System.Drawing.Size(900, 132);
            this.MMModelContentTextBox.TabIndex = 2;
            // 
            // MMModelNameTextBox
            // 
            this.MMModelNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MMModelNameTextBox.Location = new System.Drawing.Point(8, 315);
            this.MMModelNameTextBox.Name = "MMModelNameTextBox";
            this.MMModelNameTextBox.Size = new System.Drawing.Size(792, 20);
            this.MMModelNameTextBox.TabIndex = 1;
            // 
            // MMListBox
            // 
            this.MMListBox.AllowDrop = true;
            this.MMListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MMListBox.DataSource = this.modelBindingSource;
            this.MMListBox.DisplayMember = "modelName";
            this.MMListBox.FormattingEnabled = true;
            this.MMListBox.Location = new System.Drawing.Point(8, 6);
            this.MMListBox.Name = "MMListBox";
            this.MMListBox.Size = new System.Drawing.Size(792, 303);
            this.MMListBox.TabIndex = 0;
            this.MMListBox.SelectedIndexChanged += new System.EventHandler(this.MMListBox_SelectedIndexChanged);
            // 
            // tabModelCreator
            // 
            this.tabModelCreator.AutoScroll = true;
            this.tabModelCreator.Controls.Add(this.additionalFlagsGroupBox);
            this.tabModelCreator.Controls.Add(this.tracksGroupBox);
            this.tabModelCreator.Controls.Add(this.MCPreviewButton);
            this.tabModelCreator.Location = new System.Drawing.Point(4, 22);
            this.tabModelCreator.Name = "tabModelCreator";
            this.tabModelCreator.Size = new System.Drawing.Size(916, 481);
            this.tabModelCreator.TabIndex = 2;
            this.tabModelCreator.Text = "Model Creator";
            this.tabModelCreator.UseVisualStyleBackColor = true;
            // 
            // additionalFlagsGroupBox
            // 
            this.additionalFlagsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalFlagsGroupBox.Controls.Add(this.MCAddChaptersCheckBox);
            this.additionalFlagsGroupBox.Controls.Add(this.MCAddAttachmentsCheckBox);
            this.additionalFlagsGroupBox.Controls.Add(this.MCDisableCompressionCheckBox);
            this.additionalFlagsGroupBox.Controls.Add(this.MCCleanTitleCheckBox);
            this.additionalFlagsGroupBox.Controls.Add(this.MCNoAttachmentsCheckBox);
            this.additionalFlagsGroupBox.Location = new System.Drawing.Point(8, 372);
            this.additionalFlagsGroupBox.Name = "additionalFlagsGroupBox";
            this.additionalFlagsGroupBox.Size = new System.Drawing.Size(900, 77);
            this.additionalFlagsGroupBox.TabIndex = 28;
            this.additionalFlagsGroupBox.TabStop = false;
            this.additionalFlagsGroupBox.Text = "Additional Flags";
            // 
            // MCAddChaptersCheckBox
            // 
            this.MCAddChaptersCheckBox.AutoSize = true;
            this.MCAddChaptersCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.additionalFlagsBindingSource, "addChapters", true));
            this.MCAddChaptersCheckBox.Location = new System.Drawing.Point(441, 19);
            this.MCAddChaptersCheckBox.Name = "MCAddChaptersCheckBox";
            this.MCAddChaptersCheckBox.Size = new System.Drawing.Size(90, 17);
            this.MCAddChaptersCheckBox.TabIndex = 4;
            this.MCAddChaptersCheckBox.Text = "Add Chapters";
            this.MCToolTip.SetToolTip(this.MCAddChaptersCheckBox, "Generate in the model a ||chapters|| tag that in the result execution add (if exi" +
        "sts) the fileName_chapters.xml from the same folder as file name");
            this.MCAddChaptersCheckBox.UseVisualStyleBackColor = true;
            // 
            // additionalFlagsBindingSource
            // 
            this.additionalFlagsBindingSource.DataSource = typeof(MKVmergeBatcher.src.obj.UserData.ModelCreator.AdditionalFlags);
            // 
            // MCAddAttachmentsCheckBox
            // 
            this.MCAddAttachmentsCheckBox.AutoSize = true;
            this.MCAddAttachmentsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.additionalFlagsBindingSource, "addAttachments", true));
            this.MCAddAttachmentsCheckBox.Location = new System.Drawing.Point(328, 19);
            this.MCAddAttachmentsCheckBox.Name = "MCAddAttachmentsCheckBox";
            this.MCAddAttachmentsCheckBox.Size = new System.Drawing.Size(107, 17);
            this.MCAddAttachmentsCheckBox.TabIndex = 3;
            this.MCAddAttachmentsCheckBox.Text = "Add Attachments";
            this.MCToolTip.SetToolTip(this.MCAddAttachmentsCheckBox, "Generate in the model a ||attachments|| tag that in the result execution add all " +
        "attachments from the folder named as file name");
            this.MCAddAttachmentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // MCDisableCompressionCheckBox
            // 
            this.MCDisableCompressionCheckBox.AutoSize = true;
            this.MCDisableCompressionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.additionalFlagsBindingSource, "disableCompression", true));
            this.MCDisableCompressionCheckBox.Location = new System.Drawing.Point(204, 19);
            this.MCDisableCompressionCheckBox.Name = "MCDisableCompressionCheckBox";
            this.MCDisableCompressionCheckBox.Size = new System.Drawing.Size(118, 17);
            this.MCDisableCompressionCheckBox.TabIndex = 2;
            this.MCDisableCompressionCheckBox.Text = "--compression none";
            this.MCDisableCompressionCheckBox.UseVisualStyleBackColor = true;
            // 
            // MCCleanTitleCheckBox
            // 
            this.MCCleanTitleCheckBox.AutoSize = true;
            this.MCCleanTitleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.additionalFlagsBindingSource, "cleanTitle", true));
            this.MCCleanTitleCheckBox.Location = new System.Drawing.Point(119, 19);
            this.MCCleanTitleCheckBox.Name = "MCCleanTitleCheckBox";
            this.MCCleanTitleCheckBox.Size = new System.Drawing.Size(79, 17);
            this.MCCleanTitleCheckBox.TabIndex = 1;
            this.MCCleanTitleCheckBox.Text = "--title empty";
            this.MCCleanTitleCheckBox.UseVisualStyleBackColor = true;
            // 
            // MCNoAttachmentsCheckBox
            // 
            this.MCNoAttachmentsCheckBox.AutoSize = true;
            this.MCNoAttachmentsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.additionalFlagsBindingSource, "noAttachments", true));
            this.MCNoAttachmentsCheckBox.Location = new System.Drawing.Point(8, 19);
            this.MCNoAttachmentsCheckBox.Name = "MCNoAttachmentsCheckBox";
            this.MCNoAttachmentsCheckBox.Size = new System.Drawing.Size(105, 17);
            this.MCNoAttachmentsCheckBox.TabIndex = 0;
            this.MCNoAttachmentsCheckBox.Text = "--no-attachments";
            this.MCNoAttachmentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // tracksGroupBox
            // 
            this.tracksGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tracksGroupBox.Controls.Add(this.panel1);
            this.tracksGroupBox.Controls.Add(this.MCDataGridView);
            this.tracksGroupBox.Location = new System.Drawing.Point(7, 3);
            this.tracksGroupBox.Name = "tracksGroupBox";
            this.tracksGroupBox.Size = new System.Drawing.Size(901, 363);
            this.tracksGroupBox.TabIndex = 27;
            this.tracksGroupBox.TabStop = false;
            this.tracksGroupBox.Text = "Tracks";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.MCLoadDefaultButton);
            this.panel1.Controls.Add(this.MCSaveDefaultButton);
            this.panel1.Controls.Add(this.MCExternalTrackMoveDownButton);
            this.panel1.Controls.Add(this.MCExternalTrackRemoveSelectedButton);
            this.panel1.Controls.Add(this.MCExternalTrackMoveUpButton);
            this.panel1.Controls.Add(this.MCExternalTrackClearListButton);
            this.panel1.Location = new System.Drawing.Point(752, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 190);
            this.panel1.TabIndex = 26;
            // 
            // MCLoadDefaultButton
            // 
            this.MCLoadDefaultButton.Location = new System.Drawing.Point(5, 148);
            this.MCLoadDefaultButton.Name = "MCLoadDefaultButton";
            this.MCLoadDefaultButton.Size = new System.Drawing.Size(133, 23);
            this.MCLoadDefaultButton.TabIndex = 33;
            this.MCLoadDefaultButton.Text = "Load Default";
            this.MCLoadDefaultButton.UseVisualStyleBackColor = true;
            this.MCLoadDefaultButton.Click += new System.EventHandler(this.MCLoadDefaultButton_Click);
            // 
            // MCSaveDefaultButton
            // 
            this.MCSaveDefaultButton.Location = new System.Drawing.Point(5, 119);
            this.MCSaveDefaultButton.Name = "MCSaveDefaultButton";
            this.MCSaveDefaultButton.Size = new System.Drawing.Size(133, 23);
            this.MCSaveDefaultButton.TabIndex = 32;
            this.MCSaveDefaultButton.Text = "Save Default";
            this.MCSaveDefaultButton.UseVisualStyleBackColor = true;
            this.MCSaveDefaultButton.Click += new System.EventHandler(this.MCSaveDefaultButton_Click);
            // 
            // MCExternalTrackMoveDownButton
            // 
            this.MCExternalTrackMoveDownButton.Location = new System.Drawing.Point(5, 90);
            this.MCExternalTrackMoveDownButton.Name = "MCExternalTrackMoveDownButton";
            this.MCExternalTrackMoveDownButton.Size = new System.Drawing.Size(81, 23);
            this.MCExternalTrackMoveDownButton.TabIndex = 31;
            this.MCExternalTrackMoveDownButton.Text = "Move Down";
            this.MCExternalTrackMoveDownButton.UseVisualStyleBackColor = true;
            this.MCExternalTrackMoveDownButton.Click += new System.EventHandler(this.MCTrackMoveDownButton_Click);
            // 
            // MCExternalTrackRemoveSelectedButton
            // 
            this.MCExternalTrackRemoveSelectedButton.Location = new System.Drawing.Point(5, 3);
            this.MCExternalTrackRemoveSelectedButton.Name = "MCExternalTrackRemoveSelectedButton";
            this.MCExternalTrackRemoveSelectedButton.Size = new System.Drawing.Size(133, 23);
            this.MCExternalTrackRemoveSelectedButton.TabIndex = 28;
            this.MCExternalTrackRemoveSelectedButton.Text = "Remove Selected Track";
            this.MCExternalTrackRemoveSelectedButton.UseVisualStyleBackColor = true;
            this.MCExternalTrackRemoveSelectedButton.Click += new System.EventHandler(this.MCTrackRemoveSelectedButton_Click);
            // 
            // MCExternalTrackMoveUpButton
            // 
            this.MCExternalTrackMoveUpButton.Location = new System.Drawing.Point(5, 61);
            this.MCExternalTrackMoveUpButton.Name = "MCExternalTrackMoveUpButton";
            this.MCExternalTrackMoveUpButton.Size = new System.Drawing.Size(81, 23);
            this.MCExternalTrackMoveUpButton.TabIndex = 30;
            this.MCExternalTrackMoveUpButton.Text = "Move Up";
            this.MCExternalTrackMoveUpButton.UseVisualStyleBackColor = true;
            this.MCExternalTrackMoveUpButton.Click += new System.EventHandler(this.MCTrackMoveUpButton_Click);
            // 
            // MCExternalTrackClearListButton
            // 
            this.MCExternalTrackClearListButton.Location = new System.Drawing.Point(5, 32);
            this.MCExternalTrackClearListButton.Name = "MCExternalTrackClearListButton";
            this.MCExternalTrackClearListButton.Size = new System.Drawing.Size(133, 23);
            this.MCExternalTrackClearListButton.TabIndex = 29;
            this.MCExternalTrackClearListButton.Text = "Clear List";
            this.MCExternalTrackClearListButton.UseVisualStyleBackColor = true;
            this.MCExternalTrackClearListButton.Click += new System.EventHandler(this.MCTrackClearListButton_Click);
            // 
            // MCDataGridView
            // 
            this.MCDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MCDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MCDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.MCDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MCDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MCDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MCDataGridViewType,
            this.MCPositionInOriginalFile,
            this.MCLanguageCode,
            this.MCLanguageName,
            this.MCExternalFlag,
            this.MCExtension,
            this.MCSuffix,
            this.MCDefaultFlag,
            this.MCForcedFlag});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MCDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.MCDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.MCDataGridView.Location = new System.Drawing.Point(8, 19);
            this.MCDataGridView.MultiSelect = false;
            this.MCDataGridView.Name = "MCDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MCDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MCDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MCDataGridView.Size = new System.Drawing.Size(738, 338);
            this.MCDataGridView.TabIndex = 25;
            this.MCDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.MCDataGridView_DataError);
            // 
            // MCDataGridViewType
            // 
            this.MCDataGridViewType.DataPropertyName = "type";
            this.MCDataGridViewType.DataSource = this.typeBindingSource;
            this.MCDataGridViewType.DisplayMember = "type";
            this.MCDataGridViewType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.MCDataGridViewType.HeaderText = "Track Type";
            this.MCDataGridViewType.Name = "MCDataGridViewType";
            this.MCDataGridViewType.ToolTipText = "Track Type (Video/Audio/Subtitle)";
            this.MCDataGridViewType.ValueMember = "type";
            this.MCDataGridViewType.Width = 68;
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataSource = typeof(MKVmergeBatcher.src.obj.UserData.ModelCreator.Type);
            // 
            // MCPositionInOriginalFile
            // 
            this.MCPositionInOriginalFile.DataPropertyName = "position";
            dataGridViewCellStyle2.NullValue = null;
            this.MCPositionInOriginalFile.DefaultCellStyle = dataGridViewCellStyle2;
            this.MCPositionInOriginalFile.HeaderText = "Position";
            this.MCPositionInOriginalFile.Name = "MCPositionInOriginalFile";
            this.MCPositionInOriginalFile.ToolTipText = "Position of track in files. Format F:P. F is file number starting from 0. File 0 " +
    "is original file. Additional file are external files. P is track position in rel" +
    "ated file starting from 0.";
            this.MCPositionInOriginalFile.Width = 69;
            // 
            // MCLanguageCode
            // 
            this.MCLanguageCode.DataPropertyName = "languageCode";
            this.MCLanguageCode.HeaderText = "Language Code";
            this.MCLanguageCode.Name = "MCLanguageCode";
            this.MCLanguageCode.ToolTipText = "Language Code for mkvmerge (ex. und/eng/ita)";
            this.MCLanguageCode.Width = 108;
            // 
            // MCLanguageName
            // 
            this.MCLanguageName.DataPropertyName = "languageName";
            this.MCLanguageName.HeaderText = "Language Name";
            this.MCLanguageName.Name = "MCLanguageName";
            this.MCLanguageName.ToolTipText = "Language name for destination file";
            this.MCLanguageName.Width = 111;
            // 
            // MCExternalFlag
            // 
            this.MCExternalFlag.DataPropertyName = "externalFlag";
            this.MCExternalFlag.HeaderText = "External";
            this.MCExternalFlag.Name = "MCExternalFlag";
            this.MCExternalFlag.ToolTipText = "Mark the track as external file. With custom suffix and extension";
            this.MCExternalFlag.Width = 51;
            // 
            // MCExtension
            // 
            this.MCExtension.DataPropertyName = "extension";
            this.MCExtension.HeaderText = "Extension";
            this.MCExtension.Name = "MCExtension";
            this.MCExtension.ToolTipText = "Extension of external files (the file must have same file name as base file)";
            this.MCExtension.Width = 78;
            // 
            // MCSuffix
            // 
            this.MCSuffix.DataPropertyName = "suffix";
            this.MCSuffix.HeaderText = "Suffix";
            this.MCSuffix.Name = "MCSuffix";
            this.MCSuffix.ToolTipText = "Suffix for external file";
            this.MCSuffix.Width = 58;
            // 
            // MCDefaultFlag
            // 
            this.MCDefaultFlag.DataPropertyName = "defaultFlag";
            this.MCDefaultFlag.HeaderText = "Default";
            this.MCDefaultFlag.Name = "MCDefaultFlag";
            this.MCDefaultFlag.Width = 47;
            // 
            // MCForcedFlag
            // 
            this.MCForcedFlag.DataPropertyName = "forcedFlag";
            this.MCForcedFlag.HeaderText = "Forced";
            this.MCForcedFlag.Name = "MCForcedFlag";
            this.MCForcedFlag.Width = 46;
            // 
            // MCPreviewButton
            // 
            this.MCPreviewButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MCPreviewButton.Location = new System.Drawing.Point(0, 460);
            this.MCPreviewButton.Name = "MCPreviewButton";
            this.MCPreviewButton.Size = new System.Drawing.Size(916, 21);
            this.MCPreviewButton.TabIndex = 24;
            this.MCPreviewButton.Text = "Preview";
            this.MCPreviewButton.UseVisualStyleBackColor = true;
            this.MCPreviewButton.Click += new System.EventHandler(this.MCPreviewButton_Click);
            // 
            // tabQueue
            // 
            this.tabQueue.Controls.Add(this.QAutoClearErrorJobsCheckBox);
            this.tabQueue.Controls.Add(this.QAutoClearWarningJobsCheckBox);
            this.tabQueue.Controls.Add(this.QAutoClearOkJobsCheckBox);
            this.tabQueue.Controls.Add(this.QRemoveErrorButton);
            this.tabQueue.Controls.Add(this.QRemoveWarningButton);
            this.tabQueue.Controls.Add(this.QRemoveOkButton);
            this.tabQueue.Controls.Add(this.QExecNowButton);
            this.tabQueue.Controls.Add(this.QCreateBatButton);
            this.tabQueue.Controls.Add(this.QClearQueueButton);
            this.tabQueue.Controls.Add(this.QRemoveFromQueueButton);
            this.tabQueue.Controls.Add(this.QDataGridView);
            this.tabQueue.Location = new System.Drawing.Point(4, 22);
            this.tabQueue.Name = "tabQueue";
            this.tabQueue.Padding = new System.Windows.Forms.Padding(3);
            this.tabQueue.Size = new System.Drawing.Size(916, 481);
            this.tabQueue.TabIndex = 4;
            this.tabQueue.Text = "Queue";
            this.tabQueue.UseVisualStyleBackColor = true;
            // 
            // QAutoClearErrorJobsCheckBox
            // 
            this.QAutoClearErrorJobsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QAutoClearErrorJobsCheckBox.AutoSize = true;
            this.QAutoClearErrorJobsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.additionalFlagsBindingSource, "autoClearErrorJobs", true));
            this.QAutoClearErrorJobsCheckBox.Location = new System.Drawing.Point(777, 269);
            this.QAutoClearErrorJobsCheckBox.Name = "QAutoClearErrorJobsCheckBox";
            this.QAutoClearErrorJobsCheckBox.Size = new System.Drawing.Size(125, 17);
            this.QAutoClearErrorJobsCheckBox.TabIndex = 38;
            this.QAutoClearErrorJobsCheckBox.Text = "Auto Clear Error Jobs";
            this.QAutoClearErrorJobsCheckBox.UseVisualStyleBackColor = true;
            // 
            // QAutoClearWarningJobsCheckBox
            // 
            this.QAutoClearWarningJobsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QAutoClearWarningJobsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.additionalFlagsBindingSource, "autoClearWarningJobs", true));
            this.QAutoClearWarningJobsCheckBox.Location = new System.Drawing.Point(777, 232);
            this.QAutoClearWarningJobsCheckBox.Name = "QAutoClearWarningJobsCheckBox";
            this.QAutoClearWarningJobsCheckBox.Size = new System.Drawing.Size(131, 31);
            this.QAutoClearWarningJobsCheckBox.TabIndex = 37;
            this.QAutoClearWarningJobsCheckBox.Text = "Auto Clear Warning Jobs";
            this.QAutoClearWarningJobsCheckBox.UseVisualStyleBackColor = true;
            // 
            // QAutoClearOkJobsCheckBox
            // 
            this.QAutoClearOkJobsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QAutoClearOkJobsCheckBox.AutoSize = true;
            this.QAutoClearOkJobsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.additionalFlagsBindingSource, "autoClearOkJobs", true));
            this.QAutoClearOkJobsCheckBox.Location = new System.Drawing.Point(777, 209);
            this.QAutoClearOkJobsCheckBox.Name = "QAutoClearOkJobsCheckBox";
            this.QAutoClearOkJobsCheckBox.Size = new System.Drawing.Size(117, 17);
            this.QAutoClearOkJobsCheckBox.TabIndex = 36;
            this.QAutoClearOkJobsCheckBox.Text = "Auto Clear Ok Jobs";
            this.QAutoClearOkJobsCheckBox.UseVisualStyleBackColor = true;
            // 
            // QRemoveErrorButton
            // 
            this.QRemoveErrorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QRemoveErrorButton.Location = new System.Drawing.Point(777, 180);
            this.QRemoveErrorButton.Name = "QRemoveErrorButton";
            this.QRemoveErrorButton.Size = new System.Drawing.Size(131, 23);
            this.QRemoveErrorButton.TabIndex = 35;
            this.QRemoveErrorButton.Text = "Remove Error jobs";
            this.QRemoveErrorButton.UseVisualStyleBackColor = true;
            this.QRemoveErrorButton.Click += new System.EventHandler(this.QRemoveErrorButton_Click);
            // 
            // QRemoveWarningButton
            // 
            this.QRemoveWarningButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QRemoveWarningButton.Location = new System.Drawing.Point(777, 151);
            this.QRemoveWarningButton.Name = "QRemoveWarningButton";
            this.QRemoveWarningButton.Size = new System.Drawing.Size(131, 23);
            this.QRemoveWarningButton.TabIndex = 34;
            this.QRemoveWarningButton.Text = "Remove Warning jobs";
            this.QRemoveWarningButton.UseVisualStyleBackColor = true;
            this.QRemoveWarningButton.Click += new System.EventHandler(this.QRemoveWarningButton_Click);
            // 
            // QRemoveOkButton
            // 
            this.QRemoveOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QRemoveOkButton.Location = new System.Drawing.Point(777, 122);
            this.QRemoveOkButton.Name = "QRemoveOkButton";
            this.QRemoveOkButton.Size = new System.Drawing.Size(131, 23);
            this.QRemoveOkButton.TabIndex = 33;
            this.QRemoveOkButton.Text = "Remove OK jobs";
            this.QRemoveOkButton.UseVisualStyleBackColor = true;
            this.QRemoveOkButton.Click += new System.EventHandler(this.QRemoveOkButton_Click);
            // 
            // QExecNowButton
            // 
            this.QExecNowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QExecNowButton.Location = new System.Drawing.Point(777, 93);
            this.QExecNowButton.Name = "QExecNowButton";
            this.QExecNowButton.Size = new System.Drawing.Size(131, 23);
            this.QExecNowButton.TabIndex = 32;
            this.QExecNowButton.Text = "Exec Now";
            this.QExecNowButton.UseVisualStyleBackColor = true;
            this.QExecNowButton.Click += new System.EventHandler(this.QExecNowButton_Click);
            // 
            // QCreateBatButton
            // 
            this.QCreateBatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QCreateBatButton.Location = new System.Drawing.Point(777, 64);
            this.QCreateBatButton.Name = "QCreateBatButton";
            this.QCreateBatButton.Size = new System.Drawing.Size(131, 23);
            this.QCreateBatButton.TabIndex = 31;
            this.QCreateBatButton.Text = "Create BAT";
            this.QCreateBatButton.UseVisualStyleBackColor = true;
            this.QCreateBatButton.Click += new System.EventHandler(this.QCreateBatButton_Click);
            // 
            // QClearQueueButton
            // 
            this.QClearQueueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QClearQueueButton.Location = new System.Drawing.Point(777, 35);
            this.QClearQueueButton.Name = "QClearQueueButton";
            this.QClearQueueButton.Size = new System.Drawing.Size(133, 23);
            this.QClearQueueButton.TabIndex = 30;
            this.QClearQueueButton.Text = "Clear Queue";
            this.QClearQueueButton.UseVisualStyleBackColor = true;
            this.QClearQueueButton.Click += new System.EventHandler(this.QClearQueueButton_Click);
            // 
            // QRemoveFromQueueButton
            // 
            this.QRemoveFromQueueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QRemoveFromQueueButton.Location = new System.Drawing.Point(777, 6);
            this.QRemoveFromQueueButton.Name = "QRemoveFromQueueButton";
            this.QRemoveFromQueueButton.Size = new System.Drawing.Size(133, 23);
            this.QRemoveFromQueueButton.TabIndex = 29;
            this.QRemoveFromQueueButton.Text = "Remove From Queue";
            this.QRemoveFromQueueButton.UseVisualStyleBackColor = true;
            this.QRemoveFromQueueButton.Click += new System.EventHandler(this.QRemoveFromQueueButton_Click);
            // 
            // QDataGridView
            // 
            this.QDataGridView.AllowUserToAddRows = false;
            this.QDataGridView.AllowUserToDeleteRows = false;
            this.QDataGridView.AllowUserToResizeColumns = false;
            this.QDataGridView.AllowUserToResizeRows = false;
            this.QDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QDataGridView.AutoGenerateColumns = false;
            this.QDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.QDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.QDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn,
            this.jobStatus,
            this.modelIndexDataGridViewTextBoxColumn});
            this.QDataGridView.DataSource = this.queueBindingSource;
            this.QDataGridView.Location = new System.Drawing.Point(0, 0);
            this.QDataGridView.Name = "QDataGridView";
            this.QDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.QDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QDataGridView.Size = new System.Drawing.Size(771, 481);
            this.QDataGridView.TabIndex = 0;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "fileName";
            this.fileNameDataGridViewTextBoxColumn.FillWeight = 250F;
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "File";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "modelName";
            this.modelNameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "Choosen Model";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            this.modelNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobStatus
            // 
            this.jobStatus.DataPropertyName = "jobStatus";
            this.jobStatus.FillWeight = 60F;
            this.jobStatus.HeaderText = "Job Status";
            this.jobStatus.Name = "jobStatus";
            this.jobStatus.ReadOnly = true;
            // 
            // modelIndexDataGridViewTextBoxColumn
            // 
            this.modelIndexDataGridViewTextBoxColumn.DataPropertyName = "modelIndex";
            this.modelIndexDataGridViewTextBoxColumn.HeaderText = "modelIndex";
            this.modelIndexDataGridViewTextBoxColumn.Name = "modelIndexDataGridViewTextBoxColumn";
            this.modelIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelIndexDataGridViewTextBoxColumn.Visible = false;
            // 
            // queueBindingSource
            // 
            this.queueBindingSource.DataSource = typeof(MKVmergeBatcher.src.obj.UserData.QueueManagement.Queue);
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.ODeleteIncompleteFileCheckBox);
            this.tabOptions.Controls.Add(this.OReplaceExistingDestinationFileCheckBox);
            this.tabOptions.Controls.Add(this.OMoveWarningFilesTextBox);
            this.tabOptions.Controls.Add(this.label1);
            this.tabOptions.Controls.Add(this.OMoveOkFilesTextBox);
            this.tabOptions.Controls.Add(this.OMoveOkFilesLabel);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(916, 481);
            this.tabOptions.TabIndex = 5;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // ODeleteIncompleteFileCheckBox
            // 
            this.ODeleteIncompleteFileCheckBox.AutoSize = true;
            this.ODeleteIncompleteFileCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.optionsBindingSource, "deleteIncompleteFile", true));
            this.ODeleteIncompleteFileCheckBox.Location = new System.Drawing.Point(197, 59);
            this.ODeleteIncompleteFileCheckBox.Name = "ODeleteIncompleteFileCheckBox";
            this.ODeleteIncompleteFileCheckBox.Size = new System.Drawing.Size(138, 17);
            this.ODeleteIncompleteFileCheckBox.TabIndex = 7;
            this.ODeleteIncompleteFileCheckBox.Text = "Delete incomplete files?";
            this.ODeleteIncompleteFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // optionsBindingSource
            // 
            this.optionsBindingSource.DataSource = typeof(MKVmergeBatcher.src.obj.UserData.Options);
            // 
            // OReplaceExistingDestinationFileCheckBox
            // 
            this.OReplaceExistingDestinationFileCheckBox.AutoSize = true;
            this.OReplaceExistingDestinationFileCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.optionsBindingSource, "replaceExistingDestinationFile", true));
            this.OReplaceExistingDestinationFileCheckBox.Location = new System.Drawing.Point(6, 59);
            this.OReplaceExistingDestinationFileCheckBox.Name = "OReplaceExistingDestinationFileCheckBox";
            this.OReplaceExistingDestinationFileCheckBox.Size = new System.Drawing.Size(185, 17);
            this.OReplaceExistingDestinationFileCheckBox.TabIndex = 6;
            this.OReplaceExistingDestinationFileCheckBox.Text = "Replace existing destination files?";
            this.OReplaceExistingDestinationFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // OMoveWarningFilesTextBox
            // 
            this.OMoveWarningFilesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OMoveWarningFilesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.optionsBindingSource, "moveWarningFilesTo", true));
            this.OMoveWarningFilesTextBox.Location = new System.Drawing.Point(124, 29);
            this.OMoveWarningFilesTextBox.Name = "OMoveWarningFilesTextBox";
            this.OMoveWarningFilesTextBox.Size = new System.Drawing.Size(784, 20);
            this.OMoveWarningFilesTextBox.TabIndex = 5;
            this.OToolTip.SetToolTip(this.OMoveWarningFilesTextBox, "Specify the directory where the ok files are moved. Can be specified only a folde" +
        "r name like WarningFiles");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Move Warning Files to:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OMoveOkFilesTextBox
            // 
            this.OMoveOkFilesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OMoveOkFilesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.optionsBindingSource, "moveOkFilesTo", true));
            this.OMoveOkFilesTextBox.Location = new System.Drawing.Point(124, 3);
            this.OMoveOkFilesTextBox.Name = "OMoveOkFilesTextBox";
            this.OMoveOkFilesTextBox.Size = new System.Drawing.Size(784, 20);
            this.OMoveOkFilesTextBox.TabIndex = 3;
            this.OToolTip.SetToolTip(this.OMoveOkFilesTextBox, "Specify the directory where the ok files are moved. Can be specified only a folde" +
        "r name like OkFiles");
            // 
            // OMoveOkFilesLabel
            // 
            this.OMoveOkFilesLabel.Location = new System.Drawing.Point(3, 6);
            this.OMoveOkFilesLabel.Name = "OMoveOkFilesLabel";
            this.OMoveOkFilesLabel.Size = new System.Drawing.Size(115, 17);
            this.OMoveOkFilesLabel.TabIndex = 2;
            this.OMoveOkFilesLabel.Text = "Move Ok Files to:";
            this.OMoveOkFilesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.aboutTextBox);
            this.tabHelp.Location = new System.Drawing.Point(4, 22);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelp.Size = new System.Drawing.Size(916, 481);
            this.tabHelp.TabIndex = 3;
            this.tabHelp.Text = "Help";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.BulletIndent = 1;
            this.aboutTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTextBox.Location = new System.Drawing.Point(3, 3);
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.Size = new System.Drawing.Size(910, 475);
            this.aboutTextBox.TabIndex = 1;
            this.aboutTextBox.Text = resources.GetString("aboutTextBox.Text");
            // 
            // tracksBindingSource
            // 
            this.tracksBindingSource.DataSource = typeof(MKVmergeBatcher.src.obj.UserData.ModelCreator.Tracks);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // modelCreatorBindingSource
            // 
            this.modelCreatorBindingSource.DataSource = typeof(MKVmergeBatcher.src.obj.UserData.ModelCreator);
            // 
            // modelManagementBindingSource
            // 
            this.modelManagementBindingSource.DataSource = typeof(MKVmergeBatcher.src.obj.UserData.ModelManagement);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 531);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(940, 570);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MKVmerge Batcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.tabControl1.ResumeLayout(false);
            this.tabBatcher.ResumeLayout(false);
            this.tabBatcher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.BTCVideoFilesListContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.batcherBindingSource)).EndInit();
            this.tabManageModels.ResumeLayout(false);
            this.tabManageModels.PerformLayout();
            this.tabModelCreator.ResumeLayout(false);
            this.additionalFlagsGroupBox.ResumeLayout(false);
            this.additionalFlagsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.additionalFlagsBindingSource)).EndInit();
            this.tracksGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MCDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            this.tabQueue.ResumeLayout(false);
            this.tabQueue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueBindingSource)).EndInit();
            this.tabOptions.ResumeLayout(false);
            this.tabOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsBindingSource)).EndInit();
            this.tabHelp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tracksBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelCreatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelManagementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBatcher;
        private System.Windows.Forms.TabPage tabManageModels;
        private System.Windows.Forms.TabPage tabModelCreator;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button MCPreviewButton;
        private System.Windows.Forms.GroupBox tracksGroupBox;
        private System.Windows.Forms.Button MCExternalTrackClearListButton;
        private System.Windows.Forms.Button MCExternalTrackRemoveSelectedButton;
        private System.Windows.Forms.Button MCExternalTrackMoveUpButton;
        private System.Windows.Forms.Button MCExternalTrackMoveDownButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox additionalFlagsGroupBox;
        private System.Windows.Forms.CheckBox MCNoAttachmentsCheckBox;
        private System.Windows.Forms.BindingSource additionalFlagsBindingSource;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private System.Windows.Forms.Button BTCMkvMergePathBrowseButton;
        private System.Windows.Forms.Label BTCMkvMergePathLabel;
        private System.Windows.Forms.TextBox BTCMkvMergePathTextBox;
        private System.Windows.Forms.BindingSource modelCreatorBindingSource;
        private System.Windows.Forms.Button BTCVideoBrowseButton;
        private System.Windows.Forms.TextBox BTCFilePathTextBox;
        private System.Windows.Forms.BindingSource batcherBindingSource;
        private System.Windows.Forms.TextBox BTCVideoExtensionsTextBox;
        private System.Windows.Forms.ListBox BTCVideoFilesListBox;
        private System.Windows.Forms.ContextMenuStrip BTCVideoFilesListContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem BTCReverseSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BTCCleanSelectionToolStripMenuItem;
        private System.Windows.Forms.ComboBox BTCModelsComboBox;
        private System.Windows.Forms.Button BTCCreateBatButton;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.BindingSource modelManagementBindingSource;
        private System.Windows.Forms.DataGridView MCDataGridView;
        private System.Windows.Forms.BindingSource tracksBindingSource;
        private System.Windows.Forms.Button MMSaveButton;
        private System.Windows.Forms.TextBox MMModelContentTextBox;
        private System.Windows.Forms.TextBox MMModelNameTextBox;
        private System.Windows.Forms.ListBox MMListBox;
        private System.Windows.Forms.Button MMRemoveSelectedButton;
        private System.Windows.Forms.Button MMMoveBottomButton;
        private System.Windows.Forms.Button MMMoveTopButton;
        private System.Windows.Forms.Button MMMoveDownButton;
        private System.Windows.Forms.Button MMMoveUpButton;
        private System.Windows.Forms.CheckBox MCCleanTitleCheckBox;
        private System.Windows.Forms.Button MCLoadDefaultButton;
        private System.Windows.Forms.Button MCSaveDefaultButton;
        private System.Windows.Forms.CheckBox MCDisableCompressionCheckBox;
        private System.Windows.Forms.Button BTCExectuteNowButton;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.RichTextBox aboutTextBox;
        private System.Windows.Forms.Label BTCPathLabel;
        private System.Windows.Forms.Label BTCExtensionsLabel;
        private System.Windows.Forms.DataGridViewComboBoxColumn MCDataGridViewType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCPositionInOriginalFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCLanguageCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCLanguageName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MCExternalFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCExtension;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCSuffix;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MCDefaultFlag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MCForcedFlag;
        private System.Windows.Forms.Button MMSortByModelNameButton;
        private System.Windows.Forms.CheckBox MCAddAttachmentsCheckBox;
        private System.Windows.Forms.ToolTip MCToolTip;
        private System.Windows.Forms.CheckBox MCAddChaptersCheckBox;
        private System.Windows.Forms.Button BTCAddToQueueButton;
        private System.Windows.Forms.TabPage tabQueue;
        private System.Windows.Forms.DataGridView QDataGridView;
        private System.Windows.Forms.BindingSource queueBindingSource;
        private System.Windows.Forms.Button QExecNowButton;
        private System.Windows.Forms.Button QCreateBatButton;
        private System.Windows.Forms.Button QClearQueueButton;
        private System.Windows.Forms.Button QRemoveFromQueueButton;
        private System.Windows.Forms.Button QRemoveOkButton;
        private System.Windows.Forms.Button BTCClearQueueButton;
        private System.Windows.Forms.Button QRemoveWarningButton;
        private System.Windows.Forms.Button QRemoveErrorButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox QAutoClearOkJobsCheckBox;
        private System.Windows.Forms.CheckBox QAutoClearErrorJobsCheckBox;
        private System.Windows.Forms.CheckBox QAutoClearWarningJobsCheckBox;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.TextBox OMoveOkFilesTextBox;
        private System.Windows.Forms.Label OMoveOkFilesLabel;
        private System.Windows.Forms.TextBox OMoveWarningFilesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource optionsBindingSource;
        private System.Windows.Forms.ToolTip OToolTip;
        private System.Windows.Forms.CheckBox OReplaceExistingDestinationFileCheckBox;
        private System.Windows.Forms.CheckBox ODeleteIncompleteFileCheckBox;
    }
}

