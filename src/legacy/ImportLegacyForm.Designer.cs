
namespace MKVmergeBatcher.src.legacy
{
    partial class ImportLegacyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportLegacyForm));
            this.oldUserDataLabel = new System.Windows.Forms.Label();
            this.oldUserDataTextBox = new System.Windows.Forms.TextBox();
            this.importLegacyDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.browseButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.importProgressBar = new System.Windows.Forms.ProgressBar();
            this.importLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.importLegacyDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // oldUserDataLabel
            // 
            resources.ApplyResources(this.oldUserDataLabel, "oldUserDataLabel");
            this.oldUserDataLabel.Name = "oldUserDataLabel";
            // 
            // oldUserDataTextBox
            // 
            resources.ApplyResources(this.oldUserDataTextBox, "oldUserDataTextBox");
            this.oldUserDataTextBox.AllowDrop = true;
            this.oldUserDataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importLegacyDataBindingSource, "oldUserDataJson", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.oldUserDataTextBox.Name = "oldUserDataTextBox";
            this.oldUserDataTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.oldUserDataTextBox_DragDrop);
            this.oldUserDataTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.oldUserDataTextBox_DragEnter);
            // 
            // importLegacyDataBindingSource
            // 
            this.importLegacyDataBindingSource.DataSource = typeof(MKVmergeBatcher.src.legacy.ImportLegacyData);
            // 
            // browseButton
            // 
            resources.ApplyResources(this.browseButton, "browseButton");
            this.browseButton.Name = "browseButton";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // importButton
            // 
            resources.ApplyResources(this.importButton, "importButton");
            this.importButton.Name = "importButton";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // importProgressBar
            // 
            resources.ApplyResources(this.importProgressBar, "importProgressBar");
            this.importProgressBar.Name = "importProgressBar";
            // 
            // importLabel
            // 
            resources.ApplyResources(this.importLabel, "importLabel");
            this.importLabel.Name = "importLabel";
            // 
            // ImportLegacyForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.importLabel);
            this.Controls.Add(this.importProgressBar);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.oldUserDataTextBox);
            this.Controls.Add(this.oldUserDataLabel);
            this.Name = "ImportLegacyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportLegacyDataForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImportLegacyDataForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.importLegacyDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldUserDataLabel;
        private System.Windows.Forms.TextBox oldUserDataTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.BindingSource importLegacyDataBindingSource;
        private System.Windows.Forms.ProgressBar importProgressBar;
        private System.Windows.Forms.Label importLabel;
    }
}