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

        internal void CreateBat(List<string> videoFileList, string batFileName, int selectedModelIndex)
        {
            List<string> batLinesList = new List<string>();

            foreach (string videoFile in videoFileList)
            {
                string cmdLine = CreateCmd(videoFile, selectedModelIndex);
                cmdLine += ">> " + Path.GetFileNameWithoutExtension(batFileName) + ".log";
                batLinesList.Add(cmdLine);
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
            string outputFileName = Path.GetDirectoryName(videoFile) + "\\" + Path.GetFileNameWithoutExtension(videoFile) + ".mkv";
            int i = 0;
            while (File.Exists(outputFileName))
            {
                i++;
                outputFileName = Path.GetDirectoryName(videoFile) + "\\" + Path.GetFileNameWithoutExtension(videoFile) + " (" + i + ")" + ".mkv";
            }
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
            return cmdLine;
        }
    }
}