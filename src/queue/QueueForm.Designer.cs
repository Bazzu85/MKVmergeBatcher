
namespace MKVmergeBatcher.src.queue
{
    partial class QueueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueueForm));
            this.jobsDataGridView = new System.Windows.Forms.DataGridView();
            this.queueContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllOkJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllWarningJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllErrorJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllPendingJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllOkJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllWarningJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllErrorJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoClearOkJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoClearWarningJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoClearErrorJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelsListButtonsPanel = new System.Windows.Forms.Panel();
            this.moveJobDownButton = new System.Windows.Forms.Button();
            this.moveJobUpButton = new System.Windows.Forms.Button();
            this.clearQueueButton = new System.Windows.Forms.Button();
            this.deleteJobButton = new System.Windows.Forms.Button();
            this.moveJobBottomButton = new System.Windows.Forms.Button();
            this.moveJobTopButton = new System.Windows.Forms.Button();
            this.queueToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.stopButton = new System.Windows.Forms.Button();
            this.createBatButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.totalProgressBar = new System.Windows.Forms.ProgressBar();
            this.jobProgressBar = new System.Windows.Forms.ProgressBar();
            this.workingOnLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.queueTimer = new System.Windows.Forms.Timer(this.components);
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameWithoutExtensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileFolderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileFullPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queueDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataGridView)).BeginInit();
            this.queueContextMenuStrip.SuspendLayout();
            this.modelsListButtonsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jobsDataGridView
            // 
            this.jobsDataGridView.AllowUserToAddRows = false;
            this.jobsDataGridView.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.jobsDataGridView, "jobsDataGridView");
            this.jobsDataGridView.AutoGenerateColumns = false;
            this.jobsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jobsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.jobsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.jobsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jobsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameDataGridViewTextBoxColumn,
            this.fileNameWithoutExtensionDataGridViewTextBoxColumn,
            this.fileFolderDataGridViewTextBoxColumn,
            this.fileFullPathDataGridViewTextBoxColumn,
            this.percentageDataGridViewTextBoxColumn,
            this.jobStatusDataGridViewTextBoxColumn,
            this.commandDataGridViewTextBoxColumn,
            this.outputDataGridViewTextBoxColumn});
            this.jobsDataGridView.ContextMenuStrip = this.queueContextMenuStrip;
            this.jobsDataGridView.DataSource = this.jobBindingSource;
            this.jobsDataGridView.MultiSelect = false;
            this.jobsDataGridView.Name = "jobsDataGridView";
            this.jobsDataGridView.ReadOnly = true;
            this.jobsDataGridView.RowHeadersVisible = false;
            this.jobsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jobsDataGridView.SelectionChanged += new System.EventHandler(this.jobsDataGridView_SelectionChanged);
            this.jobsDataGridView.DoubleClick += new System.EventHandler(this.jobsDataGridView_DoubleClick);
            // 
            // queueContextMenuStrip
            // 
            this.queueContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearQueueToolStripMenuItem,
            this.resetAllOkJobsToolStripMenuItem,
            this.resetAllWarningJobsToolStripMenuItem,
            this.resetAllErrorJobsToolStripMenuItem,
            this.clearAllPendingJobsToolStripMenuItem,
            this.clearAllOkJobsToolStripMenuItem,
            this.clearAllWarningJobsToolStripMenuItem,
            this.clearAllErrorJobsToolStripMenuItem,
            this.autoClearOkJobsToolStripMenuItem,
            this.autoClearWarningJobsToolStripMenuItem,
            this.autoClearErrorJobsToolStripMenuItem});
            this.queueContextMenuStrip.Name = "queueContextMenuStrip";
            resources.ApplyResources(this.queueContextMenuStrip, "queueContextMenuStrip");
            // 
            // clearQueueToolStripMenuItem
            // 
            this.clearQueueToolStripMenuItem.Name = "clearQueueToolStripMenuItem";
            resources.ApplyResources(this.clearQueueToolStripMenuItem, "clearQueueToolStripMenuItem");
            this.clearQueueToolStripMenuItem.Click += new System.EventHandler(this.clearQueueToolStripMenuItem_Click_1);
            // 
            // resetAllOkJobsToolStripMenuItem
            // 
            this.resetAllOkJobsToolStripMenuItem.Name = "resetAllOkJobsToolStripMenuItem";
            resources.ApplyResources(this.resetAllOkJobsToolStripMenuItem, "resetAllOkJobsToolStripMenuItem");
            this.resetAllOkJobsToolStripMenuItem.Click += new System.EventHandler(this.resetAllOkJobsToolStripMenuItem_Click);
            // 
            // resetAllWarningJobsToolStripMenuItem
            // 
            this.resetAllWarningJobsToolStripMenuItem.Name = "resetAllWarningJobsToolStripMenuItem";
            resources.ApplyResources(this.resetAllWarningJobsToolStripMenuItem, "resetAllWarningJobsToolStripMenuItem");
            this.resetAllWarningJobsToolStripMenuItem.Click += new System.EventHandler(this.resetAllWarningJobsToolStripMenuItem_Click);
            // 
            // resetAllErrorJobsToolStripMenuItem
            // 
            this.resetAllErrorJobsToolStripMenuItem.Name = "resetAllErrorJobsToolStripMenuItem";
            resources.ApplyResources(this.resetAllErrorJobsToolStripMenuItem, "resetAllErrorJobsToolStripMenuItem");
            this.resetAllErrorJobsToolStripMenuItem.Click += new System.EventHandler(this.resetAllErrorJobsToolStripMenuItem_Click);
            // 
            // clearAllPendingJobsToolStripMenuItem
            // 
            this.clearAllPendingJobsToolStripMenuItem.Name = "clearAllPendingJobsToolStripMenuItem";
            resources.ApplyResources(this.clearAllPendingJobsToolStripMenuItem, "clearAllPendingJobsToolStripMenuItem");
            this.clearAllPendingJobsToolStripMenuItem.Click += new System.EventHandler(this.clearAllPendingJobsToolStripMenuItem_Click);
            // 
            // clearAllOkJobsToolStripMenuItem
            // 
            this.clearAllOkJobsToolStripMenuItem.Name = "clearAllOkJobsToolStripMenuItem";
            resources.ApplyResources(this.clearAllOkJobsToolStripMenuItem, "clearAllOkJobsToolStripMenuItem");
            this.clearAllOkJobsToolStripMenuItem.Click += new System.EventHandler(this.clearAllOkJobsToolStripMenuItem_Click);
            // 
            // clearAllWarningJobsToolStripMenuItem
            // 
            this.clearAllWarningJobsToolStripMenuItem.Name = "clearAllWarningJobsToolStripMenuItem";
            resources.ApplyResources(this.clearAllWarningJobsToolStripMenuItem, "clearAllWarningJobsToolStripMenuItem");
            this.clearAllWarningJobsToolStripMenuItem.Click += new System.EventHandler(this.clearAllWarningJobsToolStripMenuItem_Click);
            // 
            // clearAllErrorJobsToolStripMenuItem
            // 
            this.clearAllErrorJobsToolStripMenuItem.Name = "clearAllErrorJobsToolStripMenuItem";
            resources.ApplyResources(this.clearAllErrorJobsToolStripMenuItem, "clearAllErrorJobsToolStripMenuItem");
            this.clearAllErrorJobsToolStripMenuItem.Click += new System.EventHandler(this.clearAllErrorJobsToolStripMenuItem_Click);
            // 
            // autoClearOkJobsToolStripMenuItem
            // 
            this.autoClearOkJobsToolStripMenuItem.CheckOnClick = true;
            this.autoClearOkJobsToolStripMenuItem.Name = "autoClearOkJobsToolStripMenuItem";
            resources.ApplyResources(this.autoClearOkJobsToolStripMenuItem, "autoClearOkJobsToolStripMenuItem");
            this.autoClearOkJobsToolStripMenuItem.Click += new System.EventHandler(this.autoClearOkJobsToolStripMenuItem_Click);
            // 
            // autoClearWarningJobsToolStripMenuItem
            // 
            this.autoClearWarningJobsToolStripMenuItem.CheckOnClick = true;
            this.autoClearWarningJobsToolStripMenuItem.Name = "autoClearWarningJobsToolStripMenuItem";
            resources.ApplyResources(this.autoClearWarningJobsToolStripMenuItem, "autoClearWarningJobsToolStripMenuItem");
            this.autoClearWarningJobsToolStripMenuItem.Click += new System.EventHandler(this.autoClearWarningJobsToolStripMenuItem_Click);
            // 
            // autoClearErrorJobsToolStripMenuItem
            // 
            this.autoClearErrorJobsToolStripMenuItem.CheckOnClick = true;
            this.autoClearErrorJobsToolStripMenuItem.Name = "autoClearErrorJobsToolStripMenuItem";
            resources.ApplyResources(this.autoClearErrorJobsToolStripMenuItem, "autoClearErrorJobsToolStripMenuItem");
            this.autoClearErrorJobsToolStripMenuItem.Click += new System.EventHandler(this.autoClearErrorJobsToolStripMenuItem_Click);
            // 
            // modelsListButtonsPanel
            // 
            resources.ApplyResources(this.modelsListButtonsPanel, "modelsListButtonsPanel");
            this.modelsListButtonsPanel.Controls.Add(this.moveJobDownButton);
            this.modelsListButtonsPanel.Controls.Add(this.moveJobUpButton);
            this.modelsListButtonsPanel.Controls.Add(this.clearQueueButton);
            this.modelsListButtonsPanel.Controls.Add(this.deleteJobButton);
            this.modelsListButtonsPanel.Controls.Add(this.moveJobBottomButton);
            this.modelsListButtonsPanel.Controls.Add(this.moveJobTopButton);
            this.modelsListButtonsPanel.Name = "modelsListButtonsPanel";
            // 
            // moveJobDownButton
            // 
            resources.ApplyResources(this.moveJobDownButton, "moveJobDownButton");
            this.moveJobDownButton.Name = "moveJobDownButton";
            this.queueToolTip.SetToolTip(this.moveJobDownButton, resources.GetString("moveJobDownButton.ToolTip"));
            this.moveJobDownButton.UseVisualStyleBackColor = true;
            this.moveJobDownButton.Click += new System.EventHandler(this.moveJobDownButton_Click);
            // 
            // moveJobUpButton
            // 
            resources.ApplyResources(this.moveJobUpButton, "moveJobUpButton");
            this.moveJobUpButton.Name = "moveJobUpButton";
            this.queueToolTip.SetToolTip(this.moveJobUpButton, resources.GetString("moveJobUpButton.ToolTip"));
            this.moveJobUpButton.UseVisualStyleBackColor = true;
            this.moveJobUpButton.Click += new System.EventHandler(this.moveJobUpButton_Click);
            // 
            // clearQueueButton
            // 
            resources.ApplyResources(this.clearQueueButton, "clearQueueButton");
            this.clearQueueButton.Name = "clearQueueButton";
            this.queueToolTip.SetToolTip(this.clearQueueButton, resources.GetString("clearQueueButton.ToolTip"));
            this.clearQueueButton.UseVisualStyleBackColor = true;
            this.clearQueueButton.Click += new System.EventHandler(this.clearQueueButton_Click);
            // 
            // deleteJobButton
            // 
            resources.ApplyResources(this.deleteJobButton, "deleteJobButton");
            this.deleteJobButton.Name = "deleteJobButton";
            this.queueToolTip.SetToolTip(this.deleteJobButton, resources.GetString("deleteJobButton.ToolTip"));
            this.deleteJobButton.UseVisualStyleBackColor = true;
            this.deleteJobButton.Click += new System.EventHandler(this.deleteJobButton_Click);
            // 
            // moveJobBottomButton
            // 
            resources.ApplyResources(this.moveJobBottomButton, "moveJobBottomButton");
            this.moveJobBottomButton.Name = "moveJobBottomButton";
            this.queueToolTip.SetToolTip(this.moveJobBottomButton, resources.GetString("moveJobBottomButton.ToolTip"));
            this.moveJobBottomButton.UseVisualStyleBackColor = true;
            this.moveJobBottomButton.Click += new System.EventHandler(this.moveJobBottomButton_Click);
            // 
            // moveJobTopButton
            // 
            resources.ApplyResources(this.moveJobTopButton, "moveJobTopButton");
            this.moveJobTopButton.Name = "moveJobTopButton";
            this.queueToolTip.SetToolTip(this.moveJobTopButton, resources.GetString("moveJobTopButton.ToolTip"));
            this.moveJobTopButton.UseVisualStyleBackColor = true;
            this.moveJobTopButton.Click += new System.EventHandler(this.moveJobTopButton_Click);
            // 
            // stopButton
            // 
            resources.ApplyResources(this.stopButton, "stopButton");
            this.stopButton.Name = "stopButton";
            this.queueToolTip.SetToolTip(this.stopButton, resources.GetString("stopButton.ToolTip"));
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // createBatButton
            // 
            resources.ApplyResources(this.createBatButton, "createBatButton");
            this.createBatButton.Name = "createBatButton";
            this.queueToolTip.SetToolTip(this.createBatButton, resources.GetString("createBatButton.ToolTip"));
            this.createBatButton.UseVisualStyleBackColor = true;
            this.createBatButton.Click += new System.EventHandler(this.createBatButton_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.warningLabel);
            this.panel1.Controls.Add(this.totalProgressBar);
            this.panel1.Controls.Add(this.jobProgressBar);
            this.panel1.Controls.Add(this.workingOnLabel);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.createBatButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Name = "panel1";
            // 
            // errorLabel
            // 
            resources.ApplyResources(this.errorLabel, "errorLabel");
            this.errorLabel.Name = "errorLabel";
            // 
            // warningLabel
            // 
            resources.ApplyResources(this.warningLabel, "warningLabel");
            this.warningLabel.Name = "warningLabel";
            // 
            // totalProgressBar
            // 
            resources.ApplyResources(this.totalProgressBar, "totalProgressBar");
            this.totalProgressBar.Name = "totalProgressBar";
            // 
            // jobProgressBar
            // 
            resources.ApplyResources(this.jobProgressBar, "jobProgressBar");
            this.jobProgressBar.Name = "jobProgressBar";
            // 
            // workingOnLabel
            // 
            resources.ApplyResources(this.workingOnLabel, "workingOnLabel");
            this.workingOnLabel.Name = "workingOnLabel";
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.queueToolTip.SetToolTip(this.startButton, resources.GetString("startButton.ToolTip"));
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // outputTextBox
            // 
            resources.ApplyResources(this.outputTextBox, "outputTextBox");
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            // 
            // queueTimer
            // 
            this.queueTimer.Tick += new System.EventHandler(this.queueTimer_Tick);
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "fileName";
            resources.ApplyResources(this.fileNameDataGridViewTextBoxColumn, "fileNameDataGridViewTextBoxColumn");
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileNameWithoutExtensionDataGridViewTextBoxColumn
            // 
            this.fileNameWithoutExtensionDataGridViewTextBoxColumn.DataPropertyName = "fileNameWithoutExtension";
            resources.ApplyResources(this.fileNameWithoutExtensionDataGridViewTextBoxColumn, "fileNameWithoutExtensionDataGridViewTextBoxColumn");
            this.fileNameWithoutExtensionDataGridViewTextBoxColumn.Name = "fileNameWithoutExtensionDataGridViewTextBoxColumn";
            this.fileNameWithoutExtensionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileFolderDataGridViewTextBoxColumn
            // 
            this.fileFolderDataGridViewTextBoxColumn.DataPropertyName = "fileFolder";
            resources.ApplyResources(this.fileFolderDataGridViewTextBoxColumn, "fileFolderDataGridViewTextBoxColumn");
            this.fileFolderDataGridViewTextBoxColumn.Name = "fileFolderDataGridViewTextBoxColumn";
            this.fileFolderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileFullPathDataGridViewTextBoxColumn
            // 
            this.fileFullPathDataGridViewTextBoxColumn.DataPropertyName = "fileFullPath";
            resources.ApplyResources(this.fileFullPathDataGridViewTextBoxColumn, "fileFullPathDataGridViewTextBoxColumn");
            this.fileFullPathDataGridViewTextBoxColumn.Name = "fileFullPathDataGridViewTextBoxColumn";
            this.fileFullPathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // percentageDataGridViewTextBoxColumn
            // 
            this.percentageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.percentageDataGridViewTextBoxColumn.DataPropertyName = "percentage";
            resources.ApplyResources(this.percentageDataGridViewTextBoxColumn, "percentageDataGridViewTextBoxColumn");
            this.percentageDataGridViewTextBoxColumn.Name = "percentageDataGridViewTextBoxColumn";
            this.percentageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobStatusDataGridViewTextBoxColumn
            // 
            this.jobStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jobStatusDataGridViewTextBoxColumn.DataPropertyName = "jobStatus";
            resources.ApplyResources(this.jobStatusDataGridViewTextBoxColumn, "jobStatusDataGridViewTextBoxColumn");
            this.jobStatusDataGridViewTextBoxColumn.Name = "jobStatusDataGridViewTextBoxColumn";
            this.jobStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commandDataGridViewTextBoxColumn
            // 
            this.commandDataGridViewTextBoxColumn.DataPropertyName = "command";
            resources.ApplyResources(this.commandDataGridViewTextBoxColumn, "commandDataGridViewTextBoxColumn");
            this.commandDataGridViewTextBoxColumn.Name = "commandDataGridViewTextBoxColumn";
            this.commandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // outputDataGridViewTextBoxColumn
            // 
            this.outputDataGridViewTextBoxColumn.DataPropertyName = "output";
            resources.ApplyResources(this.outputDataGridViewTextBoxColumn, "outputDataGridViewTextBoxColumn");
            this.outputDataGridViewTextBoxColumn.Name = "outputDataGridViewTextBoxColumn";
            this.outputDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(MKVmergeBatcher.src.queue.QueueData.Job);
            // 
            // queueDataBindingSource
            // 
            this.queueDataBindingSource.DataSource = typeof(MKVmergeBatcher.src.queue.QueueData);
            // 
            // QueueForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.modelsListButtonsPanel);
            this.Controls.Add(this.jobsDataGridView);
            this.Name = "QueueForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueueForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QueueForm_FormClosed);
            this.Resize += new System.EventHandler(this.QueueForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataGridView)).EndInit();
            this.queueContextMenuStrip.ResumeLayout(false);
            this.modelsListButtonsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.DataGridView jobsDataGridView;
        private System.Windows.Forms.Panel modelsListButtonsPanel;
        private System.Windows.Forms.Button moveJobDownButton;
        private System.Windows.Forms.Button moveJobUpButton;
        private System.Windows.Forms.Button deleteJobButton;
        private System.Windows.Forms.Button moveJobBottomButton;
        private System.Windows.Forms.Button moveJobTopButton;
        private System.Windows.Forms.Button clearQueueButton;
        private System.Windows.Forms.ToolTip queueToolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameWithoutExtensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileFolderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileFullPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputDataGridViewTextBoxColumn;
        private System.Windows.Forms.ProgressBar jobProgressBar;
        private System.Windows.Forms.Label workingOnLabel;
        private System.Windows.Forms.Timer queueTimer;
        private System.Windows.Forms.BindingSource queueDataBindingSource;
        private System.Windows.Forms.ContextMenuStrip queueContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllOkJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllWarningJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllErrorJobsToolStripMenuItem;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.ProgressBar totalProgressBar;
        private System.Windows.Forms.ToolStripMenuItem clearAllOkJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllWarningJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllErrorJobsToolStripMenuItem;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button createBatButton;
        private System.Windows.Forms.ToolStripMenuItem autoClearOkJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoClearWarningJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoClearErrorJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllPendingJobsToolStripMenuItem;
    }
}