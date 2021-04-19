using MKVmergeBatcher.Properties;
using MKVmergeBatcher.src;
using MKVmergeBatcher.src.obj;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MKVmergeBatcher
{

    public partial class Form1 : Form
    {
        #region Variables

        UserData userData = new UserData();
        UserDataJsonManagement userDataJsonManagement = new UserDataJsonManagement();


        #endregion
        public Form1()
        {
            userData = userDataJsonManagement.ReadUserData();

            InitializeComponent();
            RestoreWindowData();
            SetDataSources();
            SetLabels();
            SetLastModelUsed();

        }
        #region Manage Window Data with Properties (save/restore)
        private void SaveWindowData()
        {

            // Copy window size to app settings
            if (this.WindowState == FormWindowState.Normal)
            {
                Settings.Default.WindowSize = this.Size;
            }
            else
            {
                Settings.Default.WindowSize = this.RestoreBounds.Size;
            }

            if (this.WindowState == FormWindowState.Maximized)
            {
                Settings.Default.WindowMaximized = true;
            }
            else
            {
                Settings.Default.WindowMaximized = false;

                // Ovverride the Settings.Default.WindowLocation only if not maximized
                // This is to prevent loss of location returning normal from maximize
                Settings.Default.WindowLocation = this.Location;

            }
            // Save settings
            Settings.Default.Save();
            Settings.Default.Reload();

        }
        private void SaveLastUsedModel()
        {
            if (userData.modelManagement.modelList.Count > 0 && BTCModelsComboBox.SelectedIndex >= 0)
            {
                userData.batcher.lastUsedModel = BTCModelsComboBox.SelectedIndex;
            }
        }

        private void RestoreWindowData()
        {
            //If CallUpgrade boolean is true (new defined settings by new build number)
            //   call the settings upgrade from previous version
            //   set the CallUpgrade to false to prevent this part for future app launch with this version
            if (Settings.Default.CallUpgrade)
            {
                Settings.Default.Upgrade();
                Settings.Default.CallUpgrade = false;
            }

            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;

            // Set window locationaaa
            if (Settings.Default.WindowLocation != null)
            {
                this.Location = Settings.Default.WindowLocation;
            }

            // Set window size
            if (Settings.Default.WindowSize != null)
            {
                this.Size = Settings.Default.WindowSize;
            }

            if (Settings.Default.WindowMaximized == true)
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }
        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            //2021-04-19 remove as the location and windows state where not saved anymore
            //SaveWindowData();
        }

        #endregion
        #region Generics Methods
        private void SetDataSources()
        {
            //The association of MCDataGridView.DataSource to tracksBindingSource need to be here
            //if specified in designer, Visual Studio add the column in data source automatically 
            this.MCDataGridView.DataSource = this.tracksBindingSource;
            this.tracksBindingSource.DataSource = userData.modelCreator.tracks;
            this.typeBindingSource.DataSource = userData.modelCreator.typeList;
            this.additionalFlagsBindingSource.DataSource = userData.modelCreator.additionalFlags;
            this.batcherBindingSource.DataSource = userData.batcher;
            this.modelBindingSource.DataSource = userData.modelManagement.modelList;
            this.queueBindingSource.DataSource = userData.queueManagement.queueList;
        }
        private void SetLabels()
        {
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
this.Text = "MKVmerge Batcher " + version;
        }

        private void SetLastModelUsed()
        {
            if (userData.modelManagement.modelList.Count > 0)
            {
                BTCModelsComboBox.SelectedIndex = userData.batcher.lastUsedModel;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveWindowData();
            SaveLastUsedModel();
            userData = userDataJsonManagement.WriteUserData(userData);
            //After the form is closed the components.Dispose() is called.
            //sometimes the code throw a bad System.IndexOutOfRangeException for apparently no reason 
            //in this method the DataGridView is corretcly populated
            //Disposing the resource release now prevent this error lately
            this.MCDataGridView.Dispose();
        }
        #endregion

        #region Top Menu methods
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveWindowData();
            SaveLastUsedModel();
            userDataJsonManagement.WriteUserData(userData);
            this.Close();
        }

        #endregion

        #region Model Creator Methods

        private void MCTrackRemoveSelectedButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.MCDataGridView.SelectedRows)
            {
                int i = item.Index;
                if (userData.modelCreator.tracks.Count > i)
                {
                    userData.modelCreator.tracks.RemoveAt(i);
                }
            }
            this.tracksBindingSource.ResetBindings(false);
        }

        private void MCTrackClearListButton_Click(object sender, EventArgs e)
        {
            if (userData.modelCreator.tracks.Count > 0)
            {
                this.userData.modelCreator.tracks.Clear();
            }
        }

        private void MCTrackMoveUpButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.MCDataGridView.SelectedRows)
            {
                int i = item.Index;

                if (i == 0)
                {
                    return;
                }
                else
                {
                    MCMoveTracksDataViewGridRow(i, i - 1);
                }
            }
        }

        private void MCTrackMoveDownButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.MCDataGridView.SelectedRows)
            {
                int i = item.Index;

                if (i == userData.modelCreator.tracks.Count - 1)
                {
                    return;
                }
                else
                {
                    MCMoveTracksDataViewGridRow(i, i + 1);
                }
            }
        }

        /// <summary>
        /// Move row from source to destination in MCDataGridView
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="destination">destination</param>
        private void MCMoveTracksDataViewGridRow(int source, int destination)
        {
            var tmp = userData.modelCreator.tracks[destination];
            userData.modelCreator.tracks[destination] = userData.modelCreator.tracks[source];
            userData.modelCreator.tracks[source] = tmp;
            MCDataGridView.Rows[destination].Selected = true;
        }

        private void MCPreviewButton_Click(object sender, EventArgs e)
        {
            ModelCreatorManagement modelCreatorManagement = new ModelCreatorManagement(this.userData);
            string errorList = modelCreatorManagement.CheckLists();
            if (!String.IsNullOrEmpty(errorList))
            {
                MessageBox.Show(errorList, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.userData = modelCreatorManagement.userData;
            ModelCreatorPreviewForm modelCreatorPreviewForm = new ModelCreatorPreviewForm(this.userData);
            modelCreatorPreviewForm.ShowDialog();
            if (modelCreatorPreviewForm.DialogResult == DialogResult.OK)
            {
                this.userData = modelCreatorPreviewForm.userData;
                ClearQueue();
            }
        }
        private void MCSaveDefaultButton_Click(object sender, EventArgs e)
        {
            this.userData.modelCreator.defaultTracks.Clear();
            //Using the SerializeObject and DeserializeObject create a totaly new instance of the tracklist to save
            //avoiding the modification reflection between BindingList<Tracks> defaultTracks and BindingList<Tracks> tracks
            List<UserData.ModelCreator.Tracks> tracks = JsonConvert.DeserializeObject<List<UserData.ModelCreator.Tracks>>(JsonConvert.SerializeObject(this.userData.modelCreator.tracks));
            foreach (UserData.ModelCreator.Tracks track in tracks)
            {
                this.userData.modelCreator.defaultTracks.Add(track);
            }

        }

        private void MCLoadDefaultButton_Click(object sender, EventArgs e)
        {
            this.userData.modelCreator.tracks.Clear();
            //Using the SerializeObject and DeserializeObject create a totaly new instance of the tracklist to load
            //avoiding the modification reflection between BindingList<Tracks> defaultTracks and BindingList<Tracks> tracks
            List<UserData.ModelCreator.Tracks> defaultTracks = JsonConvert.DeserializeObject<List<UserData.ModelCreator.Tracks>>(JsonConvert.SerializeObject(this.userData.modelCreator.defaultTracks));
            foreach (UserData.ModelCreator.Tracks track in defaultTracks)
            {
                this.userData.modelCreator.tracks.Add(track);
            }
        }

        private void MCDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            string error = "Error in datagridview: " + "Column: " + e.ColumnIndex + " Row: " + e.RowIndex + " Error: " + e.Exception;
            MessageBox.Show(this, error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Batcher Methods
        private void BTCMkvMergePathBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = userData.batcher.mvkMergePath,
                Filter = "exe files (*.exe)|*.exe"

            }
            ;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                userData.batcher.mvkMergePath = openFileDialog.FileName;
            }
        }

        private void BTCVideoBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = userData.batcher.lastVideoPath,
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
                FileName = "Folder Selection.",
                Multiselect = true

            }
            ;
            //update the list videoExtensionList splitting videoExtensions
            string[] array = userData.batcher.videoExtensions.Split(',');
            userData.batcher.videoExtensionList.Clear();
            if (array.Length != 0)
            {
                userData.batcher.videoExtensionList = array.ToList();
            }
            if (userData.batcher.videoExtensionList.Count() > 0)
            {
                string extensionsFilter = "Video Files |";
                int i = 0;
                foreach (string item in userData.batcher.videoExtensionList)
                {
                    i++;
                    extensionsFilter += "*." + item;
                    if (i < userData.batcher.videoExtensionList.Count())
                    {
                        extensionsFilter += ";";
                    }
                }
                openFileDialog.Filter = extensionsFilter;
            }
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                userData.batcher.lastVideoPath = Path.GetDirectoryName(openFileDialog.FileName);
                GetVideoFileNameList(openFileDialog);
                BTCVideoFilesListBox.Items.Clear();
                foreach (string item in userData.batcher.videoFileList)
                {
                    BTCVideoFilesListBox.Items.Add(item);
                }

            }
        }

        private void GetVideoFileNameList(OpenFileDialog openFileDialog)
        {
            userData.batcher.videoFileList.Clear();
            if (openFileDialog.FileName.Contains("Folder Selection."))
            {
                string[] allFiles = Directory.GetFiles(Path.GetDirectoryName(openFileDialog.FileName), "*.*", SearchOption.AllDirectories);
                List<string> allFilesList = new List<string>();
                foreach (string item in allFiles)
                {
                    if (userData.batcher.videoExtensions.Contains(Path.GetExtension(item).Remove(0, 1)))
                    {
                        userData.batcher.videoFileList.Add(item);
                    }
                }
            }
            else
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    userData.batcher.videoFileList.Add(file);
                }
            }
        }

        /*
        private void BTCVideoExtensionsTextBox_TextChanged(object sender, EventArgs e)
        {
            //update the list videoExtensionList splitting videoExtensions
            string[] array = userData.batcher.videoExtensions.Split(',');
            userData.batcher.videoExtensionList.Clear();
            if (array.Length != 0)
            {
                userData.batcher.videoExtensionList = array.ToList();
            }
        }
        */

        private void BTCVideoExtensionsTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.Show("Video file filter format: ext1,ext2,ext3", BTCVideoExtensionsTextBox, 100, 0, 1000);
        }

        private void BTCCleanSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BTCVideoFilesListBox.Items.Count > 0)
            {
                BTCVideoFilesListBox.ClearSelected();
            }
        }

        private void BTCReverseSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BTCVideoFilesListBox.Items.Count > 0)
            {
                for (int i = 0; i < BTCVideoFilesListBox.Items.Count; i++)
                {
                    BTCVideoFilesListBox.SetSelected(i, !BTCVideoFilesListBox.GetSelected(i));
                }
            }
        }

        private void BTCCreateBatButton_Click(object sender, EventArgs e)
        {
            int rc = CheckForBatcherExecution();
            if (rc == 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    AddExtension = true,
                    DefaultExt = "bat",
                    InitialDirectory = BTCFilePathTextBox.Text,
                    Filter = "bat files (*.bat)|*.bat"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(saveFileDialog.FileName) != ".bat")
                    {
                        saveFileDialog.FileName += ".bat";
                    }
                    BatcherManagement batcherManagement = new BatcherManagement(userData);
                    List<string> videoFileList = ExtractVideoFileListToWorkOn();
                    batcherManagement.CreateBat(videoFileList, saveFileDialog.FileName, BTCModelsComboBox.SelectedIndex, false);
                }
            }
        }
        private void BTCExectuteNowButton_Click(object sender, EventArgs e)
        {
            int rc = CheckForBatcherExecution();
            if (rc == 0)
            {
                List<string> videoFileList = ExtractVideoFileListToWorkOn();

                ExecuteBatchForm executeBatchForm = new ExecuteBatchForm(this.userData, videoFileList, BTCModelsComboBox.SelectedIndex, false);
                executeBatchForm.ShowDialog();
            }
        }

        private void BTCAddToQueueButton_Click(object sender, EventArgs e)
        {
            int rc = CheckForBatcherExecution();
            if (rc == 0)
            {
                List<string> videoFileList = ExtractVideoFileListToWorkOn();

                Boolean error = false;

                foreach (string videoFile in videoFileList)
                {
                    foreach(UserData.QueueManagement.Queue queueItem in userData.queueManagement.queueList)
                    {
                        Console.WriteLine("errore: " + error);

                        if (queueItem.fileName == videoFile)
                        {
                            MessageBox.Show("File " + videoFile + " alreay in queue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            error = true;
                            break;
                        }
                    }
                    if (!error)
                    {
                        UserData.QueueManagement.Queue queue = new UserData.QueueManagement.Queue();
                        queue.fileName = videoFile;
                        queue.modelIndex = BTCModelsComboBox.SelectedIndex;
                        queue.modelName = userData.modelManagement.modelList[queue.modelIndex].modelName;

                        userData.queueManagement.queueList.Add(queue);
                    } else
                    {
                        break;
                    }
                }

            }

        }

        private List<string> ExtractVideoFileListToWorkOn()
        {
            List<string> videoFileList = new List<string>();

            if (BTCVideoFilesListBox.SelectedIndices.Count == 0)
            {
                foreach (string videoFile in BTCVideoFilesListBox.Items)
                {
                    videoFileList.Add(videoFile);
                }
            }
            else
            {
                foreach (string videoFile in BTCVideoFilesListBox.SelectedItems)
                {
                    videoFileList.Add(videoFile);
                }
            }
            return videoFileList;
        }

        private int CheckForBatcherExecution()
        {
            int rc = 0;
            if (BTCModelsComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Select or add a Model", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            if (BTCVideoFilesListBox.Items.Count <= 0)
            {
                MessageBox.Show("No video file found. Please Browse a file or folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
            return rc;
        }

        #endregion

        #region Model Manager Methods

        private void MMListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MMListBox.SelectedIndex >= 0)
            {
                MMModelNameTextBox.Text = userData.modelManagement.modelList[MMListBox.SelectedIndex].modelName;
                MMModelContentTextBox.Text = userData.modelManagement.modelList[MMListBox.SelectedIndex].modelContent;
            }
            else
            {
                MMModelNameTextBox.Text = "";
                MMModelContentTextBox.Text = "";
            }
        }

        private void MMSaveButton_Click(object sender, EventArgs e)
        {
            if (MMListBox.SelectedIndex >= 0)
            {
                //userData.modelManagement.modelList[MMListBox.SelectedIndex].modelName = MMModelNameTextBox.Text;
                //userData.modelManagement.modelList[MMListBox.SelectedIndex].modelContent = MMModelContentTextBox.Text;
                UserData.ModelManagement.Model model = new UserData.ModelManagement.Model() 
                {
                modelName = MMModelNameTextBox.Text,
                modelContent = MMModelContentTextBox.Text
                };
                userData.modelManagement.modelList[MMListBox.SelectedIndex] = model;
            }
        }

        private void MMMoveUpButton_Click(object sender, EventArgs e)
        {
            if (MMListBox.SelectedIndex > 0)
            {
                MMMoveModel(MMListBox.SelectedIndex, MMListBox.SelectedIndex - 1);
                ClearQueue();
            }
        }

        private void MMMoveDownButton_Click(object sender, EventArgs e)
        {
            if (MMListBox.SelectedIndex < userData.modelManagement.modelList.Count() - 1)
            {
                MMMoveModel(MMListBox.SelectedIndex, MMListBox.SelectedIndex + 1);
                ClearQueue();
            }
        }

        private void MMMoveTopButton_Click(object sender, EventArgs e)
        {
            if (MMListBox.SelectedIndex > 0)
            {
                for (int i = MMListBox.SelectedIndex; i >= 0; i--)
                {
                    MMMoveModel(MMListBox.SelectedIndex, i);
                }
                ClearQueue();
            }
        }

        private void MMMoveBottomButton_Click(object sender, EventArgs e)
        {
            if (MMListBox.SelectedIndex < userData.modelManagement.modelList.Count() - 1)
            {
                for (int i = MMListBox.SelectedIndex; i <= userData.modelManagement.modelList.Count() - 1; i++)
                {
                    MMMoveModel(MMListBox.SelectedIndex, i);
                }
                ClearQueue();
            }
        }
        private void MMMoveModel(int source, int destination)
        {
            var tmp = userData.modelManagement.modelList[destination];
            userData.modelManagement.modelList[destination] = userData.modelManagement.modelList[source];
            userData.modelManagement.modelList[source] = tmp;
            MMListBox.SelectedIndex = destination;
        }

        private void MMRemoveSelectedButton_Click(object sender, EventArgs e)
        {
            userData.modelManagement.modelList.RemoveAt(MMListBox.SelectedIndex);
            ClearQueue();
        }

        private void MMSortByModelNameButton_Click(object sender, EventArgs e)
        {
            if (userData.modelManagement.modelList.Count() > 0)
            {
                string previouslySelectedModel = userData.modelManagement.modelList[MMListBox.SelectedIndex].modelName;
                
                List<UserData.ModelManagement.Model> sortedList = userData.modelManagement.modelList.OrderBy(o => o.modelName).ToList();
                userData.modelManagement.modelList.Clear();
                int addingIndex = 0;
                int newSelectedIndex = 0;
                foreach (UserData.ModelManagement.Model item in sortedList)
                {
                    userData.modelManagement.modelList.Add(item);
                    if (item.modelName == previouslySelectedModel)
                    {
                        newSelectedIndex = addingIndex;
                    }
                    addingIndex++;
                }
                MMListBox.SelectedIndex = newSelectedIndex + 1;
                MMListBox.SelectedIndex = newSelectedIndex;
            }
            ClearQueue();
        }

        private void ClearQueue()
        {
            userData.queueManagement.queueList.Clear();
        }
        #endregion

        #region Queue Methods
        private void QRemoveFromQueueButton_Click(object sender, EventArgs e)
        {
            if (QDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in QDataGridView.SelectedRows)
                {
                    userData.queueManagement.queueList.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("No rows to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QClearQueueButton_Click(object sender, EventArgs e)
        {
            ClearQueue();
        }

        private void QCreateBatButton_Click(object sender, EventArgs e)
        {
            if (QDataGridView.RowCount > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    AddExtension = true,
                    DefaultExt = "bat",
                    InitialDirectory = BTCFilePathTextBox.Text,
                    Filter = "bat files (*.bat)|*.bat"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(saveFileDialog.FileName) != ".bat")
                    {
                        saveFileDialog.FileName += ".bat";
                    }
                    BatcherManagement batcherManagement = new BatcherManagement(userData);
                    
                    //empty videoFileList passing the executeFromQueue flag to true
                    List<string> videoFileList = new List<string>();
                    batcherManagement.CreateBat(videoFileList, saveFileDialog.FileName, 0, true);
                }
            } else
            {
                MessageBox.Show("The queue is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QExecNowButton_Click(object sender, EventArgs e)
        {
            if (QDataGridView.RowCount > 0)
            {
                //empty videoFileList passing the executeFromQueue flag to true
                List<string> videoFileList = new List<string>();

                ExecuteBatchForm executeBatchForm = new ExecuteBatchForm(this.userData, videoFileList, 0, true);
                executeBatchForm.ShowDialog();
            } else
            {
                MessageBox.Show("The queue is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
        #endregion

}
