using Newtonsoft.Json;
using NLog;
using System.IO;

namespace MKVmergeBatcher.src.windows
{
    public class WindowsJson
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public void WriteWindowsJson()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (!Directory.Exists(@"configuration"))
            {
                Directory.CreateDirectory(@"configuration");
            }
            string json = JsonConvert.SerializeObject(MainForm.windowsData);
            File.WriteAllText(@"configuration\windows.json", json);
            Logger.Trace("Updated windows.json: " + json);
        }

        public void ReadWindowsJson()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (File.Exists(@"configuration\windows.json"))
            {
                string json = File.ReadAllText(@"configuration\windows.json");
                MainForm.windowsData = JsonConvert.DeserializeObject<WindowsData>(json);
            }
            else
            {
                WriteWindowsJson();
            }
            MainForm.windowsData.SetDefault();
        }
    }
}
