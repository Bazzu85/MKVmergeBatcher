using Newtonsoft.Json;
using NLog;
using System.IO;

namespace MKVmergeBatcher.src.queue
{
    public class QueueJson
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public void WriteQueueJson()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (!Directory.Exists(@"configuration"))
            {
                Directory.CreateDirectory(@"configuration");
            }
            string json = JsonConvert.SerializeObject(MainForm.queueData);
            File.WriteAllText(@"configuration\queue.json", json);
            Logger.Trace("Updated queue.json: " + json);
        }

        public void ReadQueueJson()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (File.Exists(@"configuration\queue.json"))
            {
                string json = File.ReadAllText(@"configuration\queue.json");
                MainForm.queueData = JsonConvert.DeserializeObject<QueueData>(json);
            }
            else
            {
                WriteQueueJson();
            }
            MainForm.queueData.GenerateMissingIds();
        }
    }
}
