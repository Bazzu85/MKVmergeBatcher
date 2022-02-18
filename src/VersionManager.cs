using MKVmergeBatcher.src.models;
using MKVmergeBatcher.src.queue;
using NLog;
using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKVmergeBatcher.src
{
    public class VersionManager
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public string error = "";
        internal async Task<bool> CheckForUpdateAsync()
        {
            bool newVersionFound = false;

            Version latestGitHubVersion;
            // open the github connection and grab the latest version
            try
            {
                GitHubClient githubClient = new GitHubClient(new ProductHeaderValue("MKVmergeBatcher"));
                IReadOnlyList<Release> releases = await githubClient.Repository.Release.GetAll("Bazzu85", "MKVmergeBatcher");
                latestGitHubVersion = new Version(releases[0].TagName);
            }
            catch (RateLimitExceededException e)
            {
                Logger.Info(e);
                return false;
            }


            //update the last version found
            MainForm.optionsData.lastVersionFound = latestGitHubVersion.ToString();

            Version localVersion = GenerateLocalVersionForGithub();

            // compare the versions
            int versionComparison = localVersion.CompareTo(latestGitHubVersion);
            if (versionComparison < 0)
            {
                //The version on GitHub is more up to date than this local release.
                newVersionFound = true;
            }
            else if (versionComparison > 0)
            {
                //This local version is greater than the release version on GitHub.
                newVersionFound = false;
            }
            else
            {
                //This local Version and the Version on GitHub are equal.
                newVersionFound = false;
            }
            return newVersionFound;
        }

        public string GetError()
        {
            return error;
        }
        public Version GenerateLocalVersionForGithub()
        {
            Version fullVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            Version localVersion = new Version(fullVersion.Major.ToString() + "." + fullVersion.Minor.ToString() + "." + fullVersion.Build.ToString());

            //only for test purpose
            //localVersion = new Version("1.0.0");

            return localVersion;
        }

    }
}
