using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace MKVmergeBatcher.src.queue
{
    public class QueueManager
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public MainForm mainForm;
        public List<string> videoFileList = new List<string>();
        public string errorList = "";
        public Process process;
        public string cmdLine = "";
        public string output = "";
        public bool wait = false;

        public bool CheckJobs(MainForm inputMainForm)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            bool result = true;
            errorList = "";
            int errorIndex = 0;

            mainForm = inputMainForm;

            if (MainForm.modelsData.modelList.Count == 0)
            {
                errorIndex += 1;
                AddError(Properties.Resources.ErrorLabel + " n." + errorIndex + ": " + Properties.Resources.EmptyModelList);
                result = false;
            }
            if (String.IsNullOrEmpty(MainForm.optionsData.mkvMergeLocation))
            {
                errorIndex += 1;
                AddError(Properties.Resources.ErrorLabel + " n." + errorIndex + ": " + Properties.Resources.NoMkvMergeLocation);
                return false;
            }

            if (MainForm.mainData.videoFileList.Count == 0)
            {
                errorIndex += 1;
                AddError(Properties.Resources.ErrorLabel + " n." + errorIndex + ": " + Properties.Resources.NoFilesToAddToQueue);
                result = false;
            }

            ExtractVideoFileListToWorkOn();
            foreach (string item in videoFileList)
            {
                foreach (QueueData.Job job in MainForm.queueData.jobList)
                {
                    if (item == job.fileFullPath)
                    {
                        errorIndex += 1;
                        AddError(Properties.Resources.ErrorLabel + " n." + errorIndex + ": " + Properties.Resources.File + " " + job.fileName + " " + Properties.Resources.FileAlreadyInQueue);
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }

        private void AddError(string message)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (String.IsNullOrEmpty(errorList))
            {
                errorList += message;
            }
            else
            {
                errorList += "\n" + message;
            }
        }
        private List<string> ExtractVideoFileListToWorkOn()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (videoFileList.Count > 0)
            {
                videoFileList.Clear();
            }

            if (mainForm.videoFileListBox.SelectedIndices.Count == 0)
            {
                foreach (MainData.VideoFile videoFile in mainForm.videoFileListBox.Items)
                {
                    videoFileList.Add(videoFile.videoFileName);
                }
            }
            else
            {
                foreach (MainData.VideoFile videoFile in mainForm.videoFileListBox.SelectedItems)
                {
                    videoFileList.Add(videoFile.videoFileName);
                }
            }
            return videoFileList;
        }

        public void AddToQueue(MainForm inputMainForm)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            mainForm = inputMainForm;

            if (MainForm.mainData.videoFileList.Count > 0)
            {
                ExtractVideoFileListToWorkOn();
                foreach (string item in videoFileList)
                {
                    QueueData.Job job = GenerateJob(item);
                    MainForm.queueData.jobList.Add(job);
                }
            }
        }

        private QueueData.Job GenerateJob(string file)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            QueueData.Job job = new QueueData.Job();
            job.fileFullPath = file;
            job.fileFolder = Path.GetDirectoryName(file);
            job.fileName = Path.GetFileName(file);
            job.fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
            job.percentage = 0;
            job.jobStatus = Properties.Resources.PendingJobLabel;
            job.jobExecuted = false;
            job.command = MainForm.modelsData.modelList[MainForm.modelsData.lastModelUsed].command;

            job.command = job.command.Replace("||mkvmergePath||", MainForm.optionsData.mkvMergeLocation);

            // generate the outputfile with a unique name
            int i = 0;
            string outputFileFullPath = job.fileFolder + "\\" + job.fileNameWithoutExtension + ".mkv";
            while (File.Exists(outputFileFullPath))
            {
                i++;
                outputFileFullPath = job.fileFolder + "\\" + job.fileNameWithoutExtension + " (" + i + ")" + ".mkv";
            }
            job.command = job.command.Replace("||outputFileFullPath||", outputFileFullPath);
            job.command = job.command.Replace("||inputFileFolder||", job.fileFolder);
            job.command = job.command.Replace("||inputFileName||", job.fileName);
            job.command = job.command.Replace("||inputFileNameWithoutExtension||", job.fileNameWithoutExtension);

            // check if attachments are found and add it. the file needs to be in a folder named as the working file
            if (job.command.Contains("||attachments||"))
            {
                string attachmentsDirectory = job.fileFolder + "\\" + job.fileNameWithoutExtension;
                string attachmentsString = "";

                if (Directory.Exists(attachmentsDirectory))
                {
                    string[] allFiles = Directory.GetFiles(attachmentsDirectory, "*.*", SearchOption.TopDirectoryOnly);
                    if (allFiles.Length != 0)
                    {
                        foreach (string item in allFiles)
                        {
                            // Check file dimension. Use only file with dimension > 0
                            FileInfo fi = new FileInfo(item);
                            if (fi.Length > 0)
                            {
                                attachmentsString += "--attach-file ^\"" + item + "^\" ";
                            }
                        }
                        job.command = job.command.Replace("||attachments||", attachmentsString);

                    }
                }
                else
                {
                    job.command = job.command.Replace("||attachments|| ", "");
                }
            }

            //if ||chapters|| is in model search the fileName_chapters.xml file and add to the cmdLine
            if (job.command.Contains("||chapters||"))
            {
                string capthersFile = job.fileFolder + "\\" + job.fileNameWithoutExtension + "_chapters.xml";
                if (File.Exists(capthersFile))
                {
                    string capthersString = " --chapters ^\"" + capthersFile + "^\" ";
                    job.command = job.command.Replace("||chapters||", capthersString);
                }
                else
                {
                    job.command = job.command.Replace("||chapters|| ", "");
                }
            }
            job.outputFileName = outputFileFullPath;
            return job;

        }

        internal bool StartJob()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            SetCurrentRunningJobIndex();
            if (MainForm.queueData.currentRunningJobIndex < 0)
            {
                return false;
            }
            MainForm.queueData.currentRunningJob++;
            MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].jobStatus = Properties.Resources.RunningJobLabel;
            MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].percentage = 0;
            MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].output = "";

            cmdLine = MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].command;
            cmdLine = cmdLine.Replace("\"" + MainForm.optionsData.mkvMergeLocation + "\"", "");
            cmdLine = cmdLine.Replace("^", "");
            process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = MainForm.optionsData.mkvMergeLocation,
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
            process.BeginOutputReadLine();
            Logger.Info("Process started [" + process.ProcessName + "][" + process.Id + "]");
            //Console.WriteLine("log level info?? " + Logger.IsInfoEnabled);
            Logger.Info("Input file name: " + MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].fileName);
            return true;
        }

        internal void StopJob()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (MainForm.queueData.running)
            {
                Logger.Info("Stop jobs requested");

                MainForm.queueData.running = false;
                while (wait)
                {
                    Thread.Sleep(1000);
                }
                KillProcessAndChildrens(process.Id);
                if (MainForm.optionsData.deleteIncompleteFiles)
                {
                    DeleteIncompleteFile();
                }
                foreach (QueueData.Job job in MainForm.queueData.jobList)
                {
                    if (job.jobStatus == Properties.Resources.RunningJobLabel)
                    {
                        job.jobStatus = Properties.Resources.PendingJobLabel;
                    }
                }
                Logger.Info("Stop jobs executed");
            }
        }

        /// <summary>
        /// Kill a process and related childs by id
        /// </summary>
        /// <param name="processId">The process ID</param>
        private static void KillProcessAndChildrens(int processId)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

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


        private void DeleteIncompleteFile()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            //Console.WriteLine("Deleting file :" + outputFileName);
            string outputFileName = MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].outputFileName;
            if (File.Exists(outputFileName))
            {
                FileInfo file = new FileInfo(outputFileName);
                while (IsFileLocked(file))
                {
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
        private void SortOutputHandler(object sender, DataReceivedEventArgs outLine)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (!String.IsNullOrEmpty(outLine.Data))
            {
                //Console.WriteLine("outLine.Data: " + outLine.Data);
                if (String.IsNullOrEmpty(MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].output))
                {
                    MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].output += outLine.Data;
                }
                else
                {
                    MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].output += Environment.NewLine + outLine.Data;
                }
                //Console.WriteLine("output: " + MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].output);
                //Console.WriteLine("outputJobForm: " + MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].outputJobForm);

                if (outLine.Data.EndsWith("%"))
                {
                    foreach (Match match in Regex.Matches(outLine.Data, @"(\d+)%"))
                    {
                        MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].percentage = Int32.Parse(match.Groups[1].Value);
                    }
                    //Console.WriteLine("updating percentage in manager: " + MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].percentage);
                }
            }
        }
        private void SortErrorHandler(object sender, DataReceivedEventArgs errLine)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

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
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (MainForm.queueData.running)
            {
                wait = true;
                try
                {
                    Logger.Info("Process " + process.ProcessName + " [" + process.Id + "] Exit code: " + process.ExitCode);
                    Logger.Info("Output file name: " + MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].outputFileName);

                    switch (process.ExitCode)
                    {
                        case 0:
                            MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].jobStatus = Properties.Resources.OkJobLabel;
                            MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].percentage = 100;
                            if (!string.IsNullOrEmpty(MainForm.optionsData.moveOkFilesTo))
                            {
                                MoveFile(MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].outputFileName, MainForm.optionsData.moveOkFilesTo);
                            }
                            break;
                        case 1:
                            MainForm.queueData.warnings += 1;
                            MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].jobStatus = Properties.Resources.WarningJobLabel;
                            if (!string.IsNullOrEmpty(MainForm.optionsData.moveWarningFilesTo))
                            {
                                MoveFile(MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].outputFileName, MainForm.optionsData.moveWarningFilesTo);
                            }
                            break;
                        case 2:
                            MainForm.queueData.errors += 1;
                            MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].jobStatus = Properties.Resources.ErrorJobLabel;
                            break;
                    }
                    MainForm.queueData.jobList[MainForm.queueData.currentRunningJobIndex].jobExecuted = true;
                }
                catch (InvalidOperationException ex)
                {
                    Logger.Info(ex);

                }
                wait = false;
                if (MainForm.queueData.currentRunningJob != MainForm.queueData.totalJobsToExec)
                {
                    Thread.Sleep(1000);
                    SetCurrentRunningJobIndex();
                    StartJob();
                }
                else
                {
                    MainForm.queueData.running = false;
                    MainForm.queueData.processEnded = true;
                }
            }
        }

        internal void CreateBat(string batFile)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            List<string> batLinesList = new List<string>();

            foreach (QueueData.Job job in MainForm.queueData.jobList)
            {
                if (!job.jobExecuted)
                {
                    string cmdLine = job.command;
                    cmdLine += ">> " + Path.GetFileNameWithoutExtension(batFile) + ".log";
                    batLinesList.Add(cmdLine);
                }
            }

            batLinesList.Add("pause");
            //Get current code page to write file. For italy is 850
            int currentCodePage = Thread.CurrentThread.CurrentCulture.TextInfo.OEMCodePage;
            File.WriteAllLines(batFile, batLinesList.ToArray(), Encoding.GetEncoding(currentCodePage));
        }

        private void SetCurrentRunningJobIndex()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            int i = 0;
            foreach (QueueData.Job job in MainForm.queueData.jobList)
            {
                if (!job.jobExecuted)
                {
                    MainForm.queueData.currentRunningJobIndex = i;
                    break;
                }
                i++;
            }
        }

        private void MoveFile(string fileName, string fileNewFolder)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            // if the destination folder is the original one, no move to do
            if (fileNewFolder == "||originalFolder||")
            {
                return;
            }
            //Change the wildcard with the file directory (if in destination folder string)
            string destinationPath = fileNewFolder;

            destinationPath = destinationPath.Replace("||originalFolder||", Path.GetDirectoryName(fileName));

            string destinationFile = destinationPath + "\\" + Path.GetFileName(fileName);

            // Prepend long file path support
            if (!destinationFile.StartsWith(@"\\?\"))
            {
                destinationFile = @"\\?\" + destinationFile;
            }

            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            }

            //if the destination folder is not writable, no move to do
            if (!IsDirectoryWritable(destinationPath, false))
            {
                return;
            }


            if (MainForm.optionsData.replaceExistingDestinationFiles)
            {
                string destinationFileBackup = destinationFile;
                int i = 0;
                while (File.Exists(destinationFileBackup))
                {
                    i++;
                    destinationFileBackup = Path.GetDirectoryName(destinationFile) + "\\" + Path.GetFileNameWithoutExtension(destinationFile) + "_backup" + i + Path.GetExtension(destinationFile);
                }
                if (File.Exists(destinationFile))
                {
                    File.Replace(fileName, destinationFile, destinationFileBackup);
                    Logger.Info("Moved " + fileName + " to " + destinationFile + " making a backup (" + destinationFileBackup + ")");

                }
                else
                {
                    try
                    {
                        File.Move(fileName, destinationFile);
                        Logger.Info("Moved " + fileName + " to " + destinationFile);
                    }
                    catch (Exception ex)
                    {
                        Logger.Info("Cannot move " + fileName + " to " + destinationFile);
                        Logger.Info("Error: " + ex);
                    }
                }
            }
            else
            {
                if (!File.Exists(destinationFile))
                {
                    try
                    {
                        File.Move(fileName, destinationFile);
                        Logger.Info("Moved " + fileName + " to " + destinationFile);
                    }
                    catch (Exception ex)
                    {
                        Logger.Info("Cannot move " + fileName + " to " + destinationFile);
                        Logger.Info("Error: " + ex);
                    }
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
        public void ResetJobs(string inputJobStatus)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            foreach (QueueData.Job job in MainForm.queueData.jobList)
            {
                if (job.jobStatus == inputJobStatus)
                {
                    job.jobStatus = Properties.Resources.PendingJobLabel;
                    job.jobExecuted = false;
                    job.percentage = 0;
                }
            }
            MainForm.queueManager.SetQueueNumbers();
        }

        public void ClearJobs(string inputJobStatus)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            int i = 0;
            while (i < MainForm.queueData.jobList.Count)
            {
                if (MainForm.queueData.jobList[i].jobStatus == inputJobStatus)
                {
                    MainForm.queueData.jobList.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        public void SetQueueNumbers()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            MainForm.queueData.currentRunningJob = 0;
            MainForm.queueData.currentRunningJobIndex = -1;
            
            MainForm.queueData.warnings = 0;
            MainForm.queueData.errors = 0;

            //update the total jobs number
            MainForm.queueData.totalJobsToExec = 0;
            foreach (QueueData.Job job in MainForm.queueData.jobList)
            {
                if (!job.jobExecuted)
                {
                    MainForm.queueData.totalJobsToExec++;
                }
            }
        }
    }
}
