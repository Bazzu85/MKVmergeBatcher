using NLog;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MKVmergeBatcher.src.models
{
    public partial class ModelsForm : Form
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public LocaleManager localeManager = new LocaleManager();
        MainForm mainForm;
        Boolean loadingForm = false;

        public ModelsForm(MainForm mainForm)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            loadingForm = true;

            InitializeComponent();
            this.mainForm = mainForm;
            localeManager.SetLocale(this);
            RestoreWindowPositionAndSize();
            SetDataSource();
            SetControlsContent();
            loadingForm = false;
        }

        private void RestoreWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (MainForm.windowsData.modelsWindow.width > 0 && MainForm.windowsData.modelsWindow.height > 0)
            {
                //this is mandatory to make the position modification working
                this.StartPosition = FormStartPosition.Manual;
                this.Width = MainForm.windowsData.modelsWindow.width;
                this.Height = MainForm.windowsData.modelsWindow.height;
                this.Top = MainForm.windowsData.modelsWindow.top;
                this.Left = MainForm.windowsData.modelsWindow.left;
                if (MainForm.windowsData.modelsWindow.maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }
        private void SetDataSource()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            this.modelBindingSource.DataSource = MainForm.modelsData.modelList;
        }
        private void SetControlsContent()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (MainForm.modelsData.modelList.Count > 0 && MainForm.modelsData.lastModelUsed >= 0)
            {
                modelsListBox.SelectedIndex = MainForm.modelsData.lastModelUsed;
            }
        }


        private void modelsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (modelsListBox.SelectedIndex >= 0)
            {
                if (!loadingForm)
                {
                    mainForm.ChangeModelComboBoxIndex(modelsListBox.SelectedIndex);
                }
                SetSelectedModelDataSource();
            }
        }

        private void SetSelectedModelDataSource()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            this.modelsDataBindingSource.DataSource = MainForm.modelsData.modelList[modelsListBox.SelectedIndex];
            this.trackBindingSource.DataSource = MainForm.modelsData.modelList[modelsListBox.SelectedIndex].trackList;
            this.customInputFileArgumentsBindingSource.DataSource = MainForm.modelsData.modelList[modelsListBox.SelectedIndex].customInputFileArguments;
            this.customOutputFileArgumentsBindingSource.DataSource = MainForm.modelsData.modelList[modelsListBox.SelectedIndex].customOutputFileArguments;
        }

        private void ModelsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            SaveWindowPositionAndSize();
        }
        private void SaveWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                MainForm.windowsData.modelsWindow.maximized = true;
            }
            else
            {
                MainForm.windowsData.modelsWindow.maximized = false;
                MainForm.windowsData.modelsWindow.width = this.Width;
                MainForm.windowsData.modelsWindow.height = this.Height;
                MainForm.windowsData.modelsWindow.top = this.Top;
                MainForm.windowsData.modelsWindow.left = this.Left;
            }
        }

        private void MoveModel(int source, int destination)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            while (source != destination)
            {
                if (destination > source)
                {
                    var tmp = MainForm.modelsData.modelList[source + 1];
                    MainForm.modelsData.modelList[source + 1] = MainForm.modelsData.modelList[source];
                    MainForm.modelsData.modelList[source] = tmp;
                    modelsListBox.SelectedIndex = destination;
                    source += 1;
                }
                else
                {
                    var tmp = MainForm.modelsData.modelList[source - 1];
                    MainForm.modelsData.modelList[source - 1] = MainForm.modelsData.modelList[source];
                    MainForm.modelsData.modelList[source] = tmp;
                    modelsListBox.SelectedIndex = destination;
                    source -= 1;
                }
            }
        }

        private void moveModelTopButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (modelsListBox.SelectedIndex > 0)
            {
                MoveModel(modelsListBox.SelectedIndex, 0);
            }
        }

        private void moveModelUpButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (modelsListBox.SelectedIndex > 0)
            {
                MoveModel(modelsListBox.SelectedIndex, modelsListBox.SelectedIndex - 1);
            }
        }

        private void moveModelDownButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (modelsListBox.SelectedIndex >= 0 && modelsListBox.SelectedIndex != MainForm.modelsData.modelList.Count - 1)
            {
                MoveModel(modelsListBox.SelectedIndex, modelsListBox.SelectedIndex + 1);
            }
        }

        private void moveModelBottomButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (modelsListBox.SelectedIndex >= 0 && modelsListBox.SelectedIndex != MainForm.modelsData.modelList.Count - 1)
            {
                MoveModel(modelsListBox.SelectedIndex, MainForm.modelsData.modelList.Count - 1);
            }
        }

        private void sortModelByNameButton_Click(object sender, EventArgs e)
        {
            if (MainForm.modelsData.modelList.Count > 0)
            {
                string previouslySelectedModel = MainForm.modelsData.modelList[modelsListBox.SelectedIndex].modelName;

                for (int i = 0; i < MainForm.modelsData.modelList.Count - 1; i++)
                {
                    if (String.Compare(MainForm.modelsData.modelList[i].modelName, MainForm.modelsData.modelList[i + 1].modelName, true) > 0)
                    {
                        MoveModel(i, i + 1);
                        i = -1;
                    }
                }
                int newSelectedIndex = 0;

                for (int i = 0; i < MainForm.modelsData.modelList.Count(); i++)
                {
                    if (MainForm.modelsData.modelList[i].modelName == previouslySelectedModel)
                    {
                        newSelectedIndex = i;
                    }
                }
                modelsListBox.SelectedIndex = newSelectedIndex;
            }
        }

        private void addModelButton_Click(object sender, EventArgs e)
        {
            ModelsData.Model newModel = new ModelsData.Model();

            ManageModelForm addEditModelForm = new ManageModelForm(newModel, ManageModelForm.CallType.Add, -1);
            addEditModelForm.ShowDialog();
            if (addEditModelForm.DialogResult == DialogResult.OK)
            {
                MainForm.modelsData.modelList.Add(addEditModelForm.GetModel());
                MainForm.modelsJson.WriteModelsJson();
            }
        }

        private void deleteModelButton_Click(object sender, EventArgs e)
        {
            if (modelsListBox.SelectedIndex >= 0)
            {
                MainForm.modelsData.modelList.RemoveAt(modelsListBox.SelectedIndex);
            }
        }

        private void editModelButton_Click(object sender, EventArgs e)
        {
            EditModel();
        }


        private void modelsListBox_DoubleClick(object sender, EventArgs e)
        {
            EditModel();
        }

        private void EditModel()
        {
            if (modelsListBox.SelectedIndex >= 0)
            {
                //convert to json e deserialize to create a new fresh object
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(MainForm.modelsData.modelList[modelsListBox.SelectedIndex]);
                ModelsData.Model editModel = Newtonsoft.Json.JsonConvert.DeserializeObject<ModelsData.Model>(json);

                ManageModelForm addEditModelForm = new ManageModelForm(editModel, ManageModelForm.CallType.Edit, modelsListBox.SelectedIndex);
                addEditModelForm.ShowDialog();
                if (addEditModelForm.DialogResult == DialogResult.OK)
                {
                    MainForm.modelsData.modelList[modelsListBox.SelectedIndex] = addEditModelForm.GetModel();
                    MainForm.modelsJson.WriteModelsJson();
                }
            }
        }
    }
}
