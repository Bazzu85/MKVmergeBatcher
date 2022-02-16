
namespace MKVmergeBatcher.src.models
{
    partial class ManageModelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageModelForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.modelNameTextBox = new System.Windows.Forms.TextBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.moveTrackDownButton = new System.Windows.Forms.Button();
            this.moveTrackUpButton = new System.Windows.Forms.Button();
            this.addTrackButton = new System.Windows.Forms.Button();
            this.deleteTrackButton = new System.Windows.Forms.Button();
            this.moveTrackBottomButton = new System.Windows.Forms.Button();
            this.moveTrackTopButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.copyTrackButton = new System.Windows.Forms.Button();
            this.editTrackButton = new System.Windows.Forms.Button();
            this.saveModelButton = new System.Windows.Forms.Button();
            this.loadSavedModelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.customOutputFilesArgumentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customOutputFileArgumentsBindingSource)).BeginInit();
            this.customInputFilesArgumentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customInputFileArgumentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // modelNameTextBox
            // 
            resources.ApplyResources(this.modelNameTextBox, "modelNameTextBox");
            this.modelNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "modelName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.modelNameTextBox.Name = "modelNameTextBox";
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(MKVmergeBatcher.src.models.ModelsData.Model);
            // 
            // commandTextBox
            // 
            resources.ApplyResources(this.commandTextBox, "commandTextBox");
            this.commandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "command", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.commandTextBox.Name = "commandTextBox";
            // 
            // customCommandCheckBox
            // 
            resources.ApplyResources(this.customCommandCheckBox, "customCommandCheckBox");
            this.customCommandCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.modelBindingSource, "customCommand", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.customCommandCheckBox.Name = "customCommandCheckBox";
            this.customCommandCheckBox.UseVisualStyleBackColor = true;
            this.customCommandCheckBox.CheckedChanged += new System.EventHandler(this.customCommandCheckBox_CheckedChanged);
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
            // 
            // customOutputFileArgumentsTextBox
            // 
            resources.ApplyResources(this.customOutputFileArgumentsTextBox, "customOutputFileArgumentsTextBox");
            this.customOutputFileArgumentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customOutputFileArgumentsBindingSource, "text", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.customOutputFileArgumentsTextBox.Name = "customOutputFileArgumentsTextBox";
            // 
            // customOutputFileArgumentsBindingSource
            // 
            this.customOutputFileArgumentsBindingSource.DataSource = typeof(MKVmergeBatcher.src.models.ModelsData.Model.CustomOutputFileArguments);
            this.customOutputFileArgumentsBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.customOutputFileArgumentsBindingSource_BindingComplete);
            // 
            // addChaptersCheckBox
            // 
            resources.ApplyResources(this.addChaptersCheckBox, "addChaptersCheckBox");
            this.addChaptersCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customOutputFileArgumentsBindingSource, "addChapters", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addChaptersCheckBox.Name = "addChaptersCheckBox";
            this.addChaptersCheckBox.UseVisualStyleBackColor = true;
            // 
            // addAttachmentsCheckBox
            // 
            resources.ApplyResources(this.addAttachmentsCheckBox, "addAttachmentsCheckBox");
            this.addAttachmentsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customOutputFileArgumentsBindingSource, "addAttachments", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.addAttachmentsCheckBox.Name = "addAttachmentsCheckBox";
            this.addAttachmentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // emptyTitleCheckBox
            // 
            resources.ApplyResources(this.emptyTitleCheckBox, "emptyTitleCheckBox");
            this.emptyTitleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customOutputFileArgumentsBindingSource, "emptyTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.emptyTitleCheckBox.Name = "emptyTitleCheckBox";
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
            // 
            // customInputFileArgumentsTextBox
            // 
            resources.ApplyResources(this.customInputFileArgumentsTextBox, "customInputFileArgumentsTextBox");
            this.customInputFileArgumentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customInputFileArgumentsBindingSource, "text", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.customInputFileArgumentsTextBox.Name = "customInputFileArgumentsTextBox";
            // 
            // customInputFileArgumentsBindingSource
            // 
            this.customInputFileArgumentsBindingSource.DataSource = typeof(MKVmergeBatcher.src.models.ModelsData.Model.CustomInputFileArguments);
            this.customInputFileArgumentsBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.customInputFileArgumentsBindingSource_BindingComplete);
            // 
            // noTrackTagsCheckBox
            // 
            resources.ApplyResources(this.noTrackTagsCheckBox, "noTrackTagsCheckBox");
            this.noTrackTagsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customInputFileArgumentsBindingSource, "noTrackTags", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.noTrackTagsCheckBox.Name = "noTrackTagsCheckBox";
            this.noTrackTagsCheckBox.UseVisualStyleBackColor = true;
            // 
            // noGlobalTagsCheckBox
            // 
            resources.ApplyResources(this.noGlobalTagsCheckBox, "noGlobalTagsCheckBox");
            this.noGlobalTagsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customInputFileArgumentsBindingSource, "noGlobalTags", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.noGlobalTagsCheckBox.Name = "noGlobalTagsCheckBox";
            this.noGlobalTagsCheckBox.UseVisualStyleBackColor = true;
            // 
            // noCompressionCheckBox
            // 
            resources.ApplyResources(this.noCompressionCheckBox, "noCompressionCheckBox");
            this.noCompressionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customInputFileArgumentsBindingSource, "noCompression", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.noCompressionCheckBox.Name = "noCompressionCheckBox";
            this.noCompressionCheckBox.UseVisualStyleBackColor = true;
            // 
            // noAttachmentsCheckBox
            // 
            resources.ApplyResources(this.noAttachmentsCheckBox, "noAttachmentsCheckBox");
            this.noAttachmentsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customInputFileArgumentsBindingSource, "noAttachments", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.noAttachmentsCheckBox.Name = "noAttachmentsCheckBox";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tracksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tracksDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tracksDataGridView.EnableHeadersVisualStyles = false;
            this.tracksDataGridView.MultiSelect = false;
            this.tracksDataGridView.Name = "tracksDataGridView";
            this.tracksDataGridView.ReadOnly = true;
            this.tracksDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tracksDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tracksDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.tracksDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tracksDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.tracksDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.tracksDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tracksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tracksDataGridView.DoubleClick += new System.EventHandler(this.tracksDataGridView_DoubleClick);
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
            this.trackBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.trackBindingSource_BindingComplete);
            // 
            // modelNameLabel
            // 
            resources.ApplyResources(this.modelNameLabel, "modelNameLabel");
            this.modelNameLabel.Name = "modelNameLabel";
            // 
            // moveTrackDownButton
            // 
            resources.ApplyResources(this.moveTrackDownButton, "moveTrackDownButton");
            this.moveTrackDownButton.Name = "moveTrackDownButton";
            this.moveTrackDownButton.UseVisualStyleBackColor = true;
            this.moveTrackDownButton.Click += new System.EventHandler(this.moveTrackDownButton_Click);
            // 
            // moveTrackUpButton
            // 
            resources.ApplyResources(this.moveTrackUpButton, "moveTrackUpButton");
            this.moveTrackUpButton.Name = "moveTrackUpButton";
            this.moveTrackUpButton.UseVisualStyleBackColor = true;
            this.moveTrackUpButton.Click += new System.EventHandler(this.moveTrackUpButton_Click);
            // 
            // addTrackButton
            // 
            resources.ApplyResources(this.addTrackButton, "addTrackButton");
            this.addTrackButton.Name = "addTrackButton";
            this.addTrackButton.UseVisualStyleBackColor = true;
            this.addTrackButton.Click += new System.EventHandler(this.addTrackButton_Click);
            // 
            // deleteTrackButton
            // 
            resources.ApplyResources(this.deleteTrackButton, "deleteTrackButton");
            this.deleteTrackButton.Name = "deleteTrackButton";
            this.deleteTrackButton.UseVisualStyleBackColor = true;
            this.deleteTrackButton.Click += new System.EventHandler(this.deleteTrackButton_Click);
            // 
            // moveTrackBottomButton
            // 
            resources.ApplyResources(this.moveTrackBottomButton, "moveTrackBottomButton");
            this.moveTrackBottomButton.Name = "moveTrackBottomButton";
            this.moveTrackBottomButton.UseVisualStyleBackColor = true;
            this.moveTrackBottomButton.Click += new System.EventHandler(this.moveTrackBottomButton_Click);
            // 
            // moveTrackTopButton
            // 
            resources.ApplyResources(this.moveTrackTopButton, "moveTrackTopButton");
            this.moveTrackTopButton.Name = "moveTrackTopButton";
            this.moveTrackTopButton.UseVisualStyleBackColor = true;
            this.moveTrackTopButton.Click += new System.EventHandler(this.moveTrackTopButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // copyTrackButton
            // 
            resources.ApplyResources(this.copyTrackButton, "copyTrackButton");
            this.copyTrackButton.Name = "copyTrackButton";
            this.copyTrackButton.UseVisualStyleBackColor = true;
            this.copyTrackButton.Click += new System.EventHandler(this.copyTrackButton_Click);
            // 
            // editTrackButton
            // 
            resources.ApplyResources(this.editTrackButton, "editTrackButton");
            this.editTrackButton.Name = "editTrackButton";
            this.editTrackButton.UseVisualStyleBackColor = true;
            this.editTrackButton.Click += new System.EventHandler(this.editTrackButton_Click);
            // 
            // saveModelButton
            // 
            resources.ApplyResources(this.saveModelButton, "saveModelButton");
            this.saveModelButton.Name = "saveModelButton";
            this.saveModelButton.UseVisualStyleBackColor = true;
            this.saveModelButton.Click += new System.EventHandler(this.saveModelButton_Click);
            // 
            // loadSavedModelButton
            // 
            resources.ApplyResources(this.loadSavedModelButton, "loadSavedModelButton");
            this.loadSavedModelButton.Name = "loadSavedModelButton";
            this.loadSavedModelButton.UseVisualStyleBackColor = true;
            this.loadSavedModelButton.Click += new System.EventHandler(this.loadSavedModelButton_Click);
            // 
            // ManageModelForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.loadSavedModelButton);
            this.Controls.Add(this.saveModelButton);
            this.Controls.Add(this.editTrackButton);
            this.Controls.Add(this.copyTrackButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.moveTrackDownButton);
            this.Controls.Add(this.moveTrackUpButton);
            this.Controls.Add(this.addTrackButton);
            this.Controls.Add(this.deleteTrackButton);
            this.Controls.Add(this.moveTrackBottomButton);
            this.Controls.Add(this.moveTrackTopButton);
            this.Controls.Add(this.modelNameTextBox);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.customCommandCheckBox);
            this.Controls.Add(this.customOutputFilesArgumentsGroupBox);
            this.Controls.Add(this.customInputFilesArgumentsGroupBox);
            this.Controls.Add(this.tracksDataGridView);
            this.Controls.Add(this.modelNameLabel);
            this.Name = "ManageModelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditModelForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddEditModelForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.customOutputFilesArgumentsGroupBox.ResumeLayout(false);
            this.customOutputFilesArgumentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customOutputFileArgumentsBindingSource)).EndInit();
            this.customInputFilesArgumentsGroupBox.ResumeLayout(false);
            this.customInputFilesArgumentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customInputFileArgumentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox modelNameTextBox;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.CheckBox customCommandCheckBox;
        private System.Windows.Forms.GroupBox customOutputFilesArgumentsGroupBox;
        private System.Windows.Forms.TextBox customOutputFileArgumentsTextBox;
        private System.Windows.Forms.CheckBox addChaptersCheckBox;
        private System.Windows.Forms.CheckBox addAttachmentsCheckBox;
        private System.Windows.Forms.CheckBox emptyTitleCheckBox;
        private System.Windows.Forms.GroupBox customInputFilesArgumentsGroupBox;
        private System.Windows.Forms.TextBox customInputFileArgumentsTextBox;
        private System.Windows.Forms.CheckBox noTrackTagsCheckBox;
        private System.Windows.Forms.CheckBox noGlobalTagsCheckBox;
        private System.Windows.Forms.CheckBox noCompressionCheckBox;
        private System.Windows.Forms.CheckBox noAttachmentsCheckBox;
        private System.Windows.Forms.DataGridView tracksDataGridView;
        private System.Windows.Forms.Label modelNameLabel;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.BindingSource trackBindingSource;
        private System.Windows.Forms.Button moveTrackDownButton;
        private System.Windows.Forms.Button moveTrackUpButton;
        private System.Windows.Forms.Button addTrackButton;
        private System.Windows.Forms.Button deleteTrackButton;
        private System.Windows.Forms.Button moveTrackBottomButton;
        private System.Windows.Forms.Button moveTrackTopButton;
        private System.Windows.Forms.BindingSource customOutputFileArgumentsBindingSource;
        private System.Windows.Forms.BindingSource customInputFileArgumentsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalFileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalFileTrackPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn defaultFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn forcedFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalFileSuffixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalFileExtensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button copyTrackButton;
        private System.Windows.Forms.Button editTrackButton;
        private System.Windows.Forms.Button saveModelButton;
        private System.Windows.Forms.Button loadSavedModelButton;
    }
}