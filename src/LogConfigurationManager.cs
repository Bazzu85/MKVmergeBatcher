using NLog;
using System;

namespace MKVmergeBatcher.src
{
    public class LogConfigurationManager
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public void ChangeLogLevel()
        {
            try
            {
                LogManager.Configuration.Variables["logLevel"] = MainForm.optionsData.selectedLogLevel;
                LogManager.ReconfigExistingLoggers();
                Logger.Info("Changed log level to " + MainForm.optionsData.selectedLogLevel);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error");
            }
        }
    }
}
