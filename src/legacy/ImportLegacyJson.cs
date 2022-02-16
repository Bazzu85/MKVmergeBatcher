using Newtonsoft.Json;
using NLog;
using System.IO;

namespace MKVmergeBatcher.src.legacy
{
    public class ImportLegacyJson
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public void WriteImportLegacyJson()
        {
            if (!Directory.Exists(@"configuration"))
            {
                Directory.CreateDirectory(@"configuration");
            }
            string json = JsonConvert.SerializeObject(ImportLegacyForm.importLegacyData);
            File.WriteAllText(@"configuration\importLegacy.json", json);
            Logger.Trace("Updated importLegacy.json: " + json);
        }

        public void ReadImportLegacyJson()
        {
            if (File.Exists(@"configuration\importLegacy.json"))
            {
                string json = File.ReadAllText(@"configuration\importLegacy.json");
                ImportLegacyForm.importLegacyData = JsonConvert.DeserializeObject<ImportLegacyData>(json);
            }
            else
            {
                WriteImportLegacyJson();
            }
            ImportLegacyForm.importLegacyData.SetDefault();
        }

    }
}
