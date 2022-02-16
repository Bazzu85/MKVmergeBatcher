
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
            this.oldUserDataLabel.AutoSize = true;
            this.oldUserDataLabel.Location = new System.Drawing.Point(12, 9);
            this.oldUserDataLabel.Name = "oldUserDataLabel";
            this.oldUserDataLabel.Size = new System.Drawing.Size(112, 13);
            this.oldUserDataLabel.TabIndex = 0;
            this.oldUserDataLabel.Text = "Old UserData.json file:";
            // 
            // oldUserDataTextBox
            // 
            this.oldUserDataTextBox.AllowDrop = true;
            this.oldUserDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldUserDataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.importLegacyDataBindingSource, "oldUserDataJson", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.oldUserDataTextBox.Location = new System.Drawing.Point(130, 6);
            this.oldUserDataTextBox.Name = "oldUserDataTextBox";
            this.oldUserDataTextBox.Size = new System.Drawing.Size(211, 20);
            this.oldUserDataTextBox.TabIndex = 1;
            this.oldUserDataTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.oldUserDataTextBox_DragDrop);
            this.oldUserDataTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.oldUserDataTextBox_DragEnter);
            // 
            // importLegacyDataBindingSource
            // 
            this.importLegacyDataBindingSource.DataSource = typeof(MKVmergeBatcher.src.legacy.ImportLegacyData);
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(347, 6);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 20);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // importButton
            // 
            this.importButton.Image = ((System.Drawing.Image)(resources.GetObject("importButton.Image")));
            this.importButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importButton.Location = new System.Drawing.Point(201, 32);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(78, 32);
            this.importButton.TabIndex = 3;
            this.importButton.Text = "Import";
            this.importButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // importProgressBar
            // 
            this.importProgressBar.Location = new System.Drawing.Point(153, 72);
            this.importProgressBar.Name = "importProgressBar";
            this.importProgressBar.Size = new System.Drawing.Size(269, 13);
            this.importProgressBar.TabIndex = 4;
            this.importProgressBar.Visible = false;
            // 
            // importLabel
            // 
            this.importLabel.AutoSize = true;
            this.importLabel.Location = new System.Drawing.Point(13, 72);
            this.importLabel.Name = "importLabel";
            this.importLabel.Size = new System.Drawing.Size(123, 13);
            this.importLabel.TabIndex = 5;
            this.importLabel.Text = "Working on model 0 of 0";
            this.importLabel.Visible = false;
            // 
            // ImportLegacyDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 91);
            this.Controls.Add(this.importLabel);
            this.Controls.Add(this.importProgressBar);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.oldUserDataTextBox);
            this.Controls.Add(this.oldUserDataLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 130);
            this.Name = "ImportLegacyDataForm";
            this.Text = "Import";
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