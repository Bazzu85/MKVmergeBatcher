
namespace MKVmergeBatcher.src.models
{
    partial class ManageTrackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTrackForm));
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.trackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.originalFileNumberLabel = new System.Windows.Forms.Label();
            this.OriginalFileNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.originalFilePositionLabel = new System.Windows.Forms.Label();
            this.OriginalFilePositionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.languageCodeLabel = new System.Windows.Forms.Label();
            this.languageCodeTextBox = new System.Windows.Forms.TextBox();
            this.trackNameLabel = new System.Windows.Forms.Label();
            this.trackNameTextBox = new System.Windows.Forms.TextBox();
            this.defaultCheckBox = new System.Windows.Forms.CheckBox();
            this.forcedCheckBox = new System.Windows.Forms.CheckBox();
            this.originalFileSuffixLabel = new System.Windows.Forms.Label();
            this.originalFileNameSuffixTextBox = new System.Windows.Forms.TextBox();
            this.originalFileExtensionLabel = new System.Windows.Forms.Label();
            this.originalFileExtensionTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalFileNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalFilePositionNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            resources.ApplyResources(this.typeLabel, "typeLabel");
            this.typeLabel.Name = "typeLabel";
            // 
            // typeComboBox
            // 
            resources.ApplyResources(this.typeComboBox, "typeComboBox");
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            resources.GetString("typeComboBox.Items"),
            resources.GetString("typeComboBox.Items1"),
            resources.GetString("typeComboBox.Items2")});
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // trackBindingSource
            // 
            this.trackBindingSource.DataSource = typeof(MKVmergeBatcher.src.models.ModelsData.Model.Track);
            // 
            // originalFileNumberLabel
            // 
            resources.ApplyResources(this.originalFileNumberLabel, "originalFileNumberLabel");
            this.originalFileNumberLabel.Name = "originalFileNumberLabel";
            // 
            // OriginalFileNumberNumericUpDown
            // 
            resources.ApplyResources(this.OriginalFileNumberNumericUpDown, "OriginalFileNumberNumericUpDown");
            this.OriginalFileNumberNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.trackBindingSource, "originalFileNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OriginalFileNumberNumericUpDown.Name = "OriginalFileNumberNumericUpDown";
            // 
            // originalFilePositionLabel
            // 
            resources.ApplyResources(this.originalFilePositionLabel, "originalFilePositionLabel");
            this.originalFilePositionLabel.Name = "originalFilePositionLabel";
            // 
            // OriginalFilePositionNumericUpDown
            // 
            resources.ApplyResources(this.OriginalFilePositionNumericUpDown, "OriginalFilePositionNumericUpDown");
            this.OriginalFilePositionNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.trackBindingSource, "originalFileTrackPosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OriginalFilePositionNumericUpDown.Name = "OriginalFilePositionNumericUpDown";
            // 
            // languageCodeLabel
            // 
            resources.ApplyResources(this.languageCodeLabel, "languageCodeLabel");
            this.languageCodeLabel.Name = "languageCodeLabel";
            // 
            // languageCodeTextBox
            // 
            resources.ApplyResources(this.languageCodeTextBox, "languageCodeTextBox");
            this.languageCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trackBindingSource, "language", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.languageCodeTextBox.Name = "languageCodeTextBox";
            // 
            // trackNameLabel
            // 
            resources.ApplyResources(this.trackNameLabel, "trackNameLabel");
            this.trackNameLabel.Name = "trackNameLabel";
            // 
            // trackNameTextBox
            // 
            resources.ApplyResources(this.trackNameTextBox, "trackNameTextBox");
            this.trackNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trackBindingSource, "name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trackNameTextBox.Name = "trackNameTextBox";
            // 
            // defaultCheckBox
            // 
            resources.ApplyResources(this.defaultCheckBox, "defaultCheckBox");
            this.defaultCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.trackBindingSource, "DefaultFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.defaultCheckBox.Name = "defaultCheckBox";
            this.defaultCheckBox.UseVisualStyleBackColor = true;
            // 
            // forcedCheckBox
            // 
            resources.ApplyResources(this.forcedCheckBox, "forcedCheckBox");
            this.forcedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.trackBindingSource, "ForcedFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.forcedCheckBox.Name = "forcedCheckBox";
            this.forcedCheckBox.UseVisualStyleBackColor = true;
            // 
            // originalFileSuffixLabel
            // 
            resources.ApplyResources(this.originalFileSuffixLabel, "originalFileSuffixLabel");
            this.originalFileSuffixLabel.Name = "originalFileSuffixLabel";
            // 
            // originalFileNameSuffixTextBox
            // 
            resources.ApplyResources(this.originalFileNameSuffixTextBox, "originalFileNameSuffixTextBox");
            this.originalFileNameSuffixTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trackBindingSource, "originalFileSuffix", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.originalFileNameSuffixTextBox.Name = "originalFileNameSuffixTextBox";
            // 
            // originalFileExtensionLabel
            // 
            resources.ApplyResources(this.originalFileExtensionLabel, "originalFileExtensionLabel");
            this.originalFileExtensionLabel.Name = "originalFileExtensionLabel";
            // 
            // originalFileExtensionTextBox
            // 
            resources.ApplyResources(this.originalFileExtensionTextBox, "originalFileExtensionTextBox");
            this.originalFileExtensionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trackBindingSource, "originalFileExtension", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.originalFileExtensionTextBox.Name = "originalFileExtensionTextBox";
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
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ManageTrackForm
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.forcedCheckBox);
            this.Controls.Add(this.defaultCheckBox);
            this.Controls.Add(this.originalFileExtensionTextBox);
            this.Controls.Add(this.originalFileNameSuffixTextBox);
            this.Controls.Add(this.trackNameTextBox);
            this.Controls.Add(this.languageCodeTextBox);
            this.Controls.Add(this.OriginalFilePositionNumericUpDown);
            this.Controls.Add(this.OriginalFileNumberNumericUpDown);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.originalFilePositionLabel);
            this.Controls.Add(this.originalFileExtensionLabel);
            this.Controls.Add(this.originalFileSuffixLabel);
            this.Controls.Add(this.trackNameLabel);
            this.Controls.Add(this.languageCodeLabel);
            this.Controls.Add(this.originalFileNumberLabel);
            this.Controls.Add(this.typeLabel);
            this.MaximizeBox = false;
            this.Name = "ManageTrackForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageTrack_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageTrack_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalFileNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalFilePositionNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label originalFileNumberLabel;
        private System.Windows.Forms.NumericUpDown OriginalFileNumberNumericUpDown;
        private System.Windows.Forms.Label originalFilePositionLabel;
        private System.Windows.Forms.NumericUpDown OriginalFilePositionNumericUpDown;
        private System.Windows.Forms.Label languageCodeLabel;
        private System.Windows.Forms.TextBox languageCodeTextBox;
        private System.Windows.Forms.Label trackNameLabel;
        private System.Windows.Forms.TextBox trackNameTextBox;
        private System.Windows.Forms.CheckBox defaultCheckBox;
        private System.Windows.Forms.CheckBox forcedCheckBox;
        private System.Windows.Forms.Label originalFileSuffixLabel;
        private System.Windows.Forms.TextBox originalFileNameSuffixTextBox;
        private System.Windows.Forms.Label originalFileExtensionLabel;
        private System.Windows.Forms.TextBox originalFileExtensionTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.BindingSource trackBindingSource;
    }
}