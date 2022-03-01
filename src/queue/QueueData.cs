using System;
using System.ComponentModel;

namespace MKVmergeBatcher.src.queue
{
    public class QueueData
    {

        public BindingList<Job> jobList = new BindingList<Job>();

        public class Job
        {
            public int id { get; set; } = 0;
            public string fileName { get; set; } = "";
            public string fileNameWithoutExtension { get; set; } = "";
            public string fileFolder { get; set; } = "";
            public string fileFullPath { get; set; } = "";
            public int percentage { get; set; } = 0;
            // Values: Pending - Running - Ok - Warning - Error
            public string jobStatus { get; set; } = "";
            public bool jobExecuted { get; set; } = false;
            public string command { get; set; } = "";
            public string outputFileName { get; set; } = "";
            public string output { get; set; } = "";
        }
        public bool running { get; set; } = false;
        public bool processEnded { get; set; } = false;
        public int currentRunningJob { get; set; } = 0;
        public int currentRunningJobIndex { get; set; } = 0;
        public int totalJobsToExec { get; set; } = 0;
        public string workingOkString { get; set; } = "";
        public int warnings { get; set; } = 0;
        public int errors { get; set; } = 0;

        public void GenerateMissingIds()
        {
            Random random = new Random();
            
            foreach (Job job in MainForm.queueData.jobList)
            {
                if (job.id <= 0)
                {
                    int id = random.Next(1, int.MaxValue);
                    bool idOk = CheckId(id);
                    if (idOk)
                    {
                        job.id = id;
                    }
                }
            }
        }

        public bool CheckId(int id)
        {
            for (int i=0; i < jobList.Count; i++)
            {
                if (MainForm.queueData.jobList[i].id == id)
                {
                    return false;
                }
            }
            return true;
        }
        public int GenerateNewUniqueId()
        {
            Random random = new Random();
            int id = 0;
            bool done = false;
            while (!done)
            {
                id = random.Next(1, int.MaxValue);
                bool idOk = CheckId(id);
                if (idOk)
                {
                    done = true;
                }
            }
            return id;
        }
    }
}
