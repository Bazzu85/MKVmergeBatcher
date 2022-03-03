using System;
using System.ComponentModel;

namespace MKVmergeBatcher.src.models
{
    public class ModelsData
    {
        public BindingList<Model> modelList = new BindingList<Model>();

        public class Model
        {
            public string modelName { get; set; } = "";

            public BindingList<Track> trackList = new BindingList<Track>();

            public class Track
            {
                public string type { get; set; } = "";
                public int originalFileNumber { get; set; } = 0;
                public int originalFileTrackPosition { get; set; } = 0;
                public string language { get; set; } = "und";
                public string name { get; set; } = "";
                public Boolean DefaultFlag { get; set; }
                public Boolean ForcedFlag { get; set; }
                public string originalFileSuffix { get; set; } = "";
                public string originalFileExtension { get; set; } = "";

            }

            public CustomInputFileArguments customInputFileArguments = new CustomInputFileArguments();

            public class CustomInputFileArguments
            {
                public Boolean noAttachments { get; set; }
                public Boolean noCompression { get; set; }
                public Boolean noGlobalTags { get; set; } //--no-global-tags
                public Boolean noTrackTags { get; set; } //--no-track-tags
                public string text { get; set; } = "";

            }
            public CustomOutputFileArguments customOutputFileArguments = new CustomOutputFileArguments();

            public class CustomOutputFileArguments
            {
                public Boolean emptyTitle { get; set; }
                public Boolean addAttachments { get; set; }
                public Boolean addChapters { get; set; }
                public string text { get; set; } = "";

            }

            public Boolean customCommand { get; set; }
            public string command { get; set; } = "";

        }

        public int lastModelUsed { get; set; } = 0;
        internal void MigrateModelCommands()
        {
            foreach(Model model in MainForm.modelsData.modelList)
            {
                if (!model.customCommand)
                {
                    model.command = model.command.Replace("^\"", "\"");
                    model.command = model.command.Replace("\"^(\" ", "");
                    model.command = model.command.Replace(" \"^)\"", "");
                }
            }
        }
    }
    public class TrackSummary
    {
        public int originalFileNumber { get; set; }
        public int count { get; set; } = 0;
    }
}
