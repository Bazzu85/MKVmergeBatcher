using NLog;
using System;
using System.Windows.Forms;

namespace MKVmergeBatcher.src.help
{

    public partial class AboutForm : Form
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public LocaleManager localeManager = new LocaleManager();
        public AboutForm()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            InitializeComponent();
            localeManager.SetLocale(this);
            RestoreWindowPositionAndSize();
            SetControlsContent();

        }
        private void RestoreWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (MainForm.windowsData.manageTrackWindow.width > 0 && MainForm.windowsData.manageTrackWindow.height > 0)
            {
                //this is mandatory to make the position modification working
                this.StartPosition = FormStartPosition.Manual;
                this.Width = MainForm.windowsData.aboutWindow.width;
                this.Height = MainForm.windowsData.aboutWindow.height;
                this.Top = MainForm.windowsData.aboutWindow.top;
                this.Left = MainForm.windowsData.aboutWindow.left;
                if (MainForm.windowsData.aboutWindow.maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }
        private void SetControlsContent()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            appVersionLabel.Text = "MKVmerge Batcher " + version;
        }

        private void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            SaveWindowPositionAndSize();
        }
        private void SaveWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                MainForm.windowsData.aboutWindow.maximized = true;
            }
            else
            {
                MainForm.windowsData.aboutWindow.maximized = false;
                MainForm.windowsData.aboutWindow.width = this.Width;
                MainForm.windowsData.aboutWindow.height = this.Height;
                MainForm.windowsData.aboutWindow.top = this.Top;
                MainForm.windowsData.aboutWindow.left = this.Left;
            }
        }

        private void githubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Bazzu85/MKVmergeBatcher");
        }

        private void buyMeCoffeePictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.buymeacoffee.com/bazzu85");
        }

        private void discordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/ptZSVtAq");
        }
    }
}
