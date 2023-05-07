using NLog;
using System;

namespace MKVmergeBatcher.src
{
    public class LogExceptionsManager
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public void RegisterUnhandledExectionsLogging()
        {
            // This register the unhandled exceptions automatic handling. No need to add it to the other .cs recalled from here
            // https://stackoverflow.com/questions/13895929/nlog-configured-to-automatically-log-all-exceptions
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(AppDomain_CurrentDomain_UnhandledException);
        }
        static void AppDomain_CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // This method is used to log all unhandled
            // check https://stackoverflow.com/questions/13895929/nlog-configured-to-automatically-log-all-exceptions
            Exception ex = (Exception)e.ExceptionObject;
            Logger.Error(ex.Message + " " + ex.StackTrace);
        }
    }
}
