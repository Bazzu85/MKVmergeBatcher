
namespace MKVmergeBatcher.src.queue
{
    partial class JobForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileFolderTextBox = new System.Windows.Forms.TextBox();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileFullPathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.percentageTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.jobStatusTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.outputFileNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // fileFolderTextBox
            // 
            resources.ApplyResources(this.fileFolderTextBox, "fileFolderTextBox");
            this.fileFolderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "fileFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fileFolderTextBox.Name = "fileFolderTextBox";
            this.fileFolderTextBox.ReadOnly = true;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(MKVmergeBatcher.src.queue.QueueData.Job);
            // 
            // fileNameTextBox
            // 
            resources.ApplyResources(this.fileNameTextBox, "fileNameTextBox");
            this.fileNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "fileName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // fileFullPathTextBox
            // 
            resources.ApplyResources(this.fileFullPathTextBox, "fileFullPathTextBox");
            this.fileFullPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "fileFullPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fileFullPathTextBox.Name = "fileFullPathTextBox";
            this.fileFullPathTextBox.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // percentageTextBox
            // 
            this.percentageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "percentage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.percentageTextBox, "percentageTextBox");
            this.percentageTextBox.Name = "percentageTextBox";
            this.percentageTextBox.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // jobStatusTextBox
            // 
            this.jobStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "jobStatus", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.jobStatusTextBox, "jobStatusTextBox");
            this.jobStatusTextBox.Name = "jobStatusTextBox";
            this.jobStatusTextBox.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // outputFileNameTextBox
            // 
            resources.ApplyResources(this.outputFileNameTextBox, "outputFileNameTextBox");
            this.outputFileNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "outputFileName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.outputFileNameTextBox.Name = "outputFileNameTextBox";
            this.outputFileNameTextBox.ReadOnly = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // commandTextBox
            // 
            resources.ApplyResources(this.commandTextBox, "commandTextBox");
            this.commandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "command", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.ReadOnly = true;
            // 
            // outputTextBox
            // 
            resources.ApplyResources(this.outputTextBox, "outputTextBox");
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // JobForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.fileFullPathTextBox);
            this.Controls.Add(this.outputFileNameTextBox);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.jobStatusTextBox);
            this.Controls.Add(this.percentageTextBox);
            this.Controls.Add(this.fileFolderTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JobForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JobForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileFolderTextBox;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileFullPathTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox percentageTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox jobStatusTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox outputFileNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer refreshTimer;
    }
}