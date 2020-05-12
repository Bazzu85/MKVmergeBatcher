namespace MKVmergeBatcher
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBatcher = new System.Windows.Forms.TabPage();
            this.tabManageModels = new System.Windows.Forms.TabPage();
            this.tabModelCreator = new System.Windows.Forms.TabPage();
            this.MCAddAudioButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabModelCreator.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBatcher);
            this.tabControl1.Controls.Add(this.tabManageModels);
            this.tabControl1.Controls.Add(this.tabModelCreator);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBatcher
            // 
            this.tabBatcher.Location = new System.Drawing.Point(4, 22);
            this.tabBatcher.Name = "tabBatcher";
            this.tabBatcher.Padding = new System.Windows.Forms.Padding(3);
            this.tabBatcher.Size = new System.Drawing.Size(792, 400);
            this.tabBatcher.TabIndex = 0;
            this.tabBatcher.Text = "Batcher";
            this.tabBatcher.UseVisualStyleBackColor = true;
            // 
            // tabManageModels
            // 
            this.tabManageModels.Location = new System.Drawing.Point(4, 22);
            this.tabManageModels.Name = "tabManageModels";
            this.tabManageModels.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageModels.Size = new System.Drawing.Size(792, 400);
            this.tabManageModels.TabIndex = 1;
            this.tabManageModels.Text = "Manage Models";
            this.tabManageModels.UseVisualStyleBackColor = true;
            // 
            // tabModelCreator
            // 
            this.tabModelCreator.Controls.Add(this.MCAddAudioButton);
            this.tabModelCreator.Location = new System.Drawing.Point(4, 22);
            this.tabModelCreator.Name = "tabModelCreator";
            this.tabModelCreator.Size = new System.Drawing.Size(792, 400);
            this.tabModelCreator.TabIndex = 2;
            this.tabModelCreator.Text = "Model Creator";
            this.tabModelCreator.UseVisualStyleBackColor = true;
            // 
            // MCAddAudioButton
            // 
            this.MCAddAudioButton.Location = new System.Drawing.Point(8, 3);
            this.MCAddAudioButton.Name = "MCAddAudioButton";
            this.MCAddAudioButton.Size = new System.Drawing.Size(107, 23);
            this.MCAddAudioButton.TabIndex = 0;
            this.MCAddAudioButton.Text = "Add Audio Track";
            this.MCAddAudioButton.UseVisualStyleBackColor = true;
            this.MCAddAudioButton.Click += new System.EventHandler(this.MCAddAudioButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MKVmerge Batcher";
            this.tabControl1.ResumeLayout(false);
            this.tabModelCreator.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBatcher;
        private System.Windows.Forms.TabPage tabManageModels;
        private System.Windows.Forms.TabPage tabModelCreator;
        private System.Windows.Forms.Button MCAddAudioButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    }
}

