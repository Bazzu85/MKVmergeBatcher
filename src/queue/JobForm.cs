﻿using NLog;
using System;
using System.Windows.Forms;

namespace MKVmergeBatcher.src.queue
{
    public partial class JobForm : Form
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public LocaleManager localeManager = new LocaleManager();

        public int jobIndex;
        public int jobId;
        public bool jobNoLongerAvailable = false;
        public JobForm(int inputJobIndex, int inputJobId)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            InitializeComponent();
            this.jobIndex = inputJobIndex;
            this.jobId = inputJobId;
            // if the current job is not executed activate the refresh timer
            if (MainForm.queueData.jobList[jobIndex].id == jobId && !MainForm.queueData.jobList[jobIndex].jobExecuted)
            {
                refreshTimer.Enabled = true;
            }
            jobStillAvailableTimer.Enabled = true;
            localeManager.SetLocale(this);
            RestoreWindowPositionAndSize();
            SetDataSource();
            SetControlsContent();
        }
        private void RestoreWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (MainForm.windowsData.jobWindow.width > 0 && MainForm.windowsData.jobWindow.height > 0 && MainForm.windowsData.jobWindow.top > 0 && MainForm.windowsData.jobWindow.left > 0)
            {
                //this is mandatory to make the position modification working
                this.StartPosition = FormStartPosition.Manual;
                this.Width = MainForm.windowsData.jobWindow.width;
                this.Height = MainForm.windowsData.jobWindow.height;
                this.Top = MainForm.windowsData.jobWindow.top;
                this.Left = MainForm.windowsData.jobWindow.left;
                if (MainForm.windowsData.jobWindow.maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void SetDataSource()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (MainForm.queueData.jobList.Count > 0)
            {
                this.jobBindingSource.DataSource = MainForm.queueData.jobList[jobIndex];
            }

        }
        private void SetControlsContent()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (MainForm.queueData.jobList.Count > 0 && jobIndex < MainForm.queueData.jobList.Count && MainForm.queueData.jobList[jobIndex].id == jobId)
            {
                if (outputTextBox.Text != MainForm.queueData.jobList[jobIndex].output)
                {
                    outputTextBox.Text = "";
                    outputTextBox.AppendText(MainForm.queueData.jobList[jobIndex].output);
                }
            }
        }
        private void ResetFormBindings()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            this.jobBindingSource.ResetBindings(false);
        }

        private void JobForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (jobNoLongerAvailable)
            {
                MessageBox.Show(this, Properties.Resources.JobNoLongerAvailable, Properties.Resources.WarningLabel, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SaveWindowPositionAndSize();
        }
        private void SaveWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                MainForm.windowsData.jobWindow.maximized = true;
            }
            else
            {
                MainForm.windowsData.jobWindow.maximized = false;
                MainForm.windowsData.jobWindow.width = this.Width;
                MainForm.windowsData.jobWindow.height = this.Height;
                MainForm.windowsData.jobWindow.top = this.Top;
                MainForm.windowsData.jobWindow.left = this.Left;
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            refreshTimer.Enabled = false;
            CheckIfJobIsAvailable();
            if (jobNoLongerAvailable)
            {
                return;
            }
            SetControlsContent();
            ResetFormBindings();
            // if the job is not marked as executed, re-enable the timer
            if (!MainForm.queueData.jobList[jobIndex].jobExecuted)
            {
                refreshTimer.Enabled = true;
            }
        }

        private void CheckIfJobIsAvailable()
        {
            if (MainForm.queueData.jobList.Count > 0 && jobIndex < MainForm.queueData.jobList.Count && MainForm.queueData.jobList[jobIndex].id == jobId)
            {

            }
            else
            {
                jobNoLongerAvailable = true;
                this.Close();
                return;
            }
        }

        private void jobStillAvailableTimer_Tick(object sender, EventArgs e)
        {
            CheckIfJobIsAvailable();
            if (jobNoLongerAvailable)
            {
                return;
            }
        }
    }
}
