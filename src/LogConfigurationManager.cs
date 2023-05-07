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
                // Call the method to enable the unhandled exceptions logging
                // placed here so when the application register the log level, enable the exceptions loggin
                LogExceptionsManager logExceptionsManager = new LogExceptionsManager();
                logExceptionsManager.RegisterUnhandledExectionsLogging();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Error");
            }
        }
    }
}
