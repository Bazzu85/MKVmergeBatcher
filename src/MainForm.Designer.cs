
namespace MKVmergeBatcher.src
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importV1UserDatajsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoFilePathLabel = new System.Windows.Forms.Label();
            this.VideoFilesPathTextBox = new System.Windows.Forms.TextBox();
            this.mainDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BrowseVideoFilesButton = new System.Windows.Forms.Button();
            this.videoFileListBox = new System.Windows.Forms.ListBox();
            this.videoFileListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reverseSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.optionsDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addToQueueButton = new System.Windows.Forms.Button();
            this.showQueueButton = new System.Windows.Forms.Button();
            this.subfolderSearchCheckBox = new System.Windows.Forms.CheckBox();
            this.applyFileNameExclusionCheckBox = new System.Windows.Forms.CheckBox();
            this.modelsComboBox = new System.Windows.Forms.ComboBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addTestModelButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataBindingSource)).BeginInit();
            this.videoFileListContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoFileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importV1UserDatajsonToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // importV1UserDatajsonToolStripMenuItem
            // 
            resources.ApplyResources(this.importV1UserDatajsonToolStripMenuItem, "importV1UserDatajsonToolStripMenuItem");
            this.importV1UserDatajsonToolStripMenuItem.Name = "importV1UserDatajsonToolStripMenuItem";
            this.importV1UserDatajsonToolStripMenuItem.Click += new System.EventHandler(this.importV1UserDatajsonToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            // 
            // modelsToolStripMenuItem
            // 
            resources.ApplyResources(this.modelsToolStripMenuItem, "modelsToolStripMenuItem");
            this.modelsToolStripMenuItem.Name = "modelsToolStripMenuItem";
            this.modelsToolStripMenuItem.Click += new System.EventHandler(this.modelsToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // videoFilePathLabel
            // 
            resources.ApplyResources(this.videoFilePathLabel, "videoFilePathLabel");
            this.videoFilePathLabel.Name = "videoFilePathLabel";
            // 
            // VideoFilesPathTextBox
            // 
            resources.ApplyResources(this.VideoFilesPathTextBox, "VideoFilesPathTextBox");
            this.VideoFilesPathTextBox.AllowDrop = true;
            this.VideoFilesPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainDataBindingSource, "videoFilePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.VideoFilesPathTextBox.Name = "VideoFilesPathTextBox";
            this.VideoFilesPathTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.VideoFilesPathTextBox_DragDrop);
            this.VideoFilesPathTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.VideoFilesPathTextBox_DragEnter);
            // 
            // mainDataBindingSource
            // 
            this.mainDataBindingSource.DataSource = typeof(MKVmergeBatcher.src.MainData);
            // 
            // BrowseVideoFilesButton
            // 
            resources.ApplyResources(this.BrowseVideoFilesButton, "BrowseVideoFilesButton");
            this.BrowseVideoFilesButton.Name = "BrowseVideoFilesButton";
            this.BrowseVideoFilesButton.UseVisualStyleBackColor = true;
            this.BrowseVideoFilesButton.Click += new System.EventHandler(this.BrowseVideoFilesButton_Click);
            // 
            // videoFileListBox
            // 
            resources.ApplyResources(this.videoFileListBox, "videoFileListBox");
            this.videoFileListBox.AllowDrop = true;
            this.videoFileListBox.ContextMenuStrip = this.videoFileListContextMenuStrip;
            this.videoFileListBox.DataSource = this.videoFileBindingSource;
            this.videoFileListBox.DisplayMember = "videoFileName";
            this.videoFileListBox.FormattingEnabled = true;
            this.videoFileListBox.Name = "videoFileListBox";
            this.videoFileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.videoFileListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.videoFileListBox_DragDrop);
            this.videoFileListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.videoFileListBox_DragEnter);
            // 
            // videoFileListContextMenuStrip
            // 
            resources.ApplyResources(this.videoFileListContextMenuStrip, "videoFileListContextMenuStrip");
            this.videoFileListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reverseSelectionToolStripMenuItem,
            this.clearSelectionToolStripMenuItem});
            this.videoFileListContextMenuStrip.Name = "videoFileListContextMenuStrip";
            // 
            // reverseSelectionToolStripMenuItem
            // 
            resources.ApplyResources(this.reverseSelectionToolStripMenuItem, "reverseSelectionToolStripMenuItem");
            this.reverseSelectionToolStripMenuItem.Name = "reverseSelectionToolStripMenuItem";
            this.reverseSelectionToolStripMenuItem.Click += new System.EventHandler(this.reverseSelectionToolStripMenuItem_Click);
            // 
            // clearSelectionToolStripMenuItem
            // 
            resources.ApplyResources(this.clearSelectionToolStripMenuItem, "clearSelectionToolStripMenuItem");
            this.clearSelectionToolStripMenuItem.Name = "clearSelectionToolStripMenuItem";
            this.clearSelectionToolStripMenuItem.Click += new System.EventHandler(this.clearSelectionToolStripMenuItem_Click);
            // 
            // videoFileBindingSource
            // 
            this.videoFileBindingSource.DataSource = typeof(MKVmergeBatcher.src.MainData.VideoFile);
            // 
            // optionsDataBindingSource
            // 
            this.optionsDataBindingSource.DataSource = typeof(MKVmergeBatcher.src.options.OptionsData);
            // 
            // addToQueueButton
            // 
            resources.ApplyResources(this.addToQueueButton, "addToQueueButton");
            this.addToQueueButton.FlatAppearance.BorderSize = 0;
            this.addToQueueButton.Name = "addToQueueButton";
            this.addToQueueButton.UseVisualStyleBackColor = true;
            this.addToQueueButton.Click += new System.EventHandler(this.addToQueueButton_Click);
            // 
            // showQueueButton
            // 
            resources.ApplyResources(this.showQueueButton, "showQueueButton");
            this.showQueueButton.FlatAppearance.BorderSize = 0;
            this.showQueueButton.Name = "showQueueButton";
            this.showQueueButton.UseVisualStyleBackColor = true;
            this.showQueueButton.Click += new System.EventHandler(this.showQueueButton_Click);
            // 
            // subfolderSearchCheckBox
            // 
            resources.ApplyResources(this.subfolderSearchCheckBox, "subfolderSearchCheckBox");
            this.subfolderSearchCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mainDataBindingSource, "SubfolderSearch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.subfolderSearchCheckBox.Name = "subfolderSearchCheckBox";
            this.subfolderSearchCheckBox.UseVisualStyleBackColor = true;
            // 
            // applyFileNameExclusionCheckBox
            // 
            resources.ApplyResources(this.applyFileNameExclusionCheckBox, "applyFileNameExclusionCheckBox");
            this.applyFileNameExclusionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mainDataBindingSource, "ApplyFileNameExclusion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.applyFileNameExclusionCheckBox.Name = "applyFileNameExclusionCheckBox";
            this.applyFileNameExclusionCheckBox.UseVisualStyleBackColor = true;
            // 
            // modelsComboBox
            // 
            resources.ApplyResources(this.modelsComboBox, "modelsComboBox");
            this.modelsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.modelsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.modelsComboBox.DataSource = this.modelBindingSource;
            this.modelsComboBox.DisplayMember = "modelName";
            this.modelsComboBox.FormattingEnabled = true;
            this.modelsComboBox.Name = "modelsComboBox";
            this.modelsComboBox.SelectedIndexChanged += new System.EventHandler(this.modelsComboBox_SelectedIndexChanged);
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(MKVmergeBatcher.src.models.ModelsData.Model);
            // 
            // addTestModelButton
            // 
            resources.ApplyResources(this.addTestModelButton, "addTestModelButton");
            this.addTestModelButton.Name = "addTestModelButton";
            this.addTestModelButton.UseVisualStyleBackColor = true;
            this.addTestModelButton.Click += new System.EventHandler(this.addTestModelButton_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addTestModelButton);
            this.Controls.Add(this.modelsComboBox);
            this.Controls.Add(this.applyFileNameExclusionCheckBox);
            this.Controls.Add(this.subfolderSearchCheckBox);
            this.Controls.Add(this.showQueueButton);
            this.Controls.Add(this.addToQueueButton);
            this.Controls.Add(this.videoFileListBox);
            this.Controls.Add(this.BrowseVideoFilesButton);
            this.Controls.Add(this.VideoFilesPathTextBox);
            this.Controls.Add(this.videoFilePathLabel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataBindingSource)).EndInit();
            this.videoFileListContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoFileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.BindingSource optionsDataBindingSource;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label videoFilePathLabel;
        private System.Windows.Forms.TextBox VideoFilesPathTextBox;
        private System.Windows.Forms.Button BrowseVideoFilesButton;
        private System.Windows.Forms.BindingSource mainDataBindingSource;
        private System.Windows.Forms.BindingSource videoFileBindingSource;
        private System.Windows.Forms.Button addToQueueButton;
        private System.Windows.Forms.Button showQueueButton;
        private System.Windows.Forms.CheckBox subfolderSearchCheckBox;
        private System.Windows.Forms.CheckBox applyFileNameExclusionCheckBox;
        private System.Windows.Forms.Button addTestModelButton;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelsToolStripMenuItem;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.ContextMenuStrip videoFileListContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem reverseSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importV1UserDatajsonToolStripMenuItem;
        public System.Windows.Forms.ListBox videoFileListBox;
        public System.Windows.Forms.ComboBox modelsComboBox;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

