using NLog;
using System;
using System.ComponentModel;

namespace MKVmergeBatcher.src
{
    public class MainData
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public string videoFilePath { get; set; } = "";
        public string lastBatFilePath { get; set; } = "";
        public Boolean SubfolderSearch { get; set; }
        public Boolean ApplyFileNameExclusion { get; set; }

        public BindingList<VideoFile> videoFileList = new BindingList<VideoFile>();
        public class VideoFile
        {
            public string videoFileName { get; set; } = "";
        }


        public void SetDefault()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            MainForm.mainData.videoFileList.Clear();
        }
    }

}
