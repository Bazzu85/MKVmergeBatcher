using MKVmergeBatcher.src.models;
using MKVmergeBatcher.src.options;
using NLog;
using System;
using System.IO;
using System.Windows.Forms;

namespace MKVmergeBatcher.src.legacy
{
    public partial class ImportLegacyForm : Form
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public static UserData userData = new UserData();
        public static UserDataJson userDataJson = new UserDataJson();
        public static ImportLegacyData importLegacyData = new ImportLegacyData();
        public static ImportLegacyJson importLegacyJson = new ImportLegacyJson();
        public Boolean importRunning = false;

        public Boolean imported = false;

        public ImportLegacyForm()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            InitializeComponent();
            RestoreWindowPositionAndSize();
            ReadConfigFiles();
            SetDataSource();
        }
        private void RestoreWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (MainForm.windowsData.importLegacyWindow.width > 0 && MainForm.windowsData.importLegacyWindow.height > 0 && MainForm.windowsData.importLegacyWindow.top > 0 && MainForm.windowsData.importLegacyWindow.left > 0)
            {
                //this is mandatory to make the position modification working
                this.StartPosition = FormStartPosition.Manual;
                this.Width = MainForm.windowsData.importLegacyWindow.width;
                this.Height = MainForm.windowsData.importLegacyWindow.height;
                this.Top = MainForm.windowsData.importLegacyWindow.top;
                this.Left = MainForm.windowsData.importLegacyWindow.left;
                if (MainForm.windowsData.importLegacyWindow.maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }
        private void SetDataSource()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            this.importLegacyDataBindingSource.DataSource = importLegacyData;
        }

        private void ReadConfigFiles()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            importLegacyJson.ReadImportLegacyJson(); ;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (String.IsNullOrEmpty(importLegacyData.oldUserDataJson))
            {
                importLegacyData.oldUserDataJson = Directory.GetCurrentDirectory() + "\\";
            }
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Path.GetDirectoryName(importLegacyData.oldUserDataJson),
                Filter = Properties.Resources.JsonFiles + " (*.json)|*.json"
            }
            ;
            if (openFileDialog.ShowDialog() == DialogResult.OK && Path.GetFileName(openFileDialog.FileName).ToLower() == "userdata.json")
            {
                oldUserDataTextBox.Text = openFileDialog.FileName;
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (!String.IsNullOrEmpty(oldUserDataTextBox.Text))
            {
                DialogResult dr = MessageBox.Show(this, Properties.Resources.AreYouSurePleaseMakeBackup, Properties.Resources.WarningLabel, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    Boolean readOk = userDataJson.ReadUserDataJson(oldUserDataTextBox.Text);
                    if (readOk)
                    {
                        Logger.Info("Importing UserData.json from " + oldUserDataTextBox.Text);
                        importRunning = true;
                        MoveFromUserDataToCurrentData();
                        importRunning = false;

                        Logger.Info("Imported UserData.json from " + oldUserDataTextBox.Text);
                        MessageBox.Show(this, Properties.Resources.UserDataImported, Properties.Resources.InfoLabel, MessageBoxButtons.OK);
                        this.Close();
                    }
                }
            }
        }

        private void MoveFromUserDataToCurrentData()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            #region optionsData
            #region mkvMergeLocation
            MainForm.optionsData.mkvMergeLocation = userData.batcher.mvkMergePath;
            #endregion


            #region extensionList
            MainForm.optionsData.extensionList.Clear();
            foreach (string videoExtension in userData.batcher.videoExtensionList)
            {
                MainForm.optionsData.extensionList.Add(new OptionsData.Extension() { extension = videoExtension });
            }
            #endregion
            #region excludeFileNameContainingList
            MainForm.optionsData.excludeFileNameContainingList.Clear();
            foreach (UserData.Options.ExcludeFileNameContaining item in userData.options.excludeFileNameContainingList)
            {
                MainForm.optionsData.excludeFileNameContainingList.Add(new options.OptionsData.ExcludeFileNameContaining() { excludeFileNameContaining = item.fileNameContaning });
            }
            #endregion
            #region moveOkFilesTo
            MainForm.optionsData.moveOkFilesTo = userData.options.moveOkFilesTo.Replace("%originalFolder%", "||originalFolder||");
            #endregion
            #region moveWarningFilesTo
            MainForm.optionsData.moveWarningFilesTo = userData.options.moveWarningFilesTo.Replace("%originalFolder%", "||originalFolder||");
            #endregion
            #region replaceExistingDestinationFiles
            MainForm.optionsData.replaceExistingDestinationFiles = userData.options.replaceExistingDestinationFile;
            #endregion
            #region deleteIncompleteFile
            MainForm.optionsData.deleteIncompleteFiles = userData.options.deleteIncompleteFile;
            #endregion
            #region autoClearOkJobs
            MainForm.optionsData.autoClearOkJobs = userData.modelCreator.additionalFlags.autoClearOkJobs;
            #endregion
            #region autoClearWarningJobs
            MainForm.optionsData.autoClearWarningJobs = userData.modelCreator.additionalFlags.autoClearWarningJobs;
            #endregion
            #region autoClearErrorJobs
            MainForm.optionsData.autoClearWarningJobs = userData.modelCreator.additionalFlags.autoClearWarningJobs;
            #endregion
            #endregion

            #region mainData
            #region videoFilePath
            MainForm.mainData.videoFilePath = userData.batcher.lastVideoPath;
            #endregion
            #endregion

            #region modelsData
            #region modelList
            MainForm.modelsData.modelList.Clear();
            int i = 0;
            importProgressBar.Maximum = userData.modelManagement.modelList.Count;
            importProgressBar.Value = 0;
            foreach (UserData.ModelManagement.Model item in userData.modelManagement.modelList)
            {
                i++;
                importLabel.Visible = true;
                importLabel.Text = Properties.Resources.WorkingOnModel + " " + i + " " + Properties.Resources.Of + " " + userData.modelManagement.modelList.Count;
                importProgressBar.Visible = true;
                importProgressBar.Value = i;
                //this method allow to apply the text in real time
                //https://docs.microsoft.com/it-it/dotnet/api/system.windows.forms.application.doevents?view=windowsdesktop-6.0
                Application.DoEvents();
                item.modelContent = item.modelContent.Replace("||inputFileName||", "||inputFileFolder||\\||inputFileName||");
                item.modelContent = item.modelContent.Replace("||inputFileNameWithoutExtension||", "||inputFileFolder||\\||inputFileNameWithoutExtension||");
                item.modelContent = item.modelContent.Replace("||outputFileName||", "||outputFileFullPath||");
                MainForm.modelsData.modelList.Add(new ModelsData.Model()
                {
                    modelName = item.modelName,
                    customCommand = true,
                    command = item.modelContent
                });
            }
            #endregion
            #region lastModelUsed
            MainForm.modelsData.lastModelUsed = userData.batcher.lastUsedModel;
            #endregion

            #endregion

        }

        private void oldUserDataTextBox_DragEnter(object sender, DragEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void oldUserDataTextBox_DragDrop(object sender, DragEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (fileList != null && fileList.Length != 0)
            {
                if (Directory.Exists(fileList[0]))
                {
                    Logger.Debug("oldUserDataTextBox_DragDrop: used a directory");
                }
                else
                {
                    if (Path.GetFileName(fileList[0]).ToLower() != "userdata.json")
                    {
                        Logger.Debug("oldUserDataTextBox_DragDrop: not userData file");
                    }
                    else
                    {
                        oldUserDataTextBox.Text = fileList[0];
                    }
                }
            }
        }

        private void ImportLegacyDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            SaveWindowPositionAndSize();
            importLegacyJson.WriteImportLegacyJson();
        }
        private void SaveWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                MainForm.windowsData.importLegacyWindow.maximized = true;
            }
            else
            {
                MainForm.windowsData.importLegacyWindow.maximized = false;
                MainForm.windowsData.importLegacyWindow.width = this.Width;
                MainForm.windowsData.importLegacyWindow.height = this.Height;
                MainForm.windowsData.importLegacyWindow.top = this.Top;
                MainForm.windowsData.importLegacyWindow.left = this.Left;
            }
        }

        private void ImportLegacyDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            //if the import is running, cancel the close request
            if (importRunning)
            {
                e.Cancel = true;
            }
        }
    }
}
