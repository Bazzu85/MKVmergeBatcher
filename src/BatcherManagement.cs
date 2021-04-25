using MKVmergeBatcher.src.obj;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace MKVmergeBatcher
{
    internal class BatcherManagement
    {
        public UserData userData = new UserData();

        public BatcherManagement(UserData userData)
        {
            this.userData = userData;
        }

        internal void CreateBat(List<string> videoFileList, string batFileName, int selectedModelIndex, Boolean executeFromQueue)
        {
            List<string> batLinesList = new List<string>();

            if (executeFromQueue)
            {
                foreach (UserData.QueueManagement.Queue queue in this.userData.queueManagement.queueList)
                {
                    string cmdLine = CreateCmd(queue.fileName, queue.modelIndex);
                    cmdLine += ">> " + Path.GetFileNameWithoutExtension(batFileName) + ".log";
                    batLinesList.Add(cmdLine);
                }
            }
            else
            {
                foreach (string videoFile in videoFileList)
                {
                    string cmdLine = CreateCmd(videoFile, selectedModelIndex);
                    cmdLine += ">> " + Path.GetFileNameWithoutExtension(batFileName) + ".log";
                    batLinesList.Add(cmdLine);
                }
            }

            batLinesList.Add("pause");
            //Get current code page to write file. For italy is 850
            int currentCodePage = Thread.CurrentThread.CurrentCulture.TextInfo.OEMCodePage;
            File.WriteAllLines(batFileName, batLinesList.ToArray(), Encoding.GetEncoding(currentCodePage));
        }

        internal string CreateCmd(string videoFile, int selectedModelIndex)
        {
            string mkvmergePath = userData.batcher.mvkMergePath;
            string cmdLine = "";
            string outputFileName = GetOutputFileName(videoFile);
            string inputFileName = videoFile;
            string inputFileNameWithoutExtension = Path.GetDirectoryName(videoFile) + "\\" + Path.GetFileNameWithoutExtension(videoFile);
            cmdLine += userData.modelManagement.modelList[selectedModelIndex].modelContent;
            cmdLine = cmdLine.Replace("||mkvmergePath||", mkvmergePath);
            cmdLine = cmdLine.Replace("||outputFileName||", outputFileName);
            cmdLine = cmdLine.Replace("||inputFileName||", inputFileName);
            cmdLine = cmdLine.Replace("||inputFileNameWithoutExtension||", inputFileNameWithoutExtension);

            //Grab all files from a folder named a file name to append it replacing the ||attachments|| tag
            if (cmdLine.Contains("||attachments||"))
            {
                string attachmentsDirectory = Path.GetDirectoryName(videoFile) + "\\" + Path.GetFileNameWithoutExtension(videoFile);
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
                            if (fi.Length > 0) {
                                attachmentsString += "--attach-file ^\"" + item + "^\" ";
                            }
                        }
                        cmdLine = cmdLine.Replace("||attachments||", attachmentsString);

                    }
                }
                else
                {
                    cmdLine = cmdLine.Replace("||attachments||", "");
                }
            }
            //if ||chapters|| is in model search the fileName_chapters.xml file and add to the cmdLine
            if (cmdLine.Contains("||chapters||"))
            {
                string capthersFile = Path.GetDirectoryName(videoFile) + "\\" + Path.GetFileNameWithoutExtension(videoFile) + "_chapters.xml";
                if (File.Exists(capthersFile)) {
                    string capthersString = " --chapters ^\"" + capthersFile + "^\" ";
                    cmdLine = cmdLine.Replace("||chapters||", capthersString);
                } else
                {
                    cmdLine = cmdLine.Replace("||chapters||", "");
                }
            }
            return cmdLine;
        }

        internal string GetOutputFileName(string file)
        {
            string outputFileName = Path.GetDirectoryName(file) + "\\" + Path.GetFileNameWithoutExtension(file) + ".mkv";
            int i = 0;
            while (File.Exists(outputFileName))
            {
                i++;
                outputFileName = Path.GetDirectoryName(file) + "\\" + Path.GetFileNameWithoutExtension(file) + " (" + i + ")" + ".mkv";
            }
            return outputFileName;
        }
    }
}