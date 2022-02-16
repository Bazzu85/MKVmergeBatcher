using NLog;
using System;
using System.Windows.Forms;

namespace MKVmergeBatcher.src.models
{
    public partial class ManageTrackForm : Form
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public LocaleManager localeManager = new LocaleManager();
        public ModelGenerator modelGenerator = new ModelGenerator();
        public enum CallType
        {
            Add,
            Edit,
            Copy
        }
        public CallType callType;
        public int currentTrackIndex;
        public ModelsData.Model.Track track;
        private String errorList = "";
        private Boolean userExitConfirmed = false;
        private String originalTrackJson = "";

        public ManageTrackForm(ModelsData.Model.Track track, CallType callType, int index)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            InitializeComponent();
            this.track = track;
            this.callType = callType;
            this.currentTrackIndex = index;

            localeManager.SetLocale(this);
            originalTrackJson = Newtonsoft.Json.JsonConvert.SerializeObject(this.track);
            RestoreWindowPositionAndSize();
            SetDataSource();
            SetControlsContent();
        }
        private void RestoreWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (MainForm.windowsData.manageTrackWindow.width > 0 && MainForm.windowsData.manageTrackWindow.height > 0)
            {
                //this is mandatory to make the position modification working
                this.StartPosition = FormStartPosition.Manual;
                this.Width = MainForm.windowsData.manageTrackWindow.width;
                this.Height = MainForm.windowsData.manageTrackWindow.height;
                this.Top = MainForm.windowsData.manageTrackWindow.top;
                this.Left = MainForm.windowsData.manageTrackWindow.left;
                if (MainForm.windowsData.manageTrackWindow.maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void SetDataSource()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            this.trackBindingSource.DataSource = this.track;
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
                        this.Text = Properties.Resources.AddTrack;
                        okButton.Text = Properties.Resources.AddLabel;
                        typeComboBox.SelectedIndex = 0;
                        break;
                    case CallType.Edit:
                        this.Text = Properties.Resources.EditTrack;
                        okButton.Text = Properties.Resources.SaveLabel;
                        SelectTypeCombobox();
                        break;
                    case CallType.Copy:
                        this.Text = Properties.Resources.AddTrack;
                        okButton.Text = Properties.Resources.AddLabel;
                        SelectTypeCombobox();
                        break;
                    default:
                        this.Text = Properties.Resources.AddTrack;
                        okButton.Text = Properties.Resources.AddLabel;
                        typeComboBox.SelectedIndex = 0;
                        break;
                }
            }
        }

        private void SelectTypeCombobox()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            //typeComboBox.SelectedIndex = 0;
            for (int i = 0; i < typeComboBox.Items.Count; i++)
            {
                if (typeComboBox.GetItemText(typeComboBox.Items[i]) == track.type)
                {
                    typeComboBox.SelectedIndex = i;
                }
            }
            if (typeComboBox.SelectedIndex < 0)
            {
                typeComboBox.SelectedIndex = 0;
            }
        }

        private void ManageTrack_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            String currentTrackJson = Newtonsoft.Json.JsonConvert.SerializeObject(this.track);
            if (!userExitConfirmed && currentTrackJson != originalTrackJson)
            {
                DialogResult dr = MessageBox.Show(this, Properties.Resources.SaveCurrentTrack, Properties.Resources.WarningLabel, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                if (dr == DialogResult.Yes)
                {
                    Boolean result = CheckTrack();
                    if (!result)
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

        private void ManageTrack_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            SaveWindowPositionAndSize();
        }
        private void SaveWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                MainForm.windowsData.manageTrackWindow.maximized = true;
            }
            else
            {
                MainForm.windowsData.manageTrackWindow.maximized = false;
                MainForm.windowsData.manageTrackWindow.width = this.Width;
                MainForm.windowsData.manageTrackWindow.height = this.Height;
                MainForm.windowsData.manageTrackWindow.top = this.Top;
                MainForm.windowsData.manageTrackWindow.left = this.Left;
            }
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

        private void okButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            Boolean trackOk = CheckTrack();
            if (trackOk)
            {
                OkAction();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            CancelAction();
        }
        private bool CheckTrack()
        {
            bool result = modelGenerator.CheckTrack(this);
            if (!String.IsNullOrEmpty(modelGenerator.errorList))
            {
                MessageBox.Show(modelGenerator.errorList, Properties.Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        private void AddError(string message)
        {
            if (String.IsNullOrEmpty(errorList))
            {
                errorList += message;
            }
            else
            {
                errorList += "\n" + message;
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedIndex >= 0)
            {
                track.type = typeComboBox.GetItemText(typeComboBox.Items[typeComboBox.SelectedIndex]);
            }
        }
    }
}
