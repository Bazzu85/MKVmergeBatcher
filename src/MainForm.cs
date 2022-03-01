using MKVmergeBatcher.src.help;
using MKVmergeBatcher.src.legacy;
using MKVmergeBatcher.src.models;
using MKVmergeBatcher.src.options;
using MKVmergeBatcher.src.queue;
using MKVmergeBatcher.src.windows;
using NLog;
using Octokit;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKVmergeBatcher.src
{
    public partial class MainForm : Form
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public LocaleManager localeManager = new LocaleManager();
        public static OptionsData optionsData = new OptionsData();
        public static OptionsJson optionsJson = new OptionsJson();
        public static LogConfigurationManager logConfigurationManager = new LogConfigurationManager();
        public static MainData mainData = new MainData();
        public static MainJson mainJson = new MainJson();
        public static ModelsData modelsData = new ModelsData();
        public static ModelsJson modelsJson = new ModelsJson();
        public static ModelsForm modelsForm;
        public static WindowsData windowsData = new WindowsData();
        public static WindowsJson windowsJson = new WindowsJson();
        public static QueueData queueData = new QueueData();
        public static QueueJson queueJson = new QueueJson();
        public static QueueManager queueManager = new QueueManager();
        public static QueueForm queueForm;
        public static FormWindowState lastWindowState = new FormWindowState();
        public static Release savedRelease;
        public static VersionManager versionManager = new VersionManager();


        public MainForm()
        {
            InitializeComponent();
            ReadConfigFiles();
            CheckInstance();
            CheckNewVersionAsync();
            RestoreWindowPositionAndSize();
            SetDataSource();
            SetControlsContent();
        }

        private void CheckInstance()
        {
            if (!optionsData.allowMultipleInstaces)
            {
                if (System.Diagnostics.Process.GetProcessesByName(Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
                {
                    MessageBox.Show(Properties.Resources.AnotherInstanceIsCurrentlyRunning, Properties.Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }
        }

        private void ReadConfigFiles()
        {
            optionsJson.ReadOptionsJson();
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            //Console.WriteLine("selectedLogLevel: " + MainForm.optionsData.selectedLogLevel);
            localeManager.SetLocale(this);
            optionsData.SetDefault();
            SetTopMenuTexts();
            mainJson.ReadMainJson();
            modelsJson.ReadModelsJson();
            windowsJson.ReadWindowsJson();
            queueJson.ReadQueueJson();
            
        }
        private async Task CheckNewVersionAsync()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (optionsData.checkUpdates)
            {
                bool newVersionFound = await versionManager.CheckForUpdateAsync();
                if (String.IsNullOrEmpty(versionManager.GetError()))
                {
                    if (newVersionFound)
                    {
                        DialogResult dr = MessageBox.Show(Properties.Resources.NewVersionFound, Properties.Resources.InfoLabel, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start("https://github.com/Bazzu85/MKVmergeBatcher/releases/latest");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(versionManager.GetError(), Properties.Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RestoreWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (MainForm.windowsData.mainWindow.width > 0 && MainForm.windowsData.mainWindow.height > 0)
            {
                //this is mandatory to make the position modification working
                this.StartPosition = FormStartPosition.Manual;
                this.Width = MainForm.windowsData.mainWindow.width;
                this.Height = MainForm.windowsData.mainWindow.height;
                this.Top = MainForm.windowsData.mainWindow.top;
                this.Left = MainForm.windowsData.mainWindow.left;
                if (MainForm.windowsData.mainWindow.maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }
        /// <summary>
        /// Set the locale from the variable from options. When copying to other forms, remember to change the 
        /// </summary>
        private void SetDataSource()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            this.optionsDataBindingSource.DataSource = optionsData;
            this.mainDataBindingSource.DataSource = mainData;
            this.videoFileBindingSource.DataSource = mainData.videoFileList;
            this.modelBindingSource.DataSource = modelsData.modelList;
        }
        private void ResetFormBindings()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            this.optionsDataBindingSource.ResetBindings(false);
            this.mainDataBindingSource.ResetBindings(false);
            this.videoFileBindingSource.ResetBindings(false);
            this.modelBindingSource.ResetBindings(false);
        }
        private void SetControlsContent()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            SetWindowTitle();

            if (MainForm.modelsData.modelList.Count > 0)
            {
                modelsComboBox.SelectedIndex = modelsData.lastModelUsed;
            }

        }

        #region Top Menu Methods
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            string currentLocale = MainForm.optionsData.selectedLocale;
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.ShowDialog();
            optionsJson.WriteOptionsJson();
            if (MainForm.optionsData.selectedLocale != currentLocale)
            {
                localeManager.SetLocale(this);
                SetTopMenuTexts();
                SetWindowTitle();
            }
        }

        private void SetWindowTitle()
        {
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = "MKVmerge Batcher " + version;
        }

        private void SetTopMenuTexts()
        {
            // localization not working automatically for the top menu so need to be setted manually
            fileToolStripMenuItem.Text = Properties.Resources.File;
            importV1UserDatajsonToolStripMenuItem.Text = Properties.Resources.ImportV1UserDatajson;

            viewToolStripMenuItem.Text = Properties.Resources.View;
            modelsToolStripMenuItem.Text = Properties.Resources.Models;
            optionsToolStripMenuItem.Text = Properties.Resources.Options;

            helpToolStripMenuItem.Text = Properties.Resources.Help;
            aboutToolStripMenuItem.Text = Properties.Resources.About;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            SaveData();
            this.Close();
        }

        private void modelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            modelsForm = new ModelsForm(this);
            modelsForm.ShowDialog();
            modelsJson.WriteModelsJson();
        }
        private void importV1UserDatajsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            ImportLegacyForm importLegacyDataForm = new ImportLegacyForm();
            importLegacyDataForm.ShowDialog();
            ResetFormBindings();
            SetControlsContent();
        }
        #endregion

        #region Form Event Methods
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            SaveData();
        }

        private void SaveData()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            SaveWindowPositionAndSize();
            optionsJson.WriteOptionsJson();
            mainJson.WriteMainJson();
            modelsJson.WriteModelsJson();
            windowsJson.WriteWindowsJson();
            queueJson.WriteQueueJson();
            LogManager.Shutdown();
        }
        private void SaveWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                MainForm.windowsData.mainWindow.maximized = true;
            }
            else
            {
                MainForm.windowsData.mainWindow.maximized = false;
                MainForm.windowsData.mainWindow.width = this.Width;
                MainForm.windowsData.mainWindow.height = this.Height;
                MainForm.windowsData.mainWindow.top = this.Top;
                MainForm.windowsData.mainWindow.left = this.Left;
            }
        }
        #endregion

        #region Video File List Methods
        private void VideoFilesPathTextBox_DragDrop(object sender, DragEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (fileList != null && fileList.Length != 0)
            {
                if (!Directory.Exists(fileList[0]))
                {
                    Logger.Debug("VideoFilesPathTextBox_DragDrop: not a directory");
                }
                else
                {
                    VideoFilesPathTextBox.Text = fileList[0];
                }
            }
        }

        private void VideoFilesPathTextBox_DragEnter(object sender, DragEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void BrowseVideoFilesButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (String.IsNullOrEmpty(mainData.videoFilePath))
            {
                mainData.videoFilePath = Directory.GetCurrentDirectory();
            }

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = mainData.videoFilePath,
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
                FileName = "Folder Selection.",
                Multiselect = true

            }
            ;
            if (optionsData.extensionList.Count() > 0)
            {
                string extensionsFilter = "Video Files |";
                for (int i = 0; i < optionsData.extensionList.Count(); i++)
                {
                    extensionsFilter += "*." + optionsData.extensionList[i].extension;
                    if (i != optionsData.extensionList.Count() - 1)
                    {
                        extensionsFilter += ";";
                    }
                }
                openFileDialog.Filter = extensionsFilter;
            }
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                VideoFilesPathTextBox.Text = Path.GetDirectoryName(openFileDialog.FileName);
                GetVideoFileListFromBrowse(openFileDialog);
            }
        }
        private void GetVideoFileListFromBrowse(OpenFileDialog openFileDialog)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            mainData.videoFileList.Clear();
            if (openFileDialog.FileName.Contains("Folder Selection."))
            {
                GetVideoFileListFromDirectory(Path.GetDirectoryName(openFileDialog.FileName));
            }
            else
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    Boolean acceptableFile = CheckIfFileIsAcceptable(file);
                    if (acceptableFile)
                    {
                        mainData.videoFileList.Add(new MainData.VideoFile() { videoFileName = file });
                    }
                }
            }
            videoFileListBox.SelectedIndex = -1;
        }
        private void videoFileListBox_DragDrop(object sender, DragEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            mainData.videoFileList.Clear();
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (fileList != null && fileList.Length != 0)
            {
                foreach (string item in fileList)
                {
                    string file = Path.GetFullPath(item);
                    if (Directory.Exists(file))
                    {
                        GetVideoFileListFromDirectory(file);
                    }
                    else
                    {
                        Logger.Debug(file + " is not a directory");
                        Boolean acceptableFile = CheckIfFileIsAcceptable(file);
                        if (acceptableFile)
                        {
                            mainData.videoFileList.Add(new MainData.VideoFile() { videoFileName = file });
                        }
                    }
                }
            }
            videoFileListBox.SelectedIndex = -1;
        }

        private void GetVideoFileListFromDirectory(string path)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            string[] allFiles;
            if (mainData.SubfolderSearch)
            {
                allFiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            }
            else
            {
                allFiles = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            }
            foreach (string item in allFiles)
            {
                Boolean acceptableFile = CheckIfFileIsAcceptable(item);
                if (!acceptableFile)
                {
                    continue;
                }
                mainData.videoFileList.Add(new MainData.VideoFile() { videoFileName = item });
            }
        }

        private Boolean CheckIfFileIsAcceptable(string item)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            Boolean extensionOk = false;
            foreach (options.OptionsData.Extension ext in optionsData.extensionList)
            {
                if (ext.extension == Path.GetExtension(item).Remove(0, 1).ToLower())
                {
                    extensionOk = true;
                }
            }
            // if the file extension is not allowed, jump to next
            if (!extensionOk)
            {
                return false;
            }
            if (mainData.ApplyFileNameExclusion)
            {
                Boolean fileNameToExclude = false;

                for (int i = 0; i < optionsData.excludeFileNameContainingList.Count(); i++)
                {
                    string efnc = optionsData.excludeFileNameContainingList[i].excludeFileNameContaining;
                    if (item.ToUpper().Contains(efnc.ToUpper()))
                    {
                        fileNameToExclude = true;
                    }
                }
                // if the file name contains an exclusion pattern, jump to next
                if (fileNameToExclude)
                {
                    return false;
                }
            }
            return true;
        }

        private void reverseSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (videoFileListBox.SelectedItems.Count > 0)
            {
                for (int i = 0; i < videoFileListBox.Items.Count; i++)
                {
                    videoFileListBox.SetSelected(i, !videoFileListBox.GetSelected(i));
                }
            }
        }

        private void clearSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (videoFileListBox.SelectedItems.Count > 0)
            {
                videoFileListBox.ClearSelected();
            }
        }
        #endregion

        #region Models methods
        public void ChangeModelComboBoxIndex(int index)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            modelsComboBox.SelectedIndex = index;
        }
        private void modelsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (modelsComboBox.SelectedIndex >= 0)
            {
                modelsData.lastModelUsed = modelsComboBox.SelectedIndex;
            }
        }

        #endregion

        #region DragEnter methods
        private void videoFileListBox_DragEnter(object sender, DragEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        #endregion
        private void addTestModelButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            ModelsData.Model.Track track = new ModelsData.Model.Track()
            {
                type = "Video",
                originalFileNumber = 0,
                originalFileTrackPosition = 0,
                language = "ita",
                name = "Italiano",
                DefaultFlag = true,
                ForcedFlag = true,
                originalFileSuffix = "_ita",
                originalFileExtension = "srt"
            };
            ModelsData.Model.CustomInputFileArguments customInputFileArguments = new ModelsData.Model.CustomInputFileArguments();
            customInputFileArguments.noAttachments = true;
            ModelsData.Model.CustomOutputFileArguments customOutputFileArguments = new ModelsData.Model.CustomOutputFileArguments();
            customOutputFileArguments.emptyTitle = true;
            ModelsData.Model model = new ModelsData.Model();
            model.modelName = "test model " + DateTime.Now.ToString();
            model.trackList.Add(track);
            model.customInputFileArguments = customInputFileArguments;
            model.customOutputFileArguments = customOutputFileArguments;
            modelsData.modelList.Add(model);
        }

        #region Queue Methods
        private void addToQueueButton_Click(object sender, EventArgs e)
        {
            bool result = queueManager.CheckJobs(this);
            if (!result)
            {
                if (!String.IsNullOrEmpty(queueManager.errorList))
                {
                    MessageBox.Show(queueManager.errorList, Properties.Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                queueManager.AddToQueue(this);
                if (MainForm.optionsData.showQueueWhenAdding)
                {
                    ShowQueueForm();
                }
            }
        }
        #endregion

        private void showQueueButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            ShowQueueForm();
        }

        private void ShowQueueForm()
        {
            // if queueForm is never been showed or is closed, generate it again
            if (queueForm == null || queueForm.IsDisposed)
            {
                queueForm = new QueueForm(this);
            }
            queueForm.Show();
            if (queueForm.WindowState == FormWindowState.Minimized)
            {
                queueForm.WindowState = queueForm.GetLastWindowState();
            }

            queueForm.BringToFront();
            System.Windows.Forms.Application.DoEvents();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (MainForm.queueData.running)
            {
                DialogResult dr = MessageBox.Show(this, Properties.Resources.DoYouWantStopCurrentJob, Properties.Resources.WarningLabel, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                if (dr == DialogResult.Yes)
                {
                    queueManager.StopJob();
                    if (MainForm.queueData.running)
                    {
                        MessageBox.Show(Properties.Resources.CannotStopQueue, Properties.Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                        return;
                    }
                }
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // When window state changes
            if (WindowState != lastWindowState)
            {
                if (WindowState == FormWindowState.Maximized || WindowState == FormWindowState.Normal)
                {
                    lastWindowState = WindowState;
                }
            }
        }
    }
}
