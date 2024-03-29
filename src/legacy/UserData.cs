﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
/// <summary>
/// Object for UserData
/// The use of BindingList<> instead of List<> is required to update automatically the datasources
/// </summary>
namespace MKVmergeBatcher.src.legacy
{
    public class UserData
    {
        public ModelCreator modelCreator = new ModelCreator();

        public class ModelCreator
        {
            public BindingList<Type> typeList = new BindingList<Type>();

            public class Type
            {
                public string type { get; set; } = "";
            }
            public BindingList<Tracks> tracks = new BindingList<Tracks>();
            //[NotifyPropertyChanged]
            public class Tracks
            {
                public string type { get; set; } = "";

                public string position { get; set; } = "0:0";
                public Boolean externalFlag { get; set; }
                public string languageCode { get; set; } = "und";
                public string languageName { get; set; } = "";
                public string extension { get; set; } = "";
                public string suffix { get; set; } = "";
                public Boolean defaultFlag { get; set; }
                public Boolean forcedFlag { get; set; }
            }

            public BindingList<Tracks> defaultTracks = new BindingList<Tracks>();


            public AdditionalFlags additionalFlags = new AdditionalFlags();
            public class AdditionalFlags
            {
                public Boolean noAttachments { get; set; }
                public Boolean cleanTitle { get; set; }
                public Boolean disableCompression { get; set; }
                public Boolean addAttachments { get; set; }
                public Boolean addChapters { get; set; }
                public Boolean noGlobalTags { get; set; }

                public Boolean autoClearOkJobs { get; set; }
                public Boolean autoClearWarningJobs { get; set; }
                public Boolean autoClearErrorJobs { get; set; }
            }

            public string preview { get; set; } = "";

            public List<int> externalFilesNumbers = new List<int>();
        }

        public Batcher batcher = new Batcher();
        public class Batcher
        {
            public string mvkMergePath { get; set; } = "";
            public string lastVideoPath { get; set; } = "";
            public string videoExtensions { get; set; } = "mkv,mp4";

            public List<string> videoExtensionList = new List<string>();

            public List<string> videoFileList = new List<string>();

            public int lastUsedModel { get; set; } = 0;


        }

        public ModelManagement modelManagement = new ModelManagement();

        public class ModelManagement
        {
            public BindingList<Model> modelList = new BindingList<Model>();

            public class Model
            {
                public string modelName { get; set; } = "";
                public string modelContent { get; set; } = "";
            }

        }


        public QueueManagement queueManagement = new QueueManagement();

        public class QueueManagement
        {
            public BindingList<Queue> queueList = new BindingList<Queue>();

            public class Queue
            {
                public string fileName { get; set; } = "";
                public int modelIndex { get; set; }
                public string modelName { get; set; } = "";
                public string jobStatus { get; set; } = "";
            }
        }

        public Options options = new Options();

        public class Options
        {
            public string moveOkFilesTo { get; set; } = "%originalFolder%";
            public string moveWarningFilesTo { get; set; } = "%originalFolder%";
            public Boolean replaceExistingDestinationFile { get; set; }
            public Boolean deleteIncompleteFile { get; set; }

            public BindingList<ExcludeFileNameContaining> excludeFileNameContainingList = new BindingList<ExcludeFileNameContaining>();

            public class ExcludeFileNameContaining
            {
                public string fileNameContaning { get; set; } = "";
            }
        }

        /// <summary>
        /// Set the default data if not already setted for UserData object 
        /// </summary>
        /// <param name="userData">The userdata object to check</param>
        /// <returns>The userdata object with additional default data if required</returns>
        public UserData SetDefaultData(UserData userData)
        {
            //If the track type list is empty, set defaults
            userData.modelCreator.typeList.Clear();
            userData.modelCreator.typeList.Add(new UserData.ModelCreator.Type { type = "Video" });
            userData.modelCreator.typeList.Add(new UserData.ModelCreator.Type { type = "Audio" });
            userData.modelCreator.typeList.Add(new UserData.ModelCreator.Type { type = "Subtitle" });
            userData.batcher.videoFileList.Clear();
            if (string.IsNullOrEmpty(userData.options.moveOkFilesTo))
            {
                userData.options.moveOkFilesTo = "%originalFolder%";
            }
            if (string.IsNullOrEmpty(userData.options.moveWarningFilesTo))
            {
                userData.options.moveWarningFilesTo = "%originalFolder%";
            }
            return userData;
        }

    }

}
