namespace MKVmergeBatcher.src
{
    partial class ModelCreatorPreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelCreatorPreviewForm));
            this.previewTextBox = new System.Windows.Forms.TextBox();
            this.modelCreatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.addModelLabel = new System.Windows.Forms.Label();
            this.addToModelTextBox = new System.Windows.Forms.TextBox();
            this.addToModelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modelCreatorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // previewTextBox
            // 
            this.previewTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelCreatorBindingSource, "preview", true));
            this.previewTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewTextBox.Location = new System.Drawing.Point(12, 12);
            this.previewTextBox.Multiline = true;
            this.previewTextBox.Name = "previewTextBox";
            this.previewTextBox.Size = new System.Drawing.Size(440, 319);
            this.previewTextBox.TabIndex = 0;
            // 
            // modelCreatorBindingSource
            // 
            this.modelCreatorBindingSource.DataSource = typeof(MKVmergeBatcher.src.obj.UserData.ModelCreator);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(377, 366);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(296, 366);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // addModelLabel
            // 
            this.addModelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addModelLabel.AutoSize = true;
            this.addModelLabel.Location = new System.Drawing.Point(12, 340);
            this.addModelLabel.Name = "addModelLabel";
            this.addModelLabel.Size = new System.Drawing.Size(72, 13);
            this.addModelLabel.TabIndex = 3;
            this.addModelLabel.Text = "Add to model:";
            // 
            // addToModelTextBox
            // 
            this.addToModelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addToModelTextBox.Location = new System.Drawing.Point(90, 337);
            this.addToModelTextBox.Name = "addToModelTextBox";
            this.addToModelTextBox.Size = new System.Drawing.Size(281, 20);
            this.addToModelTextBox.TabIndex = 1;
            // 
            // addToModelButton
            // 
            this.addToModelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addToModelButton.Location = new System.Drawing.Point(377, 337);
            this.addToModelButton.Name = "addToModelButton";
            this.addToModelButton.Size = new System.Drawing.Size(75, 23);
            this.addToModelButton.TabIndex = 2;
            this.addToModelButton.Text = "Add";
            this.addToModelButton.UseVisualStyleBackColor = true;
            this.addToModelButton.Click += new System.EventHandler(this.addToModelButton_Click);
            // 
            // ModelCreatorPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(464, 401);
            this.Controls.Add(this.addToModelButton);
            this.Controls.Add(this.addToModelTextBox);
            this.Controls.Add(this.addModelLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.previewTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 440);
            this.Name = "ModelCreatorPreviewForm";
            this.Text = "Preview";
            ((System.ComponentModel.ISupportInitialize)(this.modelCreatorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox previewTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label addModelLabel;
        private System.Windows.Forms.TextBox addToModelTextBox;
        private System.Windows.Forms.Button addToModelButton;
        private System.Windows.Forms.BindingSource modelCreatorBindingSource;
    }
}