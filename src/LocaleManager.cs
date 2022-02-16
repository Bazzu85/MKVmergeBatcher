using MKVmergeBatcher.src.models;
using MKVmergeBatcher.src.queue;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace MKVmergeBatcher.src
{
    public class LocaleManager
    {
        public string oldVideoTrackType = "";
        public string oldAudioTrackType = "";
        public string oldSubtitleTrackType = "";
        public string oldPendingJobStatus = "";
        public string oldRunningJobStatus = "";
        public string oldOkJobStatus = "";
        public string oldWarningJobStatus = "";
        public string oldErrorJobStatus = "";
        // Method that receive a form and recursivelly update the controls locale
        internal void SetLocale(Form form)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(MainForm.optionsData.selectedLocale);

            ComponentResourceManager resources = new ComponentResourceManager(form.GetType());
            resources.ApplyResources(form, "$this");
            applyResources(resources, form.Controls);
        }
        private void applyResources(ComponentResourceManager resources, Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                //Console.WriteLine("c.Name: " + c.Name);

                resources.ApplyResources(c, c.Name);
                if (c.Controls.Count > 0)
                {
                    applyResources(resources, c.Controls);
                }
                //Console.WriteLine("c.Text: " + c.Text);
            }
        }

        internal void UpdateNewLocaleLabels()
        {
            //Update models according to locale
            foreach (ModelsData.Model model in MainForm.modelsData.modelList)
            {
                foreach (ModelsData.Model.Track track in model.trackList)
                {
                    if (track.type == oldVideoTrackType)
                    {
                        track.type = Properties.Resources.Video;
                    }
                    if (track.type == oldAudioTrackType)
                    {
                        track.type = Properties.Resources.Audio;
                    }
                    if (track.type == oldSubtitleTrackType)
                    {
                        track.type = Properties.Resources.Subtitle;
                    }
                }
            }

            //Update jobs status according to locale
            foreach (QueueData.Job job in MainForm.queueData.jobList)
            {
                if (job.jobStatus == oldPendingJobStatus)
                {
                    job.jobStatus = Properties.Resources.PendingJobLabel;
                }
                if (job.jobStatus == oldRunningJobStatus)
                {
                    job.jobStatus = Properties.Resources.RunningJobLabel;
                }
                if (job.jobStatus == oldOkJobStatus)
                {
                    job.jobStatus = Properties.Resources.OkJobLabel;
                }
                if (job.jobStatus == oldWarningJobStatus)
                {
                    job.jobStatus = Properties.Resources.WarningJobLabel;
                }
                if (job.jobStatus == oldErrorJobStatus)
                {
                    job.jobStatus = Properties.Resources.ErrorJobLabel;
                }


            }
        }

        internal void SaveOldLocaleLabels()
        {
            // track types
            oldVideoTrackType = Properties.Resources.Video;
            oldAudioTrackType = Properties.Resources.Audio;
            oldSubtitleTrackType = Properties.Resources.Subtitle;

            // job status
            oldPendingJobStatus = Properties.Resources.PendingJobLabel;
            oldRunningJobStatus = Properties.Resources.RunningJobLabel;
            oldOkJobStatus = Properties.Resources.OkJobLabel;
            oldWarningJobStatus = Properties.Resources.WarningJobLabel;
            oldErrorJobStatus = Properties.Resources.ErrorJobLabel;

        }
    }
}
