using NLog;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MKVmergeBatcher.src.options
{
    public partial class OptionsForm : Form
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        Boolean loadingForm = false;
        public LocaleManager localeManager = new LocaleManager();

        public OptionsForm()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            loadingForm = true;
            InitializeComponent();
            RestoreWindowPositionAndSize();
            SetDataSource();
            SetControlsContent();
            loadingForm = false;
        }

        private void SetControlsContent()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            //Console.WriteLine("selectedLogLevel: " + MainForm.optionsData.selectedLogLevel);
            //Console.WriteLine("selectedLogLevelIndex: " + MainForm.optionsData.selectedLogLevelIndex);
            logLevelsComboBox.SelectedIndex = MainForm.optionsData.selectedLogLevelIndex;
            localeComboBox.SelectedIndex = MainForm.optionsData.selectedLocaleIndex;
        }

        private void RestoreWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (MainForm.windowsData.optionsWindow.width > 0 && MainForm.windowsData.optionsWindow.height > 0)
            {
                //this is mandatory to make the position modification working
                this.StartPosition = FormStartPosition.Manual;
                this.Width = MainForm.windowsData.optionsWindow.width;
                this.Height = MainForm.windowsData.optionsWindow.height;
                this.Top = MainForm.windowsData.optionsWindow.top;
                this.Left = MainForm.windowsData.optionsWindow.left;
                if (MainForm.windowsData.optionsWindow.maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }
        private void SetDataSource()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            this.optionsDataBindingSource.DataSource = MainForm.optionsData;
            this.logLevelBindingSource.DataSource = MainForm.optionsData.logLevelList;
            this.localeBindingSource.DataSource = MainForm.optionsData.localeList;
            this.extensionBindingSource.DataSource = MainForm.optionsData.extensionList;
            this.excludeFileNameContainingBindingSource.DataSource = MainForm.optionsData.excludeFileNameContainingList;
        }

        private void OptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            SaveWindowPositionAndSize();
        }
        private void SaveWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                MainForm.windowsData.optionsWindow.maximized = true;
            }
            else
            {
                MainForm.windowsData.optionsWindow.maximized = false;
                MainForm.windowsData.optionsWindow.width = this.Width;
                MainForm.windowsData.optionsWindow.height = this.Height;
                MainForm.windowsData.optionsWindow.top = this.Top;
                MainForm.windowsData.optionsWindow.left = this.Left;
            }
        }
        private void logLevelsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (!loadingForm)
            {
                if (logLevelsComboBox.SelectedIndex >= 0)
                {
                    MainForm.optionsData.selectedLogLevelIndex = logLevelsComboBox.SelectedIndex;
                    MainForm.optionsData.selectedLogLevel = MainForm.optionsData.logLevelList[MainForm.optionsData.selectedLogLevelIndex].logLevel;
                }
                MainForm.logConfigurationManager.ChangeLogLevel();
            }
        }

        private void localeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (!loadingForm)
            {
                if (localeComboBox.SelectedIndex >= 0)
                {
                    MainForm.optionsData.selectedLocaleIndex = localeComboBox.SelectedIndex;
                    MainForm.optionsData.selectedLocale = MainForm.optionsData.localeList[MainForm.optionsData.selectedLocaleIndex].localeCode;
                }
                localeManager.SaveOldLocaleLabels();
                localeManager.SetLocale(this);
                localeManager.UpdateNewLocaleLabels();
            }
        }

        private void applyResources(ComponentResourceManager resources, Control.ControlCollection ctls)
        {
            foreach (Control c in ctls)
            {
                resources.ApplyResources(c, c.Name);
                applyResources(resources, c.Controls);
                //Console.WriteLine("c.Name: " + c.Name);
                //Console.WriteLine("c.Text: " + c.Text);
            }
        }

        private void browseMkvMergeLocationButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (String.IsNullOrEmpty(mkvMergeLocationTextBox.Text))
            {
                mkvMergeLocationTextBox.Text = Directory.GetCurrentDirectory();
            }
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = mkvMergeLocationTextBox.Text,
                Filter = "exe files (*.exe)|*.exe"
            }
            ;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetFileName(openFileDialog.FileName).ToLower() != "mkvmerge.exe")
                {
                    MessageBox.Show(Properties.Resources.SelectCorrectMkvmerge, Properties.Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mkvMergeLocationTextBox.Text = "";
                }
                else
                {
                    mkvMergeLocationTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void mkvMergeLocationTextBox_DragDrop(object sender, DragEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (fileList != null && fileList.Length != 0)
            {
                if (Directory.Exists(fileList[0]))
                {
                    Logger.Debug("mkvMergeLocationTextBox_DragDrop: used a directory");
                }
                else
                {
                    if (Path.GetFileName(fileList[0]).ToLower() != "mkvmerge.exe")
                    {
                        Logger.Debug("mkvMergeLocationTextBox_DragDrop: not mkvmerge file");
                    }
                    else
                    {
                        mkvMergeLocationTextBox.Text = fileList[0];
                    }
                }
            }

        }

        private void mkvMergeLocationTextBox_DragEnter(object sender, DragEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void addExtensionButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (!String.IsNullOrEmpty(newExtensionTextBox.Text))
            {
                OptionsData.Extension ext = new OptionsData.Extension()
                {
                    extension = newExtensionTextBox.Text
                };
                MainForm.optionsData.extensionList.Add(ext);
            }
        }

        private void removeExtensionButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (MainForm.optionsData.extensionList.Count() > 0 && extensionsListBox.SelectedItems.Count > 0)
            {
                int index = 0;
                for (int i = 0; i < extensionsListBox.Items.Count; i++)
                {
                    if (extensionsListBox.GetSelected(i))
                    {
                        index = i;
                        MainForm.optionsData.extensionList.RemoveAt(i);
                    }
                }
                if (index >= MainForm.optionsData.extensionList.Count())
                {
                    index = MainForm.optionsData.extensionList.Count() - 1;
                }
                if (index > 0 && MainForm.optionsData.extensionList.Count() > 0)
                {
                    extensionsListBox.SelectedIndex = index;
                }
            }
        }

        private void addExcludeFileNameContainingButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (!String.IsNullOrEmpty(newExcludeFileNameContainingTextBox.Text))
            {
                OptionsData.ExcludeFileNameContaining exclude = new OptionsData.ExcludeFileNameContaining()
                {
                    excludeFileNameContaining = newExcludeFileNameContainingTextBox.Text
                };
                MainForm.optionsData.excludeFileNameContainingList.Add(exclude);
            }

        }

        private void removeExcludeFileNameContainingButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (MainForm.optionsData.excludeFileNameContainingList.Count() > 0 && excludeFileNameContainingListBox.SelectedItems.Count > 0)
            {
                int index = 0;
                for (int i = 0; i < excludeFileNameContainingListBox.Items.Count; i++)
                {
                    if (excludeFileNameContainingListBox.GetSelected(i))
                    {
                        index = i;
                        MainForm.optionsData.excludeFileNameContainingList.RemoveAt(i);
                    }
                }
                if (index >= MainForm.optionsData.excludeFileNameContainingList.Count())
                {
                    index = MainForm.optionsData.excludeFileNameContainingList.Count() - 1;
                }
                if (index > 0 && MainForm.optionsData.excludeFileNameContainingList.Count() > 0)
                {
                    excludeFileNameContainingListBox.SelectedIndex = index;
                }
            }
        }
    }
}
