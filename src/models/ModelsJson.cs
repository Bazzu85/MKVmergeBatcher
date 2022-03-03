using Newtonsoft.Json;
using NLog;
using System.IO;

namespace MKVmergeBatcher.src.models
{
    public class ModelsJson
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public void WriteModelsJson()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (!Directory.Exists(@"configuration"))
            {
                Directory.CreateDirectory(@"configuration");
            }
            string json = JsonConvert.SerializeObject(MainForm.modelsData);
            File.WriteAllText(@"configuration\models.json", json);
            Logger.Trace("Updated models.json: " + json);
        }

        public void ReadModelsJson()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (File.Exists(@"configuration\models.json"))
            {
                string json = File.ReadAllText(@"configuration\models.json");
                MainForm.modelsData = JsonConvert.DeserializeObject<ModelsData>(json);
            }
            else
            {
                WriteModelsJson();
            }
            MainForm.modelsData.MigrateModelCommands();
        }

    }
}
