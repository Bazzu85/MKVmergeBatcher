using MKVmergeBatcher.Properties;
using MKVmergeBatcher.src.obj;
using PostSharp.Patterns.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKVmergeBatcher.src
{
    [NotifyPropertyChanged]

    public partial class ExecuteBatchForm : Form
    {
        private UserData userData;
        //StreamWriter streamWriter;
        //StreamReader streamReader;
        Process process;


        private List<string> videoFileList;
        private int selectedIndex;
        private int workingFile = 0;
        private int totalFileToExecute = 0;
        private string currentElaboratingFile = "";
        private string output = "";
        private bool processRunning = false;
        private bool processEnded = false;
        private int progressPercentage = 0;
        private int warnings = 0;
        private int errors = 0;

        public ExecuteBatchForm(UserData userData, List<string> videoFileList, int selectedIndex)
        {
            this.userData = userData;
            this.videoFileList = videoFileList;
            this.selectedIndex = selectedIndex;
            InitializeComponent();
            RestoreWindowData();
            totalFileToExecute = videoFileList.Count();
            UpdateFormControls();
            timer.Interval = 1000;
            //timer.Enabled = true;
        }

        #region Generic Methods
        private void RestoreWindowData()
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.Manual;

            // Set window location
            if (Settings.Default.WindowLocation != null)
            {
                this.Location = Settings.Default.WindowLocation;
            }
        }
        private void UpdateFormControls()
        {
            workingOnLabel.Text = "Working on file number " + workingFile + " of " + totalFileToExecute;
            fileNameTextBox.Text = currentElaboratingFile;
            this.progressBar.Value = progressPercentage;
            warningsLabel.Text = "Warnings: " + warnings;
            errorsLabel.Text = "Errors: " + errors;
            if (processRunning)
            {
                startButton.Enabled = false;
                stopButton.Enabled = true;
            } else
            {
                startButton.Enabled = true;
                stopButton.Enabled = false;
            }
            /*
            outputTextBox.Text = output;
            outputTextBox.SelectionStart = outputTextBox.Text.Length;
            outputTextBox.ScrollToCaret();
            */
            if (!String.IsNullOrEmpty(output))
            {
                outputTextBox.AppendText(Environment.NewLine + output);
                output = "";
            }
            if (processEnded)
            {
                processEnded = false;
                string messaggeText = "Elaborated files: " + totalFileToExecute + Environment.NewLine + "Warnings: " + warnings + Environment.NewLine + "Errors: " + errors;
                MessageBox.Show(this, messaggeText, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void LaunchProcess()
        {
            workingFile += 1;
            currentElaboratingFile = this.videoFileList[workingFile - 1];
            BatcherManagement batcherManagement = new BatcherManagement(userData);
            string cmdLine = batcherManagement.CreateCmd(this.videoFileList[workingFile - 1], this.selectedIndex);

            cmdLine = cmdLine.Replace("\"" + userData.batcher.mvkMergePath + "\"", "");
            cmdLine = cmdLine.Replace("^","");

            process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = userData.batcher.mvkMergePath,
                    Arguments = cmdLine,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true,
                    CreateNoWindow = true,
                    StandardOutputEncoding = Encoding.UTF8
                },
                EnableRaisingEvents = true
            };
            process.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);
            process.ErrorDataReceived += new DataReceivedEventHandler(SortErrorHandler);
            process.Exited += new EventHandler(ProcessExitedHandler);

            process.Start();

            /*
            streamWriter = new StreamWriter(process.StandardInput.BaseStream, Encoding.GetEncoding(Thread.CurrentThread.CurrentCulture.TextInfo.OEMCodePage));
            streamWriter = new StreamWriter(process.StandardInput.BaseStream);
            streamWriter.AutoFlush = true;
            streamWriter.WriteLine(cmdLine);
            streamWriter.WriteLine("exit");
            streamWriter.Close();
            */

            process.BeginOutputReadLine();
            }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;

            if (!processRunning)
            {
                startButton.Enabled = false;
                stopButton.Enabled = true;
                processRunning = true;
                workingFile = 0;
                progressPercentage = 0;
                warnings = 0;
                errors = 0;
                output = "";
                LaunchProcess();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            KillProcess();
        }


        private void ExecuteBatchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            KillProcess();
        }

        private void KillProcess()
        {
            if (processRunning)
            {
                processRunning = false;
                KillProcessAndChildrens(process.Id);
                //timer.Enabled = false;
            }
        }

        /// <summary>
        /// Kill a process and related childs by id
        /// </summary>
        /// <param name="processId">The process ID</param>
        private static void KillProcessAndChildrens(int processId)
        {
            ManagementObjectSearcher processSearcher = new ManagementObjectSearcher
              ("Select * From Win32_Process Where ParentProcessID=" + processId);
            ManagementObjectCollection processCollection = processSearcher.Get();


            try
            {
                Process proc = Process.GetProcessById(processId);
                //Console.WriteLine("KillProcessAndChildrens: processId: " + proc.Id);
                //Console.WriteLine("KillProcessAndChildrens: processName: " + proc.ProcessName);

                if (!proc.HasExited) proc.Kill();
            }
            catch (ArgumentException)
            {
                // Process already exited.
            }

            if (processCollection != null)
            {
                foreach (ManagementObject mo in processCollection)
                {
                    KillProcessAndChildrens(Convert.ToInt32(mo["ProcessID"])); //kill child processes(also kills childrens of childrens etc.)
                }
            }
        }

        private void SortOutputHandler(object sender, DataReceivedEventArgs outLine)
        {
            Process process = (Process)sender;

            if (!String.IsNullOrEmpty(outLine.Data))
            {
                if (String.IsNullOrEmpty(output))
                {
                    output += outLine.Data;
                }
                else
                {
                    output += Environment.NewLine + outLine.Data;
                }
            }
        }
        private void SortErrorHandler(object sender, DataReceivedEventArgs errLine)
        {
            if (!String.IsNullOrEmpty(errLine.Data))
            {
                if (String.IsNullOrEmpty(output))
                {
                    output += errLine.Data;
                }
                else
                {
                    output += Environment.NewLine + errLine.Data;
                }
            }
        }
        private void ProcessExitedHandler(object sender, EventArgs e)
        {
            if (processRunning)
            {
                switch (process.ExitCode)
                {
                    case 1:
                        warnings += 1;
                        break;
                    case 2:
                        errors += 1;
                        break;
                }
                progressPercentage = (workingFile * 100) / totalFileToExecute;
                if (workingFile != totalFileToExecute)
                {
                    LaunchProcess();
                }
                else
                {
                    //timer.Enabled = false;
                    processRunning = false;
                    processEnded = true;
                    }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateFormControls();
            if (process != null && process.HasExited && !processRunning)
            {
                timer.Enabled = false;
            }
        }
    }
}
