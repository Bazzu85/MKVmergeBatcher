
namespace MKVmergeBatcher.src.models
{
    partial class ModelsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.modelsListBox = new System.Windows.Forms.ListBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelsDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelGroupBox = new System.Windows.Forms.GroupBox();
            this.editModelButton = new System.Windows.Forms.Button();
            this.modelNameTextBox = new System.Windows.Forms.TextBox();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.customCommandCheckBox = new System.Windows.Forms.CheckBox();
            this.customOutputFilesArgumentsGroupBox = new System.Windows.Forms.GroupBox();
            this.customOutputFileArgumentsTextBox = new System.Windows.Forms.TextBox();
            this.customOutputFileArgumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addChaptersCheckBox = new System.Windows.Forms.CheckBox();
            this.addAttachmentsCheckBox = new System.Windows.Forms.CheckBox();
            this.emptyTitleCheckBox = new System.Windows.Forms.CheckBox();
            this.customInputFilesArgumentsGroupBox = new System.Windows.Forms.GroupBox();
            this.customInputFileArgumentsTextBox = new System.Windows.Forms.TextBox();
            this.customInputFileArgumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noTrackTagsCheckBox = new System.Windows.Forms.CheckBox();
            this.noGlobalTagsCheckBox = new System.Windows.Forms.CheckBox();
            this.noCompressionCheckBox = new System.Windows.Forms.CheckBox();
            this.noAttachmentsCheckBox = new System.Windows.Forms.CheckBox();
            this.tracksDataGridView = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalFileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalFileTrackPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.forcedFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.originalFileSuffixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalFileExtensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelNameLabel = new System.Windows.Forms.Label();
            this.modelsListButtonsPanel = new System.Windows.Forms.Panel();
            this.moveModelDownButton = new System.Windows.Forms.Button();
            this.moveModelUpButton = new System.Windows.Forms.Button();
            this.addModelButton = new System.Windows.Forms.Button();
            this.deleteModelButton = new System.Windows.Forms.Button();
            this.sortModelByNameButton = new System.Windows.Forms.Button();
            this.moveModelBottomButton = new System.Windows.Forms.Button();
            this.moveModelTopButton = new System.Windows.Forms.Button();
            this.modelsToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataBindingSource)).BeginInit();
            this.modelGroupBox.SuspendLayout();
            this.customOutputFilesArgumentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customOutputFileArgumentsBindingSource)).BeginInit();
            this.customInputFilesArgumentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customInputFileArgumentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).BeginInit();
            this.modelsListButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelsListBox
            // 
            resources.ApplyResources(this.modelsListBox, "modelsListBox");
            this.modelsListBox.DataSource = this.modelBindingSource;
            this.modelsListBox.DisplayMember = "modelName";
            this.modelsListBox.FormattingEnabled = true;
            this.modelsListBox.Name = "modelsListBox";
            this.modelsToolTip.SetToolTip(this.modelsListBox, resources.GetString("modelsListBox.ToolTip"));
            this.modelsListBox.SelectedIndexChanged += new System.EventHandler(this.modelsListBox_SelectedIndexChanged);
            this.modelsListBox.DoubleClick += new System.EventHandler(this.modelsListBox_DoubleClick);
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(MKVmergeBatcher.src.models.ModelsData.Model);
            // 
            // modelsDataBindingSource
            // 
            this.modelsDataBindingSource.DataSource = typeof(MKVmergeBatcher.src.models.ModelsData);
            // 
            // modelGroupBox
            // 
            resources.ApplyResources(this.modelGroupBox, "modelGroupBox");
            this.modelGroupBox.Controls.Add(this.editModelButton);
            this.modelGroupBox.Controls.Add(this.modelNameTextBox);
            this.modelGroupBox.Controls.Add(this.commandTextBox);
            this.modelGroupBox.Controls.Add(this.customCommandCheckBox);
            this.modelGroupBox.Controls.Add(this.customOutputFilesArgumentsGroupBox);
            this.modelGroupBox.Controls.Add(this.customInputFilesArgumentsGroupBox);
            this.modelGroupBox.Controls.Add(this.tracksDataGridView);
            this.modelGroupBox.Controls.Add(this.modelNameLabel);
            this.modelGroupBox.Name = "modelGroupBox";
            this.modelGroupBox.TabStop = false;
            this.modelsToolTip.SetToolTip(this.modelGroupBox, resources.GetString("modelGroupBox.ToolTip"));
            // 
            // editModelButton
            // 
            resources.ApplyResources(this.editModelButton, "editModelButton");
            this.editModelButton.Name = "editModelButton";
            this.modelsToolTip.SetToolTip(this.editModelButton, resources.GetString("editModelButton.ToolTip"));
            this.editModelButton.UseVisualStyleBackColor = true;
            this.editModelButton.Click += new System.EventHandler(this.editModelButton_Click);
            // 
            // modelNameTextBox
            // 
            resources.ApplyResources(this.modelNameTextBox, "modelNameTextBox");
            this.modelNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "modelName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.modelNameTextBox.Name = "modelNameTextBox";
            this.modelNameTextBox.ReadOnly = true;
            this.modelsToolTip.SetToolTip(this.modelNameTextBox, resources.GetString("modelNameTextBox.ToolTip"));
            // 
            // commandTextBox
            // 
            resources.ApplyResources(this.commandTextBox, "commandTextBox");
            this.commandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "command", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.ReadOnly = true;
            this.modelsToolTip.SetToolTip(this.commandTextBox, resources.GetString("commandTextBox.ToolTip"));
            // 
            // customCommandCheckBox
            // 
            resources.ApplyResources(this.customCommandCheckBox, "customCommandCheckBox");
            this.customCommandCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.modelBindingSource, "customCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.customCommandCheckBox.Name = "customCommandCheckBox";
            this.modelsToolTip.SetToolTip(this.customCommandCheckBox, resources.GetString("customCommandCheckBox.ToolTip"));
            this.customCommandCheckBox.UseVisualStyleBackColor = true;
            // 
            // customOutputFilesArgumentsGroupBox
            // 
            resources.ApplyResources(this.customOutputFilesArgumentsGroupBox, "customOutputFilesArgumentsGroupBox");
            this.customOutputFilesArgumentsGroupBox.Controls.Add(this.customOutputFileArgumentsTextBox);
            this.customOutputFilesArgumentsGroupBox.Controls.Add(this.addChaptersCheckBox);
            this.customOutputFilesArgumentsGroupBox.Controls.Add(this.addAttachmentsCheckBox);
            this.customOutputFilesArgumentsGroupBox.Controls.Add(this.emptyTitleCheckBox);
            this.customOutputFilesArgumentsGroupBox.Name = "customOutputFilesArgumentsGroupBox";
            this.customOutputFilesArgumentsGroupBox.TabStop = false;
            this.modelsToolTip.SetToolTip(this.customOutputFilesArgumentsGroupBox, resources.GetString("customOutputFilesArgumentsGroupBox.ToolTip"));
            // 
            // customOutputFileArgumentsTextBox
            // 
            resources.ApplyResources(this.customOutputFileArgumentsTextBox, "customOutputFileArgumentsTextBox");
            this.customOutputFileArgumentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customOutputFileArgumentsBindingSource, "text", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.customOutputFileArgumentsTextBox.Name = "customOutputFileArgumentsTextBox";
            this.customOutputFileArgumentsTextBox.ReadOnly = true;
            this.modelsToolTip.SetToolTip(this.customOutputFileArgumentsTextBox, resources.GetString("customOutputFileArgumentsTextBox.ToolTip"));
            // 
            // customOutputFileArgumentsBindingSource
            // 
            this.customOutputFileArgumentsBindingSource.DataSource = typeof(MKVmergeBatcher.src.models.ModelsData.Model.CustomOutputFileArguments);
            // 
            // addChaptersCheckBox
            // 
            resources.ApplyResources(this.addChaptersCheckBox, "addChaptersCheckBox");
            this.addChaptersCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customOutputFileArgumentsBindingSource, "addChapters", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addChaptersCheckBox.Name = "addChaptersCheckBox";
            this.modelsToolTip.SetToolTip(this.addChaptersCheckBox, resources.GetString("addChaptersCheckBox.ToolTip"));
            this.addChaptersCheckBox.UseVisualStyleBackColor = true;
            // 
            // addAttachmentsCheckBox
            // 
            resources.ApplyResources(this.addAttachmentsCheckBox, "addAttachmentsCheckBox");
            this.addAttachmentsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customOutputFileArgumentsBindingSource, "addAttachments", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addAttachmentsCheckBox.Name = "addAttachmentsCheckBox";
            this.modelsToolTip.SetToolTip(this.addAttachmentsCheckBox, resources.GetString("addAttachmentsCheckBox.ToolTip"));
            this.addAttachmentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // emptyTitleCheckBox
            // 
            resources.ApplyResources(this.emptyTitleCheckBox, "emptyTitleCheckBox");
            this.emptyTitleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customOutputFileArgumentsBindingSource, "emptyTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.emptyTitleCheckBox.Name = "emptyTitleCheckBox";
            this.modelsToolTip.SetToolTip(this.emptyTitleCheckBox, resources.GetString("emptyTitleCheckBox.ToolTip"));
            this.emptyTitleCheckBox.UseVisualStyleBackColor = true;
            // 
            // customInputFilesArgumentsGroupBox
            // 
            resources.ApplyResources(this.customInputFilesArgumentsGroupBox, "customInputFilesArgumentsGroupBox");
            this.customInputFilesArgumentsGroupBox.Controls.Add(this.customInputFileArgumentsTextBox);
            this.customInputFilesArgumentsGroupBox.Controls.Add(this.noTrackTagsCheckBox);
            this.customInputFilesArgumentsGroupBox.Controls.Add(this.noGlobalTagsCheckBox);
            this.customInputFilesArgumentsGroupBox.Controls.Add(this.noCompressionCheckBox);
            this.customInputFilesArgumentsGroupBox.Controls.Add(this.noAttachmentsCheckBox);
            this.customInputFilesArgumentsGroupBox.Name = "customInputFilesArgumentsGroupBox";
            this.customInputFilesArgumentsGroupBox.TabStop = false;
            this.modelsToolTip.SetToolTip(this.customInputFilesArgumentsGroupBox, resources.GetString("customInputFilesArgumentsGroupBox.ToolTip"));
            // 
            // customInputFileArgumentsTextBox
            // 
            resources.ApplyResources(this.customInputFileArgumentsTextBox, "customInputFileArgumentsTextBox");
            this.customInputFileArgumentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customInputFileArgumentsBindingSource, "text", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.customInputFileArgumentsTextBox.Name = "customInputFileArgumentsTextBox";
            this.customInputFileArgumentsTextBox.ReadOnly = true;
            this.modelsToolTip.SetToolTip(this.customInputFileArgumentsTextBox, resources.GetString("customInputFileArgumentsTextBox.ToolTip"));
            // 
            // customInputFileArgumentsBindingSource
            // 
            this.customInputFileArgumentsBindingSource.DataSource = typeof(MKVmergeBatcher.src.models.ModelsData.Model.CustomInputFileArguments);
            // 
            // noTrackTagsCheckBox
            // 
            resources.ApplyResources(this.noTrackTagsCheckBox, "noTrackTagsCheckBox");
            this.noTrackTagsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customInputFileArgumentsBindingSource, "noTrackTags", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.noTrackTagsCheckBox.Name = "noTrackTagsCheckBox";
            this.modelsToolTip.SetToolTip(this.noTrackTagsCheckBox, resources.GetString("noTrackTagsCheckBox.ToolTip"));
            this.noTrackTagsCheckBox.UseVisualStyleBackColor = true;
            // 
            // noGlobalTagsCheckBox
            // 
            resources.ApplyResources(this.noGlobalTagsCheckBox, "noGlobalTagsCheckBox");
            this.noGlobalTagsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customInputFileArgumentsBindingSource, "noGlobalTags", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.noGlobalTagsCheckBox.Name = "noGlobalTagsCheckBox";
            this.modelsToolTip.SetToolTip(this.noGlobalTagsCheckBox, resources.GetString("noGlobalTagsCheckBox.ToolTip"));
            this.noGlobalTagsCheckBox.UseVisualStyleBackColor = true;
            // 
            // noCompressionCheckBox
            // 
            resources.ApplyResources(this.noCompressionCheckBox, "noCompressionCheckBox");
            this.noCompressionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customInputFileArgumentsBindingSource, "noCompression", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.noCompressionCheckBox.Name = "noCompressionCheckBox";
            this.modelsToolTip.SetToolTip(this.noCompressionCheckBox, resources.GetString("noCompressionCheckBox.ToolTip"));
            this.noCompressionCheckBox.UseVisualStyleBackColor = true;
            // 
            // noAttachmentsCheckBox
            // 
            resources.ApplyResources(this.noAttachmentsCheckBox, "noAttachmentsCheckBox");
            this.noAttachmentsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customInputFileArgumentsBindingSource, "noAttachments", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.noAttachmentsCheckBox.Name = "noAttachmentsCheckBox";
            this.modelsToolTip.SetToolTip(this.noAttachmentsCheckBox, resources.GetString("noAttachmentsCheckBox.ToolTip"));
            this.noAttachmentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // tracksDataGridView
            // 
            resources.ApplyResources(this.tracksDataGridView, "tracksDataGridView");
            this.tracksDataGridView.AllowUserToAddRows = false;
            this.tracksDataGridView.AllowUserToDeleteRows = false;
            this.tracksDataGridView.AutoGenerateColumns = false;
            this.tracksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tracksDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tracksDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tracksDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tracksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tracksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tracksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.originalFileNumberDataGridViewTextBoxColumn,
            this.originalFileTrackPositionDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.defaultFlagDataGridViewCheckBoxColumn,
            this.forcedFlagDataGridViewCheckBoxColumn,
            this.originalFileSuffixDataGridViewTextBoxColumn,
            this.originalFileExtensionDataGridViewTextBoxColumn});
            this.tracksDataGridView.DataSource = this.trackBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tracksDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.tracksDataGridView.EnableHeadersVisualStyles = false;
            this.tracksDataGridView.MultiSelect = false;
            this.tracksDataGridView.Name = "tracksDataGridView";
            this.tracksDataGridView.ReadOnly = true;
            this.tracksDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tracksDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tracksDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.tracksDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.tracksDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.tracksDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tracksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modelsToolTip.SetToolTip(this.tracksDataGridView, resources.GetString("tracksDataGridView.ToolTip"));
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            resources.ApplyResources(this.typeDataGridViewTextBoxColumn, "typeDataGridViewTextBoxColumn");
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originalFileNumberDataGridViewTextBoxColumn
            // 
            this.originalFileNumberDataGridViewTextBoxColumn.DataPropertyName = "originalFileNumber";
            resources.ApplyResources(this.originalFileNumberDataGridViewTextBoxColumn, "originalFileNumberDataGridViewTextBoxColumn");
            this.originalFileNumberDataGridViewTextBoxColumn.Name = "originalFileNumberDataGridViewTextBoxColumn";
            this.originalFileNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originalFileTrackPositionDataGridViewTextBoxColumn
            // 
            this.originalFileTrackPositionDataGridViewTextBoxColumn.DataPropertyName = "originalFileTrackPosition";
            resources.ApplyResources(this.originalFileTrackPositionDataGridViewTextBoxColumn, "originalFileTrackPositionDataGridViewTextBoxColumn");
            this.originalFileTrackPositionDataGridViewTextBoxColumn.Name = "originalFileTrackPositionDataGridViewTextBoxColumn";
            this.originalFileTrackPositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "language";
            resources.ApplyResources(this.languageDataGridViewTextBoxColumn, "languageDataGridViewTextBoxColumn");
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            this.languageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defaultFlagDataGridViewCheckBoxColumn
            // 
            this.defaultFlagDataGridViewCheckBoxColumn.DataPropertyName = "DefaultFlag";
            resources.ApplyResources(this.defaultFlagDataGridViewCheckBoxColumn, "defaultFlagDataGridViewCheckBoxColumn");
            this.defaultFlagDataGridViewCheckBoxColumn.Name = "defaultFlagDataGridViewCheckBoxColumn";
            this.defaultFlagDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // forcedFlagDataGridViewCheckBoxColumn
            // 
            this.forcedFlagDataGridViewCheckBoxColumn.DataPropertyName = "ForcedFlag";
            resources.ApplyResources(this.forcedFlagDataGridViewCheckBoxColumn, "forcedFlagDataGridViewCheckBoxColumn");
            this.forcedFlagDataGridViewCheckBoxColumn.Name = "forcedFlagDataGridViewCheckBoxColumn";
            this.forcedFlagDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // originalFileSuffixDataGridViewTextBoxColumn
            // 
            this.originalFileSuffixDataGridViewTextBoxColumn.DataPropertyName = "originalFileSuffix";
            resources.ApplyResources(this.originalFileSuffixDataGridViewTextBoxColumn, "originalFileSuffixDataGridViewTextBoxColumn");
            this.originalFileSuffixDataGridViewTextBoxColumn.Name = "originalFileSuffixDataGridViewTextBoxColumn";
            this.originalFileSuffixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originalFileExtensionDataGridViewTextBoxColumn
            // 
            this.originalFileExtensionDataGridViewTextBoxColumn.DataPropertyName = "originalFileExtension";
            resources.ApplyResources(this.originalFileExtensionDataGridViewTextBoxColumn, "originalFileExtensionDataGridViewTextBoxColumn");
            this.originalFileExtensionDataGridViewTextBoxColumn.Name = "originalFileExtensionDataGridViewTextBoxColumn";
            this.originalFileExtensionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trackBindingSource
            // 
            this.trackBindingSource.DataSource = typeof(MKVmergeBatcher.src.models.ModelsData.Model.Track);
            // 
            // modelNameLabel
            // 
            resources.ApplyResources(this.modelNameLabel, "modelNameLabel");
            this.modelNameLabel.Name = "modelNameLabel";
            this.modelsToolTip.SetToolTip(this.modelNameLabel, resources.GetString("modelNameLabel.ToolTip"));
            // 
            // modelsListButtonsPanel
            // 
            resources.ApplyResources(this.modelsListButtonsPanel, "modelsListButtonsPanel");
            this.modelsListButtonsPanel.Controls.Add(this.moveModelDownButton);
            this.modelsListButtonsPanel.Controls.Add(this.moveModelUpButton);
            this.modelsListButtonsPanel.Controls.Add(this.addModelButton);
            this.modelsListButtonsPanel.Controls.Add(this.deleteModelButton);
            this.modelsListButtonsPanel.Controls.Add(this.sortModelByNameButton);
            this.modelsListButtonsPanel.Controls.Add(this.moveModelBottomButton);
            this.modelsListButtonsPanel.Controls.Add(this.moveModelTopButton);
            this.modelsListButtonsPanel.Name = "modelsListButtonsPanel";
            this.modelsToolTip.SetToolTip(this.modelsListButtonsPanel, resources.GetString("modelsListButtonsPanel.ToolTip"));
            // 
            // moveModelDownButton
            // 
            resources.ApplyResources(this.moveModelDownButton, "moveModelDownButton");
            this.moveModelDownButton.Name = "moveModelDownButton";
            this.modelsToolTip.SetToolTip(this.moveModelDownButton, resources.GetString("moveModelDownButton.ToolTip"));
            this.moveModelDownButton.UseVisualStyleBackColor = true;
            this.moveModelDownButton.Click += new System.EventHandler(this.moveModelDownButton_Click);
            // 
            // moveModelUpButton
            // 
            resources.ApplyResources(this.moveModelUpButton, "moveModelUpButton");
            this.moveModelUpButton.Name = "moveModelUpButton";
            this.modelsToolTip.SetToolTip(this.moveModelUpButton, resources.GetString("moveModelUpButton.ToolTip"));
            this.moveModelUpButton.UseVisualStyleBackColor = true;
            this.moveModelUpButton.Click += new System.EventHandler(this.moveModelUpButton_Click);
            // 
            // addModelButton
            // 
            resources.ApplyResources(this.addModelButton, "addModelButton");
            this.addModelButton.Name = "addModelButton";
            this.modelsToolTip.SetToolTip(this.addModelButton, resources.GetString("addModelButton.ToolTip"));
            this.addModelButton.UseVisualStyleBackColor = true;
            this.addModelButton.Click += new System.EventHandler(this.addModelButton_Click);
            // 
            // deleteModelButton
            // 
            resources.ApplyResources(this.deleteModelButton, "deleteModelButton");
            this.deleteModelButton.Name = "deleteModelButton";
            this.modelsToolTip.SetToolTip(this.deleteModelButton, resources.GetString("deleteModelButton.ToolTip"));
            this.deleteModelButton.UseVisualStyleBackColor = true;
            this.deleteModelButton.Click += new System.EventHandler(this.deleteModelButton_Click);
            // 
            // sortModelByNameButton
            // 
            resources.ApplyResources(this.sortModelByNameButton, "sortModelByNameButton");
            this.sortModelByNameButton.Name = "sortModelByNameButton";
            this.modelsToolTip.SetToolTip(this.sortModelByNameButton, resources.GetString("sortModelByNameButton.ToolTip"));
            this.sortModelByNameButton.UseVisualStyleBackColor = true;
            this.sortModelByNameButton.Click += new System.EventHandler(this.sortModelByNameButton_Click);
            // 
            // moveModelBottomButton
            // 
            resources.ApplyResources(this.moveModelBottomButton, "moveModelBottomButton");
            this.moveModelBottomButton.Name = "moveModelBottomButton";
            this.modelsToolTip.SetToolTip(this.moveModelBottomButton, resources.GetString("moveModelBottomButton.ToolTip"));
            this.moveModelBottomButton.UseVisualStyleBackColor = true;
            this.moveModelBottomButton.Click += new System.EventHandler(this.moveModelBottomButton_Click);
            // 
            // moveModelTopButton
            // 
            resources.ApplyResources(this.moveModelTopButton, "moveModelTopButton");
            this.moveModelTopButton.Name = "moveModelTopButton";
            this.modelsToolTip.SetToolTip(this.moveModelTopButton, resources.GetString("moveModelTopButton.ToolTip"));
            this.moveModelTopButton.UseVisualStyleBackColor = true;
            this.moveModelTopButton.Click += new System.EventHandler(this.moveModelTopButton_Click);
            // 
            // modelsToolTip
            // 
            this.modelsToolTip.ToolTipTitle = "Azioni sui modelli";
            // 
            // ModelsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modelsListButtonsPanel);
            this.Controls.Add(this.modelGroupBox);
            this.Controls.Add(this.modelsListBox);
            this.Name = "ModelsForm";
            this.modelsToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModelsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsDataBindingSource)).EndInit();
            this.modelGroupBox.ResumeLayout(false);
            this.modelGroupBox.PerformLayout();
            this.customOutputFilesArgumentsGroupBox.ResumeLayout(false);
            this.customOutputFilesArgumentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customOutputFileArgumentsBindingSource)).EndInit();
            this.customInputFilesArgumentsGroupBox.ResumeLayout(false);
            this.customInputFilesArgumentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customInputFileArgumentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).EndInit();
            this.modelsListButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox modelsListBox;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.BindingSource modelsDataBindingSource;
        private System.Windows.Forms.GroupBox modelGroupBox;
        private System.Windows.Forms.Label modelNameLabel;
        private System.Windows.Forms.DataGridView tracksDataGridView;
        private System.Windows.Forms.BindingSource trackBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalFileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalFileTrackPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn defaultFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn forcedFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalFileSuffixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalFileExtensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox customInputFilesArgumentsGroupBox;
        private System.Windows.Forms.CheckBox noAttachmentsCheckBox;
        private System.Windows.Forms.CheckBox noCompressionCheckBox;
        private System.Windows.Forms.CheckBox noGlobalTagsCheckBox;
        private System.Windows.Forms.TextBox customInputFileArgumentsTextBox;
        private System.Windows.Forms.GroupBox customOutputFilesArgumentsGroupBox;
        private System.Windows.Forms.TextBox customOutputFileArgumentsTextBox;
        private System.Windows.Forms.CheckBox addChaptersCheckBox;
        private System.Windows.Forms.CheckBox addAttachmentsCheckBox;
        private System.Windows.Forms.CheckBox emptyTitleCheckBox;
        private System.Windows.Forms.CheckBox customCommandCheckBox;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.BindingSource customInputFileArgumentsBindingSource;
        private System.Windows.Forms.BindingSource customOutputFileArgumentsBindingSource;
        private System.Windows.Forms.TextBox modelNameTextBox;
        private System.Windows.Forms.Panel modelsListButtonsPanel;
        private System.Windows.Forms.Button moveModelTopButton;
        private System.Windows.Forms.Button moveModelDownButton;
        private System.Windows.Forms.Button moveModelUpButton;
        private System.Windows.Forms.Button sortModelByNameButton;
        private System.Windows.Forms.Button moveModelBottomButton;
        private System.Windows.Forms.Button deleteModelButton;
        private System.Windows.Forms.Button addModelButton;
        private System.Windows.Forms.Button editModelButton;
        private System.Windows.Forms.CheckBox noTrackTagsCheckBox;
        private System.Windows.Forms.ToolTip modelsToolTip;
    }
}