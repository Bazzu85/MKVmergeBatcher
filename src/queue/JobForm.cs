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
        public JobForm(int inputJobIndex)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            InitializeComponent();

            refreshTimer.Enabled = true;

            this.jobIndex = inputJobIndex;
            localeManager.SetLocale(this);
            RestoreWindowPositionAndSize();
            SetDataSource();
            SetControlsContent();
        }
        private void RestoreWindowPositionAndSize()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (MainForm.windowsData.jobWindow.width > 0 && MainForm.windowsData.jobWindow.height > 0)
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

            if (MainForm.queueData.running)
            {
                if (MainForm.queueData.currentRunningJobIndex >= 0)
                {
                    outputTextBox.Text = "";
                    outputTextBox.AppendText(MainForm.queueData.jobList[jobIndex].output);
                }
            }
            else
            {
                if (jobIndex > MainForm.queueData.jobList.Count - 1)
                {
                    MessageBox.Show(this, Properties.Resources.JobNoLongerAvailable, Properties.Resources.WarningLabel, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    if (outputTextBox.Text != MainForm.queueData.jobList[jobIndex].output)
                    {
                        outputTextBox.Text = "";
                        outputTextBox.AppendText(MainForm.queueData.jobList[jobIndex].output);
                    }
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
            SetControlsContent();
            ResetFormBindings();
            refreshTimer.Enabled = true;
        }
    }
}