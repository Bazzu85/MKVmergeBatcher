using Newtonsoft.Json;
using NLog;
using System.IO;

namespace MKVmergeBatcher.src.legacy
{
    public class UserDataJson
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public bool ReadUserDataJson(string userDataPath)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            if (File.Exists(userDataPath))
            {
                string json = File.ReadAllText(userDataPath);
                ImportLegacyForm.userData = JsonConvert.DeserializeObject<UserData>(json);
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
