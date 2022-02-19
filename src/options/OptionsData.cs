using NLog;
using System;
using System.ComponentModel;
using System.Linq;

namespace MKVmergeBatcher.src.options
{
    public class OptionsData
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        #region General options
        public string mkvMergeLocation { get; set; } = "";

        public BindingList<LogLevel> logLevelList = new BindingList<LogLevel>();

        public class LogLevel
        {
            public string logLevel { get; set; } = "";
        }

        public int selectedLogLevelIndex { get; set; } = 0;
        public string selectedLogLevel { get; set; } = "Info";

        public BindingList<Locale> localeList = new BindingList<Locale>();

        public class Locale
        {
            public string localeName { get; set; } = "";
            public string localeCode { get; set; } = "";
        }

        public int selectedLocaleIndex { get; set; } = 0;
        public string selectedLocale { get; set; } = "en-US";

        public BindingList<Extension> extensionList = new BindingList<Extension>();

        public class Extension
        {
            public string extension { get; set; } = "";
        }
        public BindingList<ExcludeFileNameContaining> excludeFileNameContainingList = new BindingList<ExcludeFileNameContaining>();

        public class ExcludeFileNameContaining
        {
            public string excludeFileNameContaining { get; set; } = "";
        }
        public Boolean allowMultipleInstaces { get; set; }

        #endregion
        #region Queue options
        public string moveOkFilesTo { get; set; } = "||originalFolder||";
        public string moveWarningFilesTo { get; set; } = "||originalFolder||";
        public Boolean replaceExistingDestinationFiles { get; set; }
        public Boolean deleteIncompleteFiles { get; set; }
        public Boolean autoClearOkJobs { get; set; }
        public Boolean autoClearWarningJobs { get; set; }
        public Boolean autoClearErrorJobs { get; set; }
        #endregion

        #region Version options
        public Boolean checkUpdates { get; set; } = true;
        public string lastVersionFound { get; set; }
        #endregion

        public void SetDefault()
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            MainForm.optionsData.logLevelList.Clear();
            MainForm.optionsData.logLevelList.Add(new LogLevel() { logLevel = "Info" });
            MainForm.optionsData.logLevelList.Add(new LogLevel() { logLevel = "Debug" });
            MainForm.optionsData.logLevelList.Add(new LogLevel() { logLevel = "Trace" });

            MainForm.optionsData.localeList.Clear();
            MainForm.optionsData.localeList.Add(new Locale()
            {
                localeName = Properties.Resources.EnglishLanguageName,
                localeCode = "en-US"
            }); ;
            MainForm.optionsData.localeList.Add(new Locale()
            {
                localeName = Properties.Resources.ItalianLanguageName,
                localeCode = "it-IT"
            }); ;
            MainForm.optionsData.localeList.Add(new Locale()
            {
                localeName = Properties.Resources.SpanishLanguageName,
                localeCode = "es-ES"
            }); ;

            if (MainForm.optionsData.extensionList.Count() == 0)
            {
                MainForm.optionsData.extensionList.Add(new Extension() { extension = "mkv" });
                MainForm.optionsData.extensionList.Add(new Extension() { extension = "mp4" });
            }

            MainForm.optionsData.moveOkFilesTo = MainForm.optionsData.moveOkFilesTo.Replace("%originalFolder%", "||originalFolder||");
            MainForm.optionsData.moveWarningFilesTo = MainForm.optionsData.moveWarningFilesTo.Replace("%originalFolder%", "||originalFolder||");

            if (MainForm.optionsData.selectedLocaleIndex >= 0)
            {
                string previouslySelectedLocale = MainForm.optionsData.selectedLocale;
                for (int i = 0; i < MainForm.optionsData.localeList.Count - 1; i++)
                {
                    if (String.Compare(MainForm.optionsData.localeList[i].localeName, MainForm.optionsData.localeList[i + 1].localeName, true) > 0)
                    {
                        MoveLocale(i, i + 1);
                        i = -1;
                    }
                }
                int newSelectedIndex = 0;

                for (int i = 0; i < MainForm.optionsData.localeList.Count(); i++)
                {
                    if (MainForm.optionsData.localeList[i].localeCode == previouslySelectedLocale)
                    {
                        newSelectedIndex = i;
                    }
                }
                MainForm.optionsData.selectedLocaleIndex = newSelectedIndex;
            }
        }
        private void MoveLocale(int source, int destination)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);
            while (source != destination)
            {
                if (destination > source)
                {
                    var tmp = MainForm.optionsData.localeList[source + 1];
                    MainForm.optionsData.localeList[source + 1] = MainForm.optionsData.localeList[source];
                    MainForm.optionsData.localeList[source] = tmp;
                    source += 1;
                }
                else
                {
                    var tmp = MainForm.optionsData.localeList[source - 1];
                    MainForm.optionsData.localeList[source - 1] = MainForm.optionsData.localeList[source];
                    MainForm.optionsData.localeList[source] = tmp;
                    source -= 1;
                }
            }
        }
    }
}
