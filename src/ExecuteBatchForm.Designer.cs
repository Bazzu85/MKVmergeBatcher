namespace MKVmergeBatcher.src
{
    partial class ExecuteBatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExecuteBatchForm));
            this.workingOnLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.totalProgressLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.warningsLabel = new System.Windows.Forms.Label();
            this.errorsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // workingOnLabel
            // 
            this.workingOnLabel.AutoSize = true;
            this.workingOnLabel.Location = new System.Drawing.Point(12, 9);
            this.workingOnLabel.Name = "workingOnLabel";
            this.workingOnLabel.Size = new System.Drawing.Size(144, 13);
            this.workingOnLabel.TabIndex = 0;
            this.workingOnLabel.Text = "Working on file number x of x";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(12, 31);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(58, 13);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.Text = "File name: ";
            // 
            // totalProgressLabel
            // 
            this.totalProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalProgressLabel.AutoSize = true;
            this.totalProgressLabel.Location = new System.Drawing.Point(12, 340);
            this.totalProgressLabel.Name = "totalProgressLabel";
            this.totalProgressLabel.Size = new System.Drawing.Size(81, 13);
            this.totalProgressLabel.TabIndex = 2;
            this.totalProgressLabel.Text = "Total Progress: ";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(99, 341);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(863, 13);
            this.progressBar.TabIndex = 3;
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Location = new System.Drawing.Point(887, 369);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(806, 369);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTextBox.Enabled = false;
            this.fileNameTextBox.Location = new System.Drawing.Point(76, 28);
            this.fileNameTextBox.Multiline = true;
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(886, 48);
            this.fileNameTextBox.TabIndex = 6;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 85);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(42, 13);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.Text = "Output:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(76, 85);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(886, 250);
            this.outputTextBox.TabIndex = 8;
            this.outputTextBox.Text = "";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // warningsLabel
            // 
            this.warningsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.warningsLabel.AutoSize = true;
            this.warningsLabel.Location = new System.Drawing.Point(12, 369);
            this.warningsLabel.Name = "warningsLabel";
            this.warningsLabel.Size = new System.Drawing.Size(91, 13);
            this.warningsLabel.TabIndex = 9;
            this.warningsLabel.Text = "Total Warnings: 0";
            // 
            // errorsLabel
            // 
            this.errorsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errorsLabel.AutoSize = true;
            this.errorsLabel.Location = new System.Drawing.Point(111, 369);
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Size = new System.Drawing.Size(73, 13);
            this.errorsLabel.TabIndex = 10;
            this.errorsLabel.Text = "Total Errors: 0";
            // 
            // ExecuteBatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 401);
            this.Controls.Add(this.errorsLabel);
            this.Controls.Add(this.warningsLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.totalProgressLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.workingOnLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(990, 440);
            this.Name = "ExecuteBatchForm";
            this.Text = "Batch Execution";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExecuteBatchForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workingOnLabel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label totalProgressLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label warningsLabel;
        private System.Windows.Forms.Label errorsLabel;
    }
}