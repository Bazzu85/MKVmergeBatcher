using NLog;
using System;

namespace MKVmergeBatcher.src.windows
{
    public class WindowsData
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public Window mainWindow = new Window();
        public Window optionsWindow = new Window();
        public Window modelsWindow = new Window();
        public Window importLegacyWindow = new Window();
        public Window addEditModelWindow = new Window();
        public Window manageTrackWindow = new Window();
        public Window queueWindow = new Window();
        public Window jobWindow = new Window();
        public Window aboutWindow = new Window();
        public class Window
        {
            public int width { get; set; }
            public int height { get; set; }
            public int top { get; set; }
            public int left { get; set; }
            public Boolean maximized { get; set; }

        }
        public void SetDefault()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

    }
}
