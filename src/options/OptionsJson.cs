using Newtonsoft.Json;
using NLog;
using System.IO;

namespace MKVmergeBatcher.src.options
{
    public class OptionsJson
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public void WriteOptionsJson()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (!Directory.Exists(@"configuration"))
            {
                Directory.CreateDirectory(@"configuration");
            }
            string json = JsonConvert.SerializeObject(MainForm.optionsData);
            File.WriteAllText(@"configuration\options.json", json);
            Logger.Trace("Updated options.json: " + json);
        }

        public void ReadOptionsJson()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (File.Exists(@"configuration\options.json"))
            {
                string json = File.ReadAllText(@"configuration\options.json");
                MainForm.optionsData = JsonConvert.DeserializeObject<OptionsData>(json);
            }
            else
            {
                WriteOptionsJson();
            }
            MainForm.logConfigurationManager.ChangeLogLevel();
            MainForm.optionsData.SetDefault();
        }
    }
}
