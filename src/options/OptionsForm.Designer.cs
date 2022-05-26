
namespace MKVmergeBatcher.src.options
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.browseMkvMergeLocationButton = new System.Windows.Forms.Button();
            this.mkvMergeLocationTextBox = new System.Windows.Forms.TextBox();
            this.optionsDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logLevelLabel = new System.Windows.Forms.Label();
            this.logLevelsComboBox = new System.Windows.Forms.ComboBox();
            this.logLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localeLabel = new System.Windows.Forms.Label();
            this.localeComboBox = new System.Windows.Forms.ComboBox();
            this.localeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.optionsTabControl = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.allowMultipleInstacesCheckBox = new System.Windows.Forms.CheckBox();
            this.excludeFileNameContiningGroupBox = new System.Windows.Forms.GroupBox();
            this.newExcludeFileNameContainingTextBox = new System.Windows.Forms.TextBox();
            this.removeExcludeFileNameContainingButton = new System.Windows.Forms.Button();
            this.excludeFileNameContainingListBox = new System.Windows.Forms.ListBox();
            this.excludeFileNameContainingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addExcludeFileNameContainingButton = new System.Windows.Forms.Button();
            this.extensionsGroupBox = new System.Windows.Forms.GroupBox();
            this.newExtensionTextBox = new System.Windows.Forms.TextBox();
            this.removeExtensionButton = new System.Windows.Forms.Button();
            this.extensionsListBox = new System.Windows.Forms.ListBox();
            this.extensionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addExtensionButton = new System.Windows.Forms.Button();
            this.queueTabPage = new System.Windows.Forms.TabPage();
            this.replaceExistingDestinationFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.showSummaryOnlyWarningsErrorsCheckBox = new System.Windows.Forms.CheckBox();
            this.showSummaryWhenQueueEndsCheckBox = new System.Windows.Forms.CheckBox();
            this.showQueueWhenAddingCheckBox = new System.Windows.Forms.CheckBox();
            this.autoClearErrorJobsCheckBox = new System.Windows.Forms.CheckBox();
            this.autoClearWarningJobsCheckBox = new System.Windows.Forms.CheckBox();
            this.autoClearOkJobsCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteIncompleteFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.moveWarningFilesToTextBox = new System.Windows.Forms.TextBox();
            this.outputFileFormatTextBox = new System.Windows.Forms.TextBox();
            this.moveOkFilesToTextBox = new System.Windows.Forms.TextBox();
            this.outputFileFormatLabel = new System.Windows.Forms.Label();
            this.moveWarningFilesToLabel = new System.Windows.Forms.Label();
            this.moveOkFilesToLabel = new System.Windows.Forms.Label();
            this.versionTabPage = new System.Windows.Forms.TabPage();
            this.checkVersionButton = new System.Windows.Forms.Button();
            this.lastVersionFoundLabel = new System.Windows.Forms.Label();
            this.currentVersionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkUpdatesCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.optionsDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localeBindingSource)).BeginInit();
            this.optionsTabControl.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.excludeFileNameContiningGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.excludeFileNameContainingBindingSource)).BeginInit();
            this.extensionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extensionBindingSource)).BeginInit();
            this.queueTabPage.SuspendLayout();
            this.versionTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // browseMkvMergeLocationButton
            // 
            resources.ApplyResources(this.browseMkvMergeLocationButton, "browseMkvMergeLocationButton");
            this.browseMkvMergeLocationButton.Name = "browseMkvMergeLocationButton";
            this.browseMkvMergeLocationButton.UseVisualStyleBackColor = true;
            this.browseMkvMergeLocationButton.Click += new System.EventHandler(this.browseMkvMergeLocationButton_Click);
            // 
            // mkvMergeLocationTextBox
            // 
            resources.ApplyResources(this.mkvMergeLocationTextBox, "mkvMergeLocationTextBox");
            this.mkvMergeLocationTextBox.AllowDrop = true;
            this.mkvMergeLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.optionsDataBindingSource, "mkvMergeLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mkvMergeLocationTextBox.Name = "mkvMergeLocationTextBox";
            this.mkvMergeLocationTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.mkvMergeLocationTextBox_DragDrop);
            this.mkvMergeLocationTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.mkvMergeLocationTextBox_DragEnter);
            // 
            // optionsDataBindingSource
            // 
            this.optionsDataBindingSource.DataSource = typeof(MKVmergeBatcher.src.options.OptionsData);
            // 
            // logLevelLabel
            // 
            resources.ApplyResources(this.logLevelLabel, "logLevelLabel");
            this.logLevelLabel.Name = "logLevelLabel";
            // 
            // logLevelsComboBox
            // 
            resources.ApplyResources(this.logLevelsComboBox, "logLevelsComboBox");
            this.logLevelsComboBox.DataSource = this.logLevelBindingSource;
            this.logLevelsComboBox.DisplayMember = "logLevel";
            this.logLevelsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.logLevelsComboBox.FormattingEnabled = true;
            this.logLevelsComboBox.Name = "logLevelsComboBox";
            this.logLevelsComboBox.ValueMember = "logLevel";
            this.logLevelsComboBox.SelectedIndexChanged += new System.EventHandler(this.logLevelsComboBox_SelectedIndexChanged);
            // 
            // logLevelBindingSource
            // 
            this.logLevelBindingSource.DataSource = typeof(MKVmergeBatcher.src.options.OptionsData.LogLevel);
            // 
            // localeLabel
            // 
            resources.ApplyResources(this.localeLabel, "localeLabel");
            this.localeLabel.Name = "localeLabel";
            // 
            // localeComboBox
            // 
            resources.ApplyResources(this.localeComboBox, "localeComboBox");
            this.localeComboBox.DataSource = this.localeBindingSource;
            this.localeComboBox.DisplayMember = "localeName";
            this.localeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.localeComboBox.FormattingEnabled = true;
            this.localeComboBox.Name = "localeComboBox";
            this.localeComboBox.ValueMember = "localeCode";
            this.localeComboBox.SelectedIndexChanged += new System.EventHandler(this.localeComboBox_SelectedIndexChanged);
            // 
            // localeBindingSource
            // 
            this.localeBindingSource.DataSource = typeof(MKVmergeBatcher.src.options.OptionsData.Locale);
            // 
            // optionsTabControl
            // 
            resources.ApplyResources(this.optionsTabControl, "optionsTabControl");
            this.optionsTabControl.Controls.Add(this.generalTabPage);
            this.optionsTabControl.Controls.Add(this.queueTabPage);
            this.optionsTabControl.Controls.Add(this.versionTabPage);
            this.optionsTabControl.Name = "optionsTabControl";
            this.optionsTabControl.SelectedIndex = 0;
            // 
            // generalTabPage
            // 
            resources.ApplyResources(this.generalTabPage, "generalTabPage");
            this.generalTabPage.Controls.Add(this.allowMultipleInstacesCheckBox);
            this.generalTabPage.Controls.Add(this.excludeFileNameContiningGroupBox);
            this.generalTabPage.Controls.Add(this.extensionsGroupBox);
            this.generalTabPage.Controls.Add(this.logLevelLabel);
            this.generalTabPage.Controls.Add(this.localeComboBox);
            this.generalTabPage.Controls.Add(this.label1);
            this.generalTabPage.Controls.Add(this.localeLabel);
            this.generalTabPage.Controls.Add(this.browseMkvMergeLocationButton);
            this.generalTabPage.Controls.Add(this.logLevelsComboBox);
            this.generalTabPage.Controls.Add(this.mkvMergeLocationTextBox);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // allowMultipleInstacesCheckBox
            // 
            resources.ApplyResources(this.allowMultipleInstacesCheckBox, "allowMultipleInstacesCheckBox");
            this.allowMultipleInstacesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.optionsDataBindingSource, "allowMultipleInstaces", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.allowMultipleInstacesCheckBox.Name = "allowMultipleInstacesCheckBox";
            this.allowMultipleInstacesCheckBox.UseVisualStyleBackColor = true;
            // 
            // excludeFileNameContiningGroupBox
            // 
            resources.ApplyResources(this.excludeFileNameContiningGroupBox, "excludeFileNameContiningGroupBox");
            this.excludeFileNameContiningGroupBox.Controls.Add(this.newExcludeFileNameContainingTextBox);
            this.excludeFileNameContiningGroupBox.Controls.Add(this.removeExcludeFileNameContainingButton);
            this.excludeFileNameContiningGroupBox.Controls.Add(this.excludeFileNameContainingListBox);
            this.excludeFileNameContiningGroupBox.Controls.Add(this.addExcludeFileNameContainingButton);
            this.excludeFileNameContiningGroupBox.Name = "excludeFileNameContiningGroupBox";
            this.excludeFileNameContiningGroupBox.TabStop = false;
            // 
            // newExcludeFileNameContainingTextBox
            // 
            resources.ApplyResources(this.newExcludeFileNameContainingTextBox, "newExcludeFileNameContainingTextBox");
            this.newExcludeFileNameContainingTextBox.Name = "newExcludeFileNameContainingTextBox";
            // 
            // removeExcludeFileNameContainingButton
            // 
            resources.ApplyResources(this.removeExcludeFileNameContainingButton, "removeExcludeFileNameContainingButton");
            this.removeExcludeFileNameContainingButton.Name = "removeExcludeFileNameContainingButton";
            this.removeExcludeFileNameContainingButton.UseVisualStyleBackColor = true;
            this.removeExcludeFileNameContainingButton.Click += new System.EventHandler(this.removeExcludeFileNameContainingButton_Click);
            // 
            // excludeFileNameContainingListBox
            // 
            resources.ApplyResources(this.excludeFileNameContainingListBox, "excludeFileNameContainingListBox");
            this.excludeFileNameContainingListBox.DataSource = this.excludeFileNameContainingBindingSource;
            this.excludeFileNameContainingListBox.DisplayMember = "excludeFileNameContaining";
            this.excludeFileNameContainingListBox.FormattingEnabled = true;
            this.excludeFileNameContainingListBox.Name = "excludeFileNameContainingListBox";
            // 
            // excludeFileNameContainingBindingSource
            // 
            this.excludeFileNameContainingBindingSource.DataSource = typeof(MKVmergeBatcher.src.options.OptionsData.ExcludeFileNameContaining);
            // 
            // addExcludeFileNameContainingButton
            // 
            resources.ApplyResources(this.addExcludeFileNameContainingButton, "addExcludeFileNameContainingButton");
            this.addExcludeFileNameContainingButton.Name = "addExcludeFileNameContainingButton";
            this.addExcludeFileNameContainingButton.UseVisualStyleBackColor = true;
            this.addExcludeFileNameContainingButton.Click += new System.EventHandler(this.addExcludeFileNameContainingButton_Click);
            // 
            // extensionsGroupBox
            // 
            resources.ApplyResources(this.extensionsGroupBox, "extensionsGroupBox");
            this.extensionsGroupBox.Controls.Add(this.newExtensionTextBox);
            this.extensionsGroupBox.Controls.Add(this.removeExtensionButton);
            this.extensionsGroupBox.Controls.Add(this.extensionsListBox);
            this.extensionsGroupBox.Controls.Add(this.addExtensionButton);
            this.extensionsGroupBox.Name = "extensionsGroupBox";
            this.extensionsGroupBox.TabStop = false;
            // 
            // newExtensionTextBox
            // 
            resources.ApplyResources(this.newExtensionTextBox, "newExtensionTextBox");
            this.newExtensionTextBox.Name = "newExtensionTextBox";
            // 
            // removeExtensionButton
            // 
            resources.ApplyResources(this.removeExtensionButton, "removeExtensionButton");
            this.removeExtensionButton.Name = "removeExtensionButton";
            this.removeExtensionButton.UseVisualStyleBackColor = true;
            this.removeExtensionButton.Click += new System.EventHandler(this.removeExtensionButton_Click);
            // 
            // extensionsListBox
            // 
            resources.ApplyResources(this.extensionsListBox, "extensionsListBox");
            this.extensionsListBox.DataSource = this.extensionBindingSource;
            this.extensionsListBox.DisplayMember = "extension";
            this.extensionsListBox.FormattingEnabled = true;
            this.extensionsListBox.Name = "extensionsListBox";
            // 
            // extensionBindingSource
            // 
            this.extensionBindingSource.DataSource = typeof(MKVmergeBatcher.src.options.OptionsData.Extension);
            // 
            // addExtensionButton
            // 
            resources.ApplyResources(this.addExtensionButton, "addExtensionButton");
            this.addExtensionButton.Name = "addExtensionButton";
            this.addExtensionButton.UseVisualStyleBackColor = true;
            this.addExtensionButton.Click += new System.EventHandler(this.addExtensionButton_Click);
            // 
            // queueTabPage
            // 
            resources.ApplyResources(this.queueTabPage, "queueTabPage");
            this.queueTabPage.Controls.Add(this.replaceExistingDestinationFilesCheckBox);
            this.queueTabPage.Controls.Add(this.showSummaryOnlyWarningsErrorsCheckBox);
            this.queueTabPage.Controls.Add(this.showSummaryWhenQueueEndsCheckBox);
            this.queueTabPage.Controls.Add(this.showQueueWhenAddingCheckBox);
            this.queueTabPage.Controls.Add(this.autoClearErrorJobsCheckBox);
            this.queueTabPage.Controls.Add(this.autoClearWarningJobsCheckBox);
            this.queueTabPage.Controls.Add(this.autoClearOkJobsCheckBox);
            this.queueTabPage.Controls.Add(this.deleteIncompleteFilesCheckBox);
            this.queueTabPage.Controls.Add(this.moveWarningFilesToTextBox);
            this.queueTabPage.Controls.Add(this.outputFileFormatTextBox);
            this.queueTabPage.Controls.Add(this.moveOkFilesToTextBox);
            this.queueTabPage.Controls.Add(this.outputFileFormatLabel);
            this.queueTabPage.Controls.Add(this.moveWarningFilesToLabel);
            this.queueTabPage.Controls.Add(this.moveOkFilesToLabel);
            this.queueTabPage.Name = "queueTabPage";
            this.queueTabPage.UseVisualStyleBackColor = true;
            // 
            // replaceExistingDestinationFilesCheckBox
            // 
            resources.ApplyResources(this.replaceExistingDestinationFilesCheckBox, "replaceExistingDestinationFilesCheckBox");
            this.replaceExistingDestinationFilesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.optionsDataBindingSource, "replaceExistingDestinationFiles", true));
            this.replaceExistingDestinationFilesCheckBox.Name = "replaceExistingDestinationFilesCheckBox";
            this.replaceExistingDestinationFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // showSummaryOnlyWarningsErrorsCheckBox
            // 
            resources.ApplyResources(this.showSummaryOnlyWarningsErrorsCheckBox, "showSummaryOnlyWarningsErrorsCheckBox");
            this.showSummaryOnlyWarningsErrorsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.optionsDataBindingSource, "showSummaryOnlyWarningsErrors", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.showSummaryOnlyWarningsErrorsCheckBox.Name = "showSummaryOnlyWarningsErrorsCheckBox";
            this.showSummaryOnlyWarningsErrorsCheckBox.UseVisualStyleBackColor = true;
            // 
            // showSummaryWhenQueueEndsCheckBox
            // 
            resources.ApplyResources(this.showSummaryWhenQueueEndsCheckBox, "showSummaryWhenQueueEndsCheckBox");
            this.showSummaryWhenQueueEndsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.optionsDataBindingSource, "showSummaryWhenQueueEnds", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.showSummaryWhenQueueEndsCheckBox.Name = "showSummaryWhenQueueEndsCheckBox";
            this.showSummaryWhenQueueEndsCheckBox.UseVisualStyleBackColor = true;
            // 
            // showQueueWhenAddingCheckBox
            // 
            resources.ApplyResources(this.showQueueWhenAddingCheckBox, "showQueueWhenAddingCheckBox");
            this.showQueueWhenAddingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.optionsDataBindingSource, "showQueueWhenAdding", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.showQueueWhenAddingCheckBox.Name = "showQueueWhenAddingCheckBox";
            this.showQueueWhenAddingCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoClearErrorJobsCheckBox
            // 
            resources.ApplyResources(this.autoClearErrorJobsCheckBox, "autoClearErrorJobsCheckBox");
            this.autoClearErrorJobsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.optionsDataBindingSource, "autoClearErrorJobs", true));
            this.autoClearErrorJobsCheckBox.Name = "autoClearErrorJobsCheckBox";
            this.autoClearErrorJobsCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoClearWarningJobsCheckBox
            // 
            resources.ApplyResources(this.autoClearWarningJobsCheckBox, "autoClearWarningJobsCheckBox");
            this.autoClearWarningJobsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.optionsDataBindingSource, "autoClearWarningJobs", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.autoClearWarningJobsCheckBox.Name = "autoClearWarningJobsCheckBox";
            this.autoClearWarningJobsCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoClearOkJobsCheckBox
            // 
            resources.ApplyResources(this.autoClearOkJobsCheckBox, "autoClearOkJobsCheckBox");
            this.autoClearOkJobsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.optionsDataBindingSource, "autoClearOkJobs", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.autoClearOkJobsCheckBox.Name = "autoClearOkJobsCheckBox";
            this.autoClearOkJobsCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteIncompleteFilesCheckBox
            // 
            resources.ApplyResources(this.deleteIncompleteFilesCheckBox, "deleteIncompleteFilesCheckBox");
            this.deleteIncompleteFilesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.optionsDataBindingSource, "deleteIncompleteFiles", true));
            this.deleteIncompleteFilesCheckBox.Name = "deleteIncompleteFilesCheckBox";
            this.deleteIncompleteFilesCheckBox.UseVisualStyleBackColor = true;
            // 
            // moveWarningFilesToTextBox
            // 
            resources.ApplyResources(this.moveWarningFilesToTextBox, "moveWarningFilesToTextBox");
            this.moveWarningFilesToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.optionsDataBindingSource, "moveWarningFilesTo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.moveWarningFilesToTextBox.Name = "moveWarningFilesToTextBox";
            // 
            // outputFileFormatTextBox
            // 
            resources.ApplyResources(this.outputFileFormatTextBox, "outputFileFormatTextBox");
            this.outputFileFormatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.optionsDataBindingSource, "outputFileFormat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.outputFileFormatTextBox.Name = "outputFileFormatTextBox";
            // 
            // moveOkFilesToTextBox
            // 
            resources.ApplyResources(this.moveOkFilesToTextBox, "moveOkFilesToTextBox");
            this.moveOkFilesToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.optionsDataBindingSource, "moveOkFilesTo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.moveOkFilesToTextBox.Name = "moveOkFilesToTextBox";
            // 
            // outputFileFormatLabel
            // 
            resources.ApplyResources(this.outputFileFormatLabel, "outputFileFormatLabel");
            this.outputFileFormatLabel.Name = "outputFileFormatLabel";
            // 
            // moveWarningFilesToLabel
            // 
            resources.ApplyResources(this.moveWarningFilesToLabel, "moveWarningFilesToLabel");
            this.moveWarningFilesToLabel.Name = "moveWarningFilesToLabel";
            // 
            // moveOkFilesToLabel
            // 
            resources.ApplyResources(this.moveOkFilesToLabel, "moveOkFilesToLabel");
            this.moveOkFilesToLabel.Name = "moveOkFilesToLabel";
            // 
            // versionTabPage
            // 
            resources.ApplyResources(this.versionTabPage, "versionTabPage");
            this.versionTabPage.Controls.Add(this.checkVersionButton);
            this.versionTabPage.Controls.Add(this.lastVersionFoundLabel);
            this.versionTabPage.Controls.Add(this.currentVersionLabel);
            this.versionTabPage.Controls.Add(this.label3);
            this.versionTabPage.Controls.Add(this.label2);
            this.versionTabPage.Controls.Add(this.checkUpdatesCheckBox);
            this.versionTabPage.Name = "versionTabPage";
            this.versionTabPage.UseVisualStyleBackColor = true;
            // 
            // checkVersionButton
            // 
            resources.ApplyResources(this.checkVersionButton, "checkVersionButton");
            this.checkVersionButton.Name = "checkVersionButton";
            this.checkVersionButton.UseVisualStyleBackColor = true;
            this.checkVersionButton.Click += new System.EventHandler(this.checkVersionButton_Click);
            // 
            // lastVersionFoundLabel
            // 
            resources.ApplyResources(this.lastVersionFoundLabel, "lastVersionFoundLabel");
            this.lastVersionFoundLabel.Name = "lastVersionFoundLabel";
            // 
            // currentVersionLabel
            // 
            resources.ApplyResources(this.currentVersionLabel, "currentVersionLabel");
            this.currentVersionLabel.Name = "currentVersionLabel";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // checkUpdatesCheckBox
            // 
            resources.ApplyResources(this.checkUpdatesCheckBox, "checkUpdatesCheckBox");
            this.checkUpdatesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.optionsDataBindingSource, "checkUpdates", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkUpdatesCheckBox.Name = "checkUpdatesCheckBox";
            this.checkUpdatesCheckBox.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.optionsTabControl);
            this.KeyPreview = true;
            this.Name = "OptionsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionsForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OptionsForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.optionsDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localeBindingSource)).EndInit();
            this.optionsTabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            this.excludeFileNameContiningGroupBox.ResumeLayout(false);
            this.excludeFileNameContiningGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.excludeFileNameContainingBindingSource)).EndInit();
            this.extensionsGroupBox.ResumeLayout(false);
            this.extensionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extensionBindingSource)).EndInit();
            this.queueTabPage.ResumeLayout(false);
            this.queueTabPage.PerformLayout();
            this.versionTabPage.ResumeLayout(false);
            this.versionTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseMkvMergeLocationButton;
        private System.Windows.Forms.TextBox mkvMergeLocationTextBox;
        private System.Windows.Forms.BindingSource optionsDataBindingSource;
        private System.Windows.Forms.Label logLevelLabel;
        private System.Windows.Forms.ComboBox logLevelsComboBox;
        private System.Windows.Forms.BindingSource logLevelBindingSource;
        private System.Windows.Forms.Label localeLabel;
        private System.Windows.Forms.ComboBox localeComboBox;
        private System.Windows.Forms.BindingSource localeBindingSource;
        private System.Windows.Forms.TabControl optionsTabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TabPage queueTabPage;
        private System.Windows.Forms.TextBox moveWarningFilesToTextBox;
        private System.Windows.Forms.TextBox moveOkFilesToTextBox;
        private System.Windows.Forms.Label moveWarningFilesToLabel;
        private System.Windows.Forms.Label moveOkFilesToLabel;
        private System.Windows.Forms.CheckBox replaceExistingDestinationFilesCheckBox;
        private System.Windows.Forms.CheckBox deleteIncompleteFilesCheckBox;
        private System.Windows.Forms.GroupBox extensionsGroupBox;
        private System.Windows.Forms.Button removeExtensionButton;
        private System.Windows.Forms.ListBox extensionsListBox;
        private System.Windows.Forms.Button addExtensionButton;
        private System.Windows.Forms.BindingSource extensionBindingSource;
        private System.Windows.Forms.TextBox newExtensionTextBox;
        private System.Windows.Forms.GroupBox excludeFileNameContiningGroupBox;
        private System.Windows.Forms.TextBox newExcludeFileNameContainingTextBox;
        private System.Windows.Forms.Button removeExcludeFileNameContainingButton;
        private System.Windows.Forms.ListBox excludeFileNameContainingListBox;
        private System.Windows.Forms.Button addExcludeFileNameContainingButton;
        private System.Windows.Forms.BindingSource excludeFileNameContainingBindingSource;
        private System.Windows.Forms.CheckBox autoClearOkJobsCheckBox;
        private System.Windows.Forms.CheckBox autoClearWarningJobsCheckBox;
        private System.Windows.Forms.CheckBox autoClearErrorJobsCheckBox;
        private System.Windows.Forms.CheckBox allowMultipleInstacesCheckBox;
        private System.Windows.Forms.TabPage versionTabPage;
        private System.Windows.Forms.CheckBox checkUpdatesCheckBox;
        private System.Windows.Forms.Label lastVersionFoundLabel;
        private System.Windows.Forms.Label currentVersionLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkVersionButton;
        private System.Windows.Forms.TextBox outputFileFormatTextBox;
        private System.Windows.Forms.Label outputFileFormatLabel;
        private System.Windows.Forms.CheckBox showSummaryOnlyWarningsErrorsCheckBox;
        private System.Windows.Forms.CheckBox showSummaryWhenQueueEndsCheckBox;
        private System.Windows.Forms.CheckBox showQueueWhenAddingCheckBox;
    }
}