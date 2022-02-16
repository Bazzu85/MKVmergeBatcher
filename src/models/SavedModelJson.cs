using Newtonsoft.Json;
using NLog;
using System.IO;

namespace MKVmergeBatcher.src.models
{
    public class SavedModelJson
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private ModelsData.Model model = new ModelsData.Model();
        public void WriteSavedModelJson(ModelsData.Model model)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (!Directory.Exists(@"configuration"))
            {
                Directory.CreateDirectory(@"configuration");
            }
            string json = JsonConvert.SerializeObject(model);
            File.WriteAllText(@"configuration\savedModel.json", json);
            Logger.Trace("Updated savedModel.json: " + json);
        }

        public ModelsData.Model ReadSavedModelJson()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (File.Exists(@"configuration\models.json"))
            {
                string json = File.ReadAllText(@"configuration\savedModel.json");
                model = JsonConvert.DeserializeObject<ModelsData.Model>(json);
            }
            else
            {
                WriteSavedModelJson(model);
            }
            return model;
        }

    }
}
