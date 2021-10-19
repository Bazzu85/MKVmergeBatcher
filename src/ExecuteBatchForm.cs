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
        private Boolean executeFromQueue;
        private int workingFile = 0;
        private int totalFileToExecute = 0;
        private string currentElaboratingFile = "";
        private string outputFileName = "";
        private string output = "";
        private bool processRunning = false;
        private bool processEnded = false;
        private int progressPercentage = 0;
        private int warnings = 0;
        private int errors = 0;

        public ExecuteBatchForm(UserData userData, List<string> videoFileList, int selectedIndex, Boolean executeFromQueue)
        {
            this.userData = userData;
            this.videoFileList = videoFileList;
            this.selectedIndex = selectedIndex;
            this.executeFromQueue = executeFromQueue;
            InitializeComponent();
            RestoreWindowData();
            if (executeFromQueue)
            {
                totalFileToExecute = userData.queueManagement.queueList.Count();
            } else
            {
                totalFileToExecute = videoFileList.Count();
            }
            
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
                /*
                if (this.executeFromQueue)
                {
                    userData.queueManagement.queueList.Clear();
                }
                */
                
            }
        }
        #endregion

        private void LaunchProcess()
        {
            workingFile += 1;
            string cmdLine = "";
            if (executeFromQueue)
            {
                currentElaboratingFile = this.userData.queueManagement.queueList[workingFile - 1].fileName;
                BatcherManagement batcherManagement = new BatcherManagement(userData);
                cmdLine = batcherManagement.CreateCmd(this.userData.queueManagement.queueList[workingFile - 1].fileName, this.userData.queueManagement.queueList[workingFile - 1].modelIndex);
                outputFileName = batcherManagement.GetOutputFileName(userData.queueManagement.queueList[workingFile - 1].fileName);
            }
            else
            {
                currentElaboratingFile = this.videoFileList[workingFile - 1];
                BatcherManagement batcherManagement = new BatcherManagement(userData);
                cmdLine = batcherManagement.CreateCmd(this.videoFileList[workingFile - 1], this.selectedIndex);
                outputFileName = batcherManagement.GetOutputFileName(this.videoFileList[workingFile - 1]);
            }

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

        private void DeleteIncompleteFile()
        {   
            // Console.WriteLine("Deleting file :" + outputFileName);
            if (File.Exists(outputFileName))
            {
                FileInfo file = new FileInfo(outputFileName);
                while (IsFileLocked(file))
                {
                    //Console.WriteLine("sleep");
                    Thread.Sleep(1000);
                }
                File.Delete(outputFileName);
            }
        }

        protected virtual bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
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
                if (userData.options.deleteIncompleteFile)
                {
                    DeleteIncompleteFile();
                }
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
                    case 0:
                        if (this.executeFromQueue)
                        {
                            userData.queueManagement.queueList[workingFile - 1].jobStatus = "OK";
                        }
                        if (!string.IsNullOrEmpty(userData.options.moveOkFilesTo))
                        {
                            MoveFile(outputFileName, userData.options.moveOkFilesTo);
                        }
                        break;
                    case 1:
                        warnings += 1;
                        if (this.executeFromQueue)
                        {
                            userData.queueManagement.queueList[workingFile - 1].jobStatus = "Warning";
                        }
                        if (!string.IsNullOrEmpty(userData.options.moveWarningFilesTo))
                        {
                            MoveFile(outputFileName, userData.options.moveWarningFilesTo);
                        }
                        break;
                    case 2:
                        errors += 1;
                        if (this.executeFromQueue)
                        {
                            userData.queueManagement.queueList[workingFile - 1].jobStatus = "Error";
                        }
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

        private void MoveFile(string fileName, string fileNewFolder)
        {
            //Change the wildcard with the file directory (if in destination folder string)
            string destinationPath = fileNewFolder;
            destinationPath = destinationPath.Replace("%originalFolder%", Path.GetDirectoryName(fileName));

            
            //Console.WriteLine("destinationPath: " + destinationPath);

            string destinationFile = destinationPath + "\\" + Path.GetFileName(fileName);

            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            }

            //if the destination folder is not writable, no move to do
            if (!IsDirectoryWritable(destinationPath, false))
            {
                return;
            }


            if (userData.options.replaceExistingDestinationFile)
            {
                string destinationFileBackup = destinationFile;
                int i = 0;
                while (File.Exists(destinationFileBackup))
                {
                    i++;
                    destinationFileBackup = Path.GetDirectoryName(destinationFile) + "\\" + Path.GetFileNameWithoutExtension(destinationFile) + "_backup" + i + Path.GetExtension(destinationFile);
                }
                if (File.Exists(destinationFile)){
                    File.Replace(fileName, destinationFile, destinationFileBackup);
                } else
                {
                    File.Move(fileName, destinationFile);
                }

            } else
            {
                if (!File.Exists(destinationFile)){
                    File.Move(fileName, destinationFile);
                }
            }
        }

        public bool IsDirectoryWritable(string dirPath, bool throwIfFails = false)
        {
            try
            {
                using (FileStream fs = File.Create(
                    Path.Combine(
                        dirPath,
                        Path.GetRandomFileName()
                    ),
                    1,
                    FileOptions.DeleteOnClose)
                )
                { }
                return true;
            }
            catch
            {
                if (throwIfFails)
                    throw;
                else
                    return false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateFormControls();
            try
            {
                if (process != null)
                {
                    //Console.WriteLine("process: " + process.ProcessName);
                    //Console.WriteLine("process.HasExited: " + process.HasExited);
                    //Console.WriteLine("processRunning: " + processRunning);
                    if (process.HasExited && !processRunning)
                    {
                        timer.Enabled = false;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("error: " + ex.Message);
            }
        }
    }
}
