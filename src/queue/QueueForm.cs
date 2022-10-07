using Microsoft.WindowsAPICodePack.Taskbar;
using NLog;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MKVmergeBatcher.src.queue
{
    public partial class QueueForm : Form
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public LocaleManager localeManager = new LocaleManager();
        public MainForm mainForm;
        public FormWindowState lastWindowState = new FormWindowState();
        Boolean loadingForm = false;
        public string currentLocale = "";
        public string savedJobListJson = "";
        public string savedQueueJson = "";
        public int lastSelectedRow = -1;
        public QueueForm(MainForm inputMainForm)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            loadingForm = true;
            InitializeComponent();
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);

            mainForm = inputMainForm;
            queueTimer.Enabled = true;
            RestoreWindowPositionAndSize();
            SetDataSource();
            SetToolStripMenuItemFlags();
            SetControlsContent();
            UpdateLocale();
            savedJobListJson = Newtonsoft.Json.JsonConvert.SerializeObject(MainForm.queueData.jobList);
            savedQueueJson = Newtonsoft.Json.JsonConvert.SerializeObject(MainForm.queueData);
            loadingForm = false;
        }

        private void RestoreWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (MainForm.windowsData.queueWindow.width > 0 && MainForm.windowsData.queueWindow.height > 0 && MainForm.windowsData.queueWindow.top > 0 && MainForm.windowsData.queueWindow.left > 0)
            {
                //this is mandatory to make the position modification working
                this.StartPosition = FormStartPosition.Manual;
                this.Width = MainForm.windowsData.queueWindow.width;
                this.Height = MainForm.windowsData.queueWindow.height;
                this.Top = MainForm.windowsData.queueWindow.top;
                this.Left = MainForm.windowsData.queueWindow.left;
                if (MainForm.windowsData.queueWindow.maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }
        private void queueTimer_Tick(object sender, EventArgs e)
        {
            //Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            //Console.WriteLine("queueForm: tick");

            //disable the timer until is not ended the current elaboration
            queueTimer.Enabled = false;

            // Check if the locale is changed and update it
            //Console.WriteLine("queueForm: UpdateLocale()");
            UpdateLocale();

            // Check if some flags are changed and update it
            SetToolStripMenuItemFlags();

            // if the wait flag is true, wait until the work is done
            while (MainForm.queueManager.wait)
            {
                //Console.WriteLine("queueForm: wait");
                Thread.Sleep(1000);
            }

            // To prevent useless refreshes check if the queue is changed
            string currentQueueJson = Newtonsoft.Json.JsonConvert.SerializeObject(MainForm.queueData);
            if (currentQueueJson != savedQueueJson)
            {
                Logger.Debug("Queue changed. Refreshing");
                //Console.WriteLine("Queue changed. Refreshing");
                savedQueueJson = currentQueueJson;
                //refresh the controls content (job list, counters, progress bars)
                SetControlsContent();
            }
            //Console.WriteLine("queueForm: end tick");

            //re-enable the timer until is not ended the current elaboration
            queueTimer.Enabled = true;


        }
        private void SetDataSource()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            this.jobBindingSource.DataSource = MainForm.queueData.jobList;
            this.queueDataBindingSource.DataSource = MainForm.queueData;
        }

        private void ResetFormBindings()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            this.jobBindingSource.ResetBindings(false);
            this.queueDataBindingSource.ResetBindings(false);
        }
        private void SetToolStripMenuItemFlags()
        {
            //Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            //automatically allineate the toolstrip checkbox
            if (MainForm.optionsData.autoClearOkJobs != autoClearOkJobsToolStripMenuItem.Checked)
            {
                autoClearOkJobsToolStripMenuItem.Checked = MainForm.optionsData.autoClearOkJobs;
            }
            if (MainForm.optionsData.autoClearWarningJobs != autoClearWarningJobsToolStripMenuItem.Checked)
            {
                autoClearWarningJobsToolStripMenuItem.Checked = MainForm.optionsData.autoClearWarningJobs;
            }
            if (MainForm.optionsData.autoClearErrorJobs != autoClearErrorJobsToolStripMenuItem.Checked)
            {
                autoClearErrorJobsToolStripMenuItem.Checked = MainForm.optionsData.autoClearErrorJobs;
            }
        }

        private void SetControlsContent()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            //Console.WriteLine("updating controls");
            // Controls to update in every situation (jos running/not running)
            workingOnLabel.Text = Properties.Resources.WorkingOnJob + " " + MainForm.queueData.currentRunningJob + " " + Properties.Resources.Of + " " + MainForm.queueData.totalJobsToExec;
            warningLabel.Text = Properties.Resources.WarningJobLabel + ": " + MainForm.queueData.warnings.ToString();
            errorLabel.Text = Properties.Resources.ErrorJobLabel + ": " + MainForm.queueData.errors.ToString();
            jobProgressBar.Maximum = 100;
            totalProgressBar.Maximum = MainForm.queueData.totalJobsToExec;

            if (MainForm.queueData.running)
            {
                if (MainForm.queueData.currentRunningJob > 0)
                {
                    totalProgressBar.Value = MainForm.queueData.currentRunningJob - 1;

                    if (MainForm.queueData.currentRunningJobIndex >= 0)
                    {
                        //Console.WriteLine("updating percentage in form: " + MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].percentage);

                        jobProgressBar.Value = MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].percentage;

                        //update the taskbar progress bar
                        int taskbarProgressMax = totalProgressBar.Maximum * 100;
                        int taskbarProgressValue = 0;
                        if (MainForm.queueData.currentRunningJob > 1)
                        {
                            taskbarProgressValue = ((MainForm.queueData.currentRunningJob - 1) * 100) + jobProgressBar.Value;
                        }
                        else
                        {
                            taskbarProgressValue = jobProgressBar.Value;
                        }
                        Console.WriteLine("currentRunningJob : " + MainForm.queueData.currentRunningJob.ToString());
                        Console.WriteLine("jobProgressBar : " + jobProgressBar.Value.ToString());
                        Console.WriteLine("update taskbar progress : " + taskbarProgressValue.ToString() + " to " + taskbarProgressMax.ToString());
                        TaskbarManager.Instance.SetProgressValue(taskbarProgressValue, taskbarProgressMax);

                        if (MainForm.queueData.currentRunningJobIndex == lastSelectedRow)
                        {
                            outputTextBox.Text = "";
                            outputTextBox.AppendText(MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].output);
                        }
                    }
                }

                DisableControls();
            }
            else
            {
                // automatically clear jobs based on options. Need to be done when the jobs are not running to prevent conflicts
                if (MainForm.optionsData.autoClearOkJobs)
                {
                    MainForm.queueManager.ClearJobs(Properties.Resources.OkJobLabel);
                }
                if (MainForm.optionsData.autoClearWarningJobs)
                {
                    MainForm.queueManager.ClearJobs(Properties.Resources.WarningJobLabel);
                }
                if (MainForm.optionsData.autoClearErrorJobs)
                {
                    MainForm.queueManager.ClearJobs(Properties.Resources.ErrorJobLabel);
                }
                if (MainForm.queueData.processEnded)
                {
                    //Console.WriteLine("processEnded");

                    totalProgressBar.Value = MainForm.queueData.currentRunningJob;

                    TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);

                    jobProgressBar.Value = jobProgressBar.Maximum;
                    ShowSummary();
                    MainForm.queueData.processEnded = false;
                }
                EnableControls();
            }
            jobsDataGridView.Refresh();

        }

        private void ShowSummary()
        {
            bool showSummary;
            // if the options say to show summary enable it
            if (MainForm.optionsData.showSummaryWhenQueueEnds)
            {
                showSummary = true;
            }
            else
            {
                showSummary = false;
            }
            // if the options say to show summary only in case of warnings of errors, evaluate it
            if (showSummary)
            {
                if (MainForm.optionsData.showSummaryOnlyWarningsErrors)
                {
                    if (MainForm.queueData.warnings > 0 || MainForm.queueData.errors > 0)
                    {
                        showSummary = true;
                    }
                    else
                    {
                        showSummary = false;
                    }
                }
            }

            //if the summary needs to be shown, do it
            if (showSummary)
            {
                string messaggeText = Properties.Resources.ElaboratedFiles + ": " + MainForm.queueData.totalJobsToExec + Environment.NewLine + Properties.Resources.WarningJobLabel + ": " + MainForm.queueData.warnings + Environment.NewLine + Properties.Resources.ErrorJobLabel + ": " + MainForm.queueData.errors;
                MessageBox.Show(this, messaggeText, Properties.Resources.Summary, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DisableControls()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            moveJobTopButton.Enabled = false;
            moveJobUpButton.Enabled = false;
            moveJobDownButton.Enabled = false;
            moveJobBottomButton.Enabled = false;
            deleteJobButton.Enabled = false;
            clearQueueButton.Enabled = false;
            createBatButton.Enabled = false;
            startButton.Enabled = false;
            stopButton.Enabled = true;
            queueContextMenuStrip.Enabled = false;
        }
        private void EnableControls()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            moveJobTopButton.Enabled = true;
            moveJobUpButton.Enabled = true;
            moveJobDownButton.Enabled = true;
            moveJobBottomButton.Enabled = true;
            deleteJobButton.Enabled = true;
            clearQueueButton.Enabled = true;
            createBatButton.Enabled = true;
            startButton.Enabled = true;
            stopButton.Enabled = false;
            queueContextMenuStrip.Enabled = true;
        }

        private void UpdateLocale()
        {
            //Console.WriteLine("currentLocale: " + currentLocale);
            //Console.WriteLine("MainForm.optionsData.localeList[MainForm.optionsData.selectedLocaleIndex].localeCode: " + MainForm.optionsData.localeList[MainForm.optionsData.selectedLocaleIndex].localeCode);

            if (currentLocale != MainForm.optionsData.selectedLocale)
            {
                currentLocale = MainForm.optionsData.selectedLocale;
                localeManager.SetLocale(this);
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            MainForm.queueManager.SetQueueNumbers();

            if (MainForm.queueData.totalJobsToExec <= 0)
            {
                MessageBox.Show(Properties.Resources.NothingToStart, Properties.Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(MainForm.optionsData.mkvMergeLocation))
            {
                MessageBox.Show(Properties.Resources.NoMkvMergeLocation, Properties.Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!MainForm.queueData.running)
            {
                MainForm.queueData.running = true;
                MainForm.queueData.warnings = 0;
                MainForm.queueData.errors = 0;

                bool ok = MainForm.queueManager.StartJob();
                if (!ok)
                {
                    MainForm.queueData.running = false;
                    MessageBox.Show(Properties.Resources.NothingToStart, Properties.Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (MainForm.queueData.running)
            {
                MainForm.queueManager.StopJob();
                jobsDataGridView.Refresh();
            }
        }


        private void clearQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainForm.queueData.jobList.Count > 0)
            {
                DialogResult dr = MessageBox.Show(Properties.Resources.AreYouSure, Properties.Resources.WarningLabel, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    MainForm.queueData.jobList.Clear();
                }
            }
        }

        private void QueueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            SaveWindowPositionAndSize();

            //if the user close the queue window, we only hide it
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();

                if (mainForm.WindowState == FormWindowState.Minimized)
                {
                    mainForm.WindowState = MainForm.lastWindowState;
                }
                mainForm.BringToFront();

            }

        }

        private void QueueForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            // this event is not triggered because closing the form is hided
            SaveWindowPositionAndSize();
        }
        private void SaveWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                MainForm.windowsData.queueWindow.maximized = true;
            }
            else
            {
                MainForm.windowsData.queueWindow.maximized = false;
                MainForm.windowsData.queueWindow.width = this.Width;
                MainForm.windowsData.queueWindow.height = this.Height;
                MainForm.windowsData.queueWindow.top = this.Top;
                MainForm.windowsData.queueWindow.left = this.Left;
            }
        }

        private void MoveJob(int source, int destination)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            while (source != destination)
            {
                if (destination > source)
                {
                    var tmp = MainForm.queueData.jobList[source + 1];
                    MainForm.queueData.jobList[source + 1] = MainForm.queueData.jobList[source];
                    MainForm.queueData.jobList[source] = tmp;
                    jobsDataGridView.Rows[destination].Selected = true;
                    source += 1;
                }
                else
                {
                    var tmp = MainForm.queueData.jobList[source - 1];
                    MainForm.queueData.jobList[source - 1] = MainForm.queueData.jobList[source];
                    MainForm.queueData.jobList[source] = tmp;
                    jobsDataGridView.Rows[destination].Selected = true;
                    source -= 1;
                }
            }
        }
        private void moveJobTopButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (jobsDataGridView.SelectedRows.Count > 0)
            {
                MoveJob(jobsDataGridView.SelectedRows[0].Index, 0);
            }
        }

        private void moveJobUpButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (jobsDataGridView.SelectedRows.Count > 0 && jobsDataGridView.SelectedRows[0].Index > 0)
            {
                MoveJob(jobsDataGridView.SelectedRows[0].Index, jobsDataGridView.SelectedRows[0].Index - 1);
            }
        }

        private void moveJobDownButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (jobsDataGridView.SelectedRows.Count > 0 && jobsDataGridView.SelectedRows[0].Index != jobsDataGridView.RowCount - 1)
            {
                MoveJob(jobsDataGridView.SelectedRows[0].Index, jobsDataGridView.SelectedRows[0].Index + 1);
            }
        }

        private void moveJobBottomButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (jobsDataGridView.SelectedRows.Count > 0 && jobsDataGridView.SelectedRows[0].Index != jobsDataGridView.RowCount - 1)
            {
                MoveJob(jobsDataGridView.SelectedRows[0].Index, jobsDataGridView.RowCount - 1);
            }
        }

        private void deleteJobButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (jobsDataGridView.SelectedRows.Count == 1)
            {
                int previuslySelectedindex = jobsDataGridView.SelectedRows[0].Index;
                MainForm.queueData.jobList.RemoveAt(jobsDataGridView.SelectedRows[0].Index);
                if (jobsDataGridView.Rows.Count > 0)
                {
                    int newSelectedIndex = previuslySelectedindex;
                    if (newSelectedIndex > jobsDataGridView.Rows.Count - 1)
                    {
                        newSelectedIndex = previuslySelectedindex - 1;
                    }
                    if (newSelectedIndex < 0)
                    {
                        newSelectedIndex = 0;
                    }
                    jobsDataGridView.Rows[newSelectedIndex].Selected = true;
                }
            }
        }

        private void clearQueueButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (MainForm.queueData.jobList.Count > 0)
            {
                MainForm.queueData.jobList.Clear();
            }
        }


        private void clearQueueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (MainForm.queueData.jobList.Count > 0)
            {
                MainForm.queueData.jobList.Clear();
            }
        }

        private void resetAllOkJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            MainForm.queueManager.ResetJobs(Properties.Resources.OkJobLabel);
            jobsDataGridView.Refresh();
        }

        private void resetAllWarningJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            MainForm.queueManager.ResetJobs(Properties.Resources.WarningJobLabel);
            jobsDataGridView.Refresh();
        }

        private void resetAllErrorJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            MainForm.queueManager.ResetJobs(Properties.Resources.ErrorJobLabel);
            jobsDataGridView.Refresh();
        }

        private void jobsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (jobsDataGridView.SelectedRows.Count == 1 && MainForm.queueData.jobList.Count > 0)
            {
                int index = jobsDataGridView.SelectedRows[0].Index;
                int id = MainForm.queueData.jobList[index].id;
                JobForm jobForm = new JobForm(index, id);
                jobForm.ShowDialog();
            }
        }

        private void clearAllPendingJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            MainForm.queueManager.ClearJobs(Properties.Resources.PendingJobLabel);
            jobsDataGridView.Refresh();
        }
        private void clearAllOkJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            MainForm.queueManager.ClearJobs(Properties.Resources.OkJobLabel);
            jobsDataGridView.Refresh();
        }

        private void clearAllWarningJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            MainForm.queueManager.ClearJobs(Properties.Resources.WarningJobLabel);
            jobsDataGridView.Refresh();
        }

        private void clearAllErrorJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            MainForm.queueManager.ClearJobs(Properties.Resources.ErrorJobLabel);
            jobsDataGridView.Refresh();
        }

        private void createBatButton_Click(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            int count = 0;
            foreach (QueueData.Job job in MainForm.queueData.jobList)
            {
                if (job.jobStatus == Properties.Resources.PendingJobLabel || job.jobStatus == Properties.Resources.RunningJobLabel)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                MessageBox.Show(Properties.Resources.NothingToPutInBat, Properties.Resources.ErrorLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MainForm.queueData.jobList.Count > 0)
            {
                if (String.IsNullOrEmpty(MainForm.mainData.lastBatFilePath))
                {
                    MainForm.mainData.lastBatFilePath = Directory.GetCurrentDirectory();
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    AddExtension = true,
                    DefaultExt = "bat",
                    InitialDirectory = MainForm.mainData.lastBatFilePath,
                    Filter = Properties.Resources.BatFiles + " (*.bat)|*.bat"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(saveFileDialog.FileName) != ".bat")
                    {
                        saveFileDialog.FileName += ".bat";
                    }
                    MainForm.mainData.lastBatFilePath = Path.GetDirectoryName(saveFileDialog.FileName);
                    MainForm.queueManager.CreateBat(saveFileDialog.FileName);
                    DialogResult dr = MessageBox.Show(Properties.Resources.BatCreatedClearQueue, Properties.Resources.WarningLabel, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {
                        for (int i = MainForm.queueData.jobList.Count - 1; i >= 0; i--)
                        {
                            if (MainForm.queueData.jobList[i].jobStatus == Properties.Resources.PendingJobLabel
                             || MainForm.queueData.jobList[i].jobStatus == Properties.Resources.RunningJobLabel)
                            {
                                MainForm.queueData.jobList.RemoveAt(i);
                            }
                        }
                        MainForm.queueManager.SetQueueNumbers();
                    }
                }
            }
        }

        private void QueueForm_Resize(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            // When window state changes
            if (WindowState != lastWindowState)
            {
                if (WindowState == FormWindowState.Maximized || WindowState == FormWindowState.Normal)
                {
                    lastWindowState = WindowState;
                }
            }
        }
        public FormWindowState GetLastWindowState()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            return lastWindowState;
        }

        private void jobsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (jobsDataGridView.SelectedRows.Count > 0)
            {
                if (jobsDataGridView.SelectedRows[0].Index != lastSelectedRow)
                {
                    lastSelectedRow = jobsDataGridView.SelectedRows[0].Index;
                    outputTextBox.Text = "";
                    outputTextBox.AppendText(MainForm.queueData.jobList[jobsDataGridView.SelectedRows[0].Index].output);
                }

            }
        }

        private void autoClearOkJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!loadingForm)
            {
                MainForm.optionsData.autoClearOkJobs = autoClearOkJobsToolStripMenuItem.Checked;
                queueContextMenuStrip.Show();
            }
        }
        private void autoClearWarningJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!loadingForm)
            {
                MainForm.optionsData.autoClearWarningJobs = autoClearWarningJobsToolStripMenuItem.Checked;
                queueContextMenuStrip.Show();
            }
        }

        private void autoClearErrorJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!loadingForm)
            {
                MainForm.optionsData.autoClearErrorJobs = autoClearErrorJobsToolStripMenuItem.Checked;
                queueContextMenuStrip.Show();
            }
        }
    }
}
