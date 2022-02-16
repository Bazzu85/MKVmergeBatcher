using NLog;

namespace MKVmergeBatcher.src.legacy
{
    public class ImportLegacyData
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public string oldUserDataJson { get; set; } = "";

        public void SetDefault()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}
