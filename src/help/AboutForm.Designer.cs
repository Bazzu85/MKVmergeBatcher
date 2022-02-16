
namespace MKVmergeBatcher.src.help
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.appVersionLabel = new System.Windows.Forms.Label();
            this.githubPictureBox = new System.Windows.Forms.PictureBox();
            this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.buyMeCoffeePictureBox = new System.Windows.Forms.PictureBox();
            this.discordPictureBox = new System.Windows.Forms.PictureBox();
            this.discordLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.githubPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyMeCoffeePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discordPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // appVersionLabel
            // 
            resources.ApplyResources(this.appVersionLabel, "appVersionLabel");
            this.appVersionLabel.Name = "appVersionLabel";
            // 
            // githubPictureBox
            // 
            resources.ApplyResources(this.githubPictureBox, "githubPictureBox");
            this.githubPictureBox.Name = "githubPictureBox";
            this.githubPictureBox.TabStop = false;
            // 
            // githubLinkLabel
            // 
            resources.ApplyResources(this.githubLinkLabel, "githubLinkLabel");
            this.githubLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.githubLinkLabel.Name = "githubLinkLabel";
            this.githubLinkLabel.TabStop = true;
            this.githubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLinkLabel_LinkClicked);
            // 
            // buyMeCoffeePictureBox
            // 
            resources.ApplyResources(this.buyMeCoffeePictureBox, "buyMeCoffeePictureBox");
            this.buyMeCoffeePictureBox.Name = "buyMeCoffeePictureBox";
            this.buyMeCoffeePictureBox.TabStop = false;
            this.buyMeCoffeePictureBox.Click += new System.EventHandler(this.buyMeCoffeePictureBox_Click);
            // 
            // discordPictureBox
            // 
            resources.ApplyResources(this.discordPictureBox, "discordPictureBox");
            this.discordPictureBox.Name = "discordPictureBox";
            this.discordPictureBox.TabStop = false;
            // 
            // discordLinkLabel
            // 
            resources.ApplyResources(this.discordLinkLabel, "discordLinkLabel");
            this.discordLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.discordLinkLabel.Name = "discordLinkLabel";
            this.discordLinkLabel.TabStop = true;
            this.discordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.discordLinkLabel_LinkClicked);
            // 
            // AboutForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buyMeCoffeePictureBox);
            this.Controls.Add(this.discordLinkLabel);
            this.Controls.Add(this.githubLinkLabel);
            this.Controls.Add(this.discordPictureBox);
            this.Controls.Add(this.githubPictureBox);
            this.Controls.Add(this.appVersionLabel);
            this.Name = "AboutForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AboutForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.githubPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyMeCoffeePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discordPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appVersionLabel;
        private System.Windows.Forms.PictureBox githubPictureBox;
        private System.Windows.Forms.LinkLabel githubLinkLabel;
        private System.Windows.Forms.PictureBox buyMeCoffeePictureBox;
        private System.Windows.Forms.PictureBox discordPictureBox;
        private System.Windows.Forms.LinkLabel discordLinkLabel;
    }
}