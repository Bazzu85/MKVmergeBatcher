using Newtonsoft.Json;
using NLog;
using System.IO;

namespace MKVmergeBatcher.src
{

    public class MainJson
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public void WriteMainJson()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (!Directory.Exists(@"configuration"))
            {
                Directory.CreateDirectory(@"configuration");
            }
            string json = JsonConvert.SerializeObject(MainForm.mainData);
            File.WriteAllText(@"configuration\main.json", json);
            Logger.Trace("Updated main.json: " + json);
        }

        public void ReadMainJson()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (File.Exists(@"configuration\main.json"))
            {
                string json = File.ReadAllText(@"configuration\main.json");
                MainForm.mainData = JsonConvert.DeserializeObject<MainData>(json);
            }
            else
            {
                WriteMainJson();
            }
            MainForm.mainData.SetDefault();
        }
    }
}
