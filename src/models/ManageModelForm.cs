using NLog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MKVmergeBatcher.src.models
{
    public partial class ManageModelForm : Form
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public LocaleManager localeManager = new LocaleManager();
        public ModelGenerator modelGenerator = new ModelGenerator();
        public SavedModelJson savedModelJson = new SavedModelJson();
        public static ModelsData.Model model;
        private Boolean userExitConfirmed = false;
        private String originalModelJson = "";
        public String originalModelName = "";
        private String lastModelJson = "";
        private String currentModelJson = "";
        private Boolean loadingForm = false;
        public int currentModelIndex;

        public enum CallType
        {
            Add,
            Edit
        }

        public CallType callType;

        public ManageModelForm(ModelsData.Model inputModel, CallType callType, int index)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            loadingForm = true;
            InitializeComponent();
            model = inputModel;
            this.callType = callType;
            this.currentModelIndex = index;
            localeManager.SetLocale(this);
            originalModelJson = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            originalModelName = model.modelName;
            RestoreWindowPositionAndSize();
            NewModelActions();
            loadingForm = false;
            if (!model.customCommand)
            {
                GenerateModel();
            }
            Application.DoEvents();
        }

        private void NewModelActions()
        {
            lastModelJson = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            SetControlsContent();
            SetDataSource();

        }
        private void RestoreWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (MainForm.windowsData.addEditModelWindow.width > 0 && MainForm.windowsData.addEditModelWindow.height > 0 && MainForm.windowsData.addEditModelWindow.top > 0 && MainForm.windowsData.addEditModelWindow.left > 0)
            {
                //this is mandatory to make the position modification working
                this.StartPosition = FormStartPosition.Manual;
                this.Width = MainForm.windowsData.addEditModelWindow.width;
                this.Height = MainForm.windowsData.addEditModelWindow.height;
                this.Top = MainForm.windowsData.addEditModelWindow.top;
                this.Left = MainForm.windowsData.addEditModelWindow.left;
                if (MainForm.windowsData.addEditModelWindow.maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void SetDataSource()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            this.modelBindingSource.DataSource = model;
            this.trackBindingSource.DataSource = model.trackList;
            this.customInputFileArgumentsBindingSource.DataSource = model.customInputFileArguments;
            //Console.WriteLine(this.noAttachmentsCheckBox.DataBindings.DefaultDataSourceUpdateMode);
            this.customOutputFileArgumentsBindingSource.DataSource = model.customOutputFileArguments;
        }
        private void ResetFormBindings()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            this.modelBindingSource.ResetBindings(false);
            this.trackBindingSource.ResetBindings(false);
            this.customInputFileArgumentsBindingSource.ResetBindings(false);
            this.customOutputFileArgumentsBindingSource.ResetBindings(false);
        }
        private void SetControlsContent()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (String.IsNullOrEmpty(nameof(callType)))
            {
                MessageBox.Show(Properties.Resources.CallTypeNotPassed, Properties.Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                userExitConfirmed = true;
                this.Close();
            }
            else
            {
                switch (callType)
                {
                    case CallType.Add:
                        this.Text = Properties.Resources.AddModel;
                        okButton.Text = Properties.Resources.AddLabel;
                        break;
                    case CallType.Edit:
                        this.Text = Properties.Resources.EditModel;
                        okButton.Text = Properties.Resources.SaveLabel;
                        break;
                    default:
                        this.Text = Properties.Resources.AddModel;
                        okButton.Text = Properties.Resources.AddLabel;
                        break;
                }
                if (model.customCommand)
                {
                    DisableControls();
                }
                else
                {
                    EnableControls();
                }
            }
        }

        private void AddEditModelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            String currentModelJson = Newtonsoft.Json.JsonConvert.SerializeObject(model);

            if (!userExitConfirmed && currentModelJson != originalModelJson)
            {
                DialogResult dr = MessageBox.Show(this, Properties.Resources.SaveCurrentCompiledModel, Properties.Resources.WarningLabel, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                if (dr == DialogResult.Yes)
                {
                    Boolean modelOk = CheckModel();
                    if (!modelOk)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        OkAction();
                    }
                }
                if (dr == DialogResult.No)
                {
                    CancelAction();
                }
            }
        }

        private bool CheckModel()
        {
            bool modelOk = modelGenerator.CheckModel(this);
            if (!String.IsNullOrEmpty(modelGenerator.errorList))
            {
                MessageBox.Show(modelGenerator.errorList, Properties.Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return modelOk;
        }

        private void AddEditModelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            SaveWindowPositionAndSize();
        }
        private void SaveWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                MainForm.windowsData.addEditModelWindow.maximized = true;
            }
            else
            {
                MainForm.windowsData.addEditModelWindow.width = this.Width;
                MainForm.windowsData.addEditModelWindow.height = this.Height;
                MainForm.windowsData.addEditModelWindow.top = this.Top;
                MainForm.windowsData.addEditModelWindow.left = this.Left;
                MainForm.windowsData.addEditModelWindow.maximized = false;
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            Boolean modelOk = CheckModel();
            if (modelOk)
            {
                OkAction();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            CancelAction();
        }
        private void OkAction()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            this.DialogResult = DialogResult.OK;
            userExitConfirmed = true;
            this.Close();
        }
        private void CancelAction()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            this.DialogResult = DialogResult.Cancel;
            userExitConfirmed = true;
            this.Close();
        }


        private void customCommandCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (customCommandCheckBox.Checked)
            {
                DisableControls();
            }
            else
            {
                EnableControls();
            }
        }

        private void DisableControls()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            moveTrackTopButton.Enabled = false;
            moveTrackUpButton.Enabled = false;
            moveTrackDownButton.Enabled = false;
            moveTrackBottomButton.Enabled = false;
            addTrackButton.Enabled = false;
            deleteTrackButton.Enabled = false;
            copyTrackButton.Enabled = false;
            editTrackButton.Enabled = false;
            noAttachmentsCheckBox.Enabled = false;
            noCompressionCheckBox.Enabled = false;
            noGlobalTagsCheckBox.Enabled = false;
            noTrackTagsCheckBox.Enabled = false;
            customInputFileArgumentsTextBox.ReadOnly = true;
            emptyTitleCheckBox.Enabled = false;
            addAttachmentsCheckBox.Enabled = false;
            addChaptersCheckBox.Enabled = false;
            customOutputFileArgumentsTextBox.ReadOnly = true;
            commandTextBox.ReadOnly = false;
        }
        private void EnableControls()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            moveTrackTopButton.Enabled = true;
            moveTrackUpButton.Enabled = true;
            moveTrackDownButton.Enabled = true;
            moveTrackBottomButton.Enabled = true;
            addTrackButton.Enabled = true;
            deleteTrackButton.Enabled = true;
            copyTrackButton.Enabled = true;
            editTrackButton.Enabled = true;
            noAttachmentsCheckBox.Enabled = true;
            noCompressionCheckBox.Enabled = true;
            noGlobalTagsCheckBox.Enabled = true;
            noTrackTagsCheckBox.Enabled = true;
            customInputFileArgumentsTextBox.ReadOnly = false;
            emptyTitleCheckBox.Enabled = true;
            addAttachmentsCheckBox.Enabled = true;
            addChaptersCheckBox.Enabled = true;
            customOutputFileArgumentsTextBox.ReadOnly = false;
            commandTextBox.ReadOnly = true;
        }
        public ModelsData.Model GetModel()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            return model;
        }

        private void MoveTrack(int source, int destination)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            while (source != destination)
            {
                if (destination > source)
                {
                    var tmp = model.trackList[source + 1];
                    model.trackList[source + 1] = model.trackList[source];
                    model.trackList[source] = tmp;
                    tracksDataGridView.Rows[destination].Selected = true;
                    source += 1;
                }
                else
                {
                    var tmp = model.trackList[source - 1];
                    model.trackList[source - 1] = model.trackList[source];
                    model.trackList[source] = tmp;
                    tracksDataGridView.Rows[destination].Selected = true;
                    source -= 1;
                }
            }
            GenerateModel();
        }

        private void moveTrackTopButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (tracksDataGridView.SelectedRows.Count > 0)
            {
                MoveTrack(tracksDataGridView.SelectedRows[0].Index, 0);
            }
        }

        private void moveTrackUpButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (tracksDataGridView.SelectedRows.Count > 0 && tracksDataGridView.SelectedRows[0].Index > 0)
            {
                MoveTrack(tracksDataGridView.SelectedRows[0].Index, tracksDataGridView.SelectedRows[0].Index - 1);
            }
        }

        private void moveTrackDownButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (tracksDataGridView.SelectedRows.Count > 0 && tracksDataGridView.SelectedRows[0].Index != tracksDataGridView.RowCount - 1)
            {
                MoveTrack(tracksDataGridView.SelectedRows[0].Index, tracksDataGridView.SelectedRows[0].Index + 1);
            }
        }

        private void moveTrackBottomButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (tracksDataGridView.SelectedRows.Count > 0 && tracksDataGridView.SelectedRows[0].Index != tracksDataGridView.RowCount - 1)
            {
                MoveTrack(tracksDataGridView.SelectedRows[0].Index, tracksDataGridView.RowCount - 1);
            }
        }

        private void addTrackButton_Click(object sender, EventArgs e)
        {
            ModelsData.Model.Track newTrack = new ModelsData.Model.Track();
            ManageTrackForm manageTrack = new ManageTrackForm(newTrack, ManageTrackForm.CallType.Add, -1);
            manageTrack.ShowDialog();
            if (manageTrack.DialogResult == DialogResult.OK)
            {
                model.trackList.Add(manageTrack.track);
                GenerateModel();
            }
        }

        private void deleteTrackButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (tracksDataGridView.SelectedRows.Count == 1)
            {
                int previuslySelectedindex = tracksDataGridView.SelectedRows[0].Index;
                model.trackList.RemoveAt(tracksDataGridView.SelectedRows[0].Index);
                if (tracksDataGridView.Rows.Count > 0)
                {
                    int newSelectedIndex = previuslySelectedindex;
                    if (newSelectedIndex > tracksDataGridView.Rows.Count - 1)
                    {
                        newSelectedIndex = previuslySelectedindex - 1;
                    }
                    if (newSelectedIndex < 0)
                    {
                        newSelectedIndex = 0;
                    }
                    tracksDataGridView.Rows[newSelectedIndex].Selected = true;
                }
                if (model.trackList.Count > 0)
                {
                    GenerateModel();
                }
            }
        }

        private void FixOriginalFileNumbers()
        {
            bool done = false;
            while (!done)
            {
                int maxFileNumber = -1;
                // retrieve the maximum file number from track list  not considering the one we want to delete
                for (int i = 0; i < model.trackList.Count; i++)
                {
                    if (model.trackList[i].originalFileNumber > maxFileNumber)
                    {
                        maxFileNumber = model.trackList[i].originalFileNumber;
                    }
                }

                List<TrackSummary> trackSummaryArray = new List<TrackSummary>();

                // add to the tracks Summary a row for every theoretically file number, based on maxFileNumber
                for (int i = 0; i < maxFileNumber + 1; i++)
                {
                    trackSummaryArray.Add(new TrackSummary()
                    {
                        originalFileNumber = i,
                        count = 0
                    });
                }

                //update the counter for every originalFileNumber. At the end if there's an originalFileNumber with a count of zero, we have a problem
                for (int i = 0; i < model.trackList.Count; i++)
                {
                    // search the originalFileNumber in the summary and add the counter
                    foreach (TrackSummary item in trackSummaryArray)
                    {
                        if (item.originalFileNumber == model.trackList[i].originalFileNumber)
                        {
                            item.count++;
                            break;
                        }
                    }
                }

                // if there are originalFileNumbers with zero occurrence, update all tracks decreasing the originalFileNumber
                foreach (TrackSummary item in trackSummaryArray)
                {
                    if (item.count == 0)
                    {
                        for (int i = 0; i < model.trackList.Count; i++)
                        {
                            if (model.trackList[i].originalFileNumber > item.originalFileNumber)
                            {
                                model.trackList[i].originalFileNumber -= 1;
                            }
                        }
                    }
                }

                //recalculate che maxFileNumber
                int newMaxFileNumber = -1;
                // retrieve the maximum file number from track list  not considering the one we want to delete
                for (int i = 0; i < model.trackList.Count; i++)
                {
                    if (model.trackList[i].originalFileNumber > newMaxFileNumber)
                    {
                        newMaxFileNumber = model.trackList[i].originalFileNumber;
                    }
                }
                //if the newMaxFileNumber is the same as the start, when can close the loop. otherwise we have to do all againg
                if (newMaxFileNumber == maxFileNumber)
                {
                    done = true;
                }
            }
        }
        

        private void copyTrackButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (tracksDataGridView.SelectedRows.Count == 1)
            {
                string copyTrackJson = Newtonsoft.Json.JsonConvert.SerializeObject(model.trackList[tracksDataGridView.SelectedRows[0].Index]);
                ModelsData.Model.Track copyTrack = Newtonsoft.Json.JsonConvert.DeserializeObject<ModelsData.Model.Track>(copyTrackJson);
                ManageTrackForm manageTrackCopy = new ManageTrackForm(copyTrack, ManageTrackForm.CallType.Copy, -1);
                manageTrackCopy.ShowDialog();
                if (manageTrackCopy.DialogResult == DialogResult.OK)
                {
                    model.trackList.Add(manageTrackCopy.track);
                    GenerateModel();
                }
            }
        }

        private void editTrackButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            EditTrack();

        }
        private void tracksDataGridView_DoubleClick(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            EditTrack();
        }
        private void EditTrack()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (tracksDataGridView.SelectedRows.Count == 1)
            {
                string editTrackJson = Newtonsoft.Json.JsonConvert.SerializeObject(model.trackList[tracksDataGridView.SelectedRows[0].Index]);
                ModelsData.Model.Track editTrack = Newtonsoft.Json.JsonConvert.DeserializeObject<ModelsData.Model.Track>(editTrackJson);
                ManageTrackForm manageTrackEdit = new ManageTrackForm(editTrack, ManageTrackForm.CallType.Edit, tracksDataGridView.SelectedRows[0].Index);
                manageTrackEdit.ShowDialog();
                if (manageTrackEdit.DialogResult == DialogResult.OK)
                {
                    model.trackList[tracksDataGridView.SelectedRows[0].Index] = manageTrackEdit.track;
                    GenerateModel();
                }
            }
        }
        private void GenerateModel()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (!customCommandCheckBox.Checked && !loadingForm)
            {
                FixOriginalFileNumbers();
                commandTextBox.Text = modelGenerator.GenerateModel(this);
            }
        }


        private void customInputFileArgumentsBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            currentModelJson = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            if (currentModelJson != lastModelJson)
            {
                GenerateModel();
                lastModelJson = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            }
        }

        private void customOutputFileArgumentsBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            currentModelJson = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            if (currentModelJson != lastModelJson)
            {
                GenerateModel();
                lastModelJson = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            }
        }

        private void trackBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            currentModelJson = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            if (currentModelJson != lastModelJson)
            {
                GenerateModel();
                lastModelJson = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            }
        }

        private void saveModelButton_Click(object sender, EventArgs e)
        {
            savedModelJson.WriteSavedModelJson(model);
        }

        private void loadSavedModelButton_Click(object sender, EventArgs e)
        {
            string savedModelName = "";

            if (!String.IsNullOrEmpty(model.modelName))
            {
                savedModelName = model.modelName;
            }
            model = savedModelJson.ReadSavedModelJson();
            if (!String.IsNullOrEmpty(savedModelName))
            {
                model.modelName = savedModelName;

            }
            NewModelActions();
        }


    }
}
