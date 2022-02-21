using NLog;
using System;
using System.Collections.Generic;

namespace MKVmergeBatcher.src.models
{
    public class ModelGenerator
    {
        public static readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public string errorList = "";
        public ModelsData.Model model;

        public bool CheckModel(ManageModelForm manageModelForm)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            ModelsData.Model model = manageModelForm.GetModel();
            Boolean result = true;
            errorList = "";
            int errorIndex = 0;
            //model name must be specified
            if (String.IsNullOrEmpty(model.modelName))
            {
                errorIndex += 1;
                AddError(Properties.Resources.ErrorLabel + " n." + errorIndex + ": " + Properties.Resources.DigitModelName);
                result = false;
            }
            for (int i = 0; i < MainForm.modelsData.modelList.Count; i++)
            {
                // if the model where are checking is already in model list
                if (MainForm.modelsData.modelList[i].modelName == model.modelName)
                {
                    // if found but where are editing the same model, is ok
                    if (manageModelForm.callType == ManageModelForm.CallType.Edit && i == manageModelForm.currentModelIndex)
                    {

                    }
                    else
                    {
                        errorIndex += 1;
                        AddError(Properties.Resources.ErrorLabel + " n." + errorIndex + ": " + Properties.Resources.UseDifferentModelName + " (" + model.modelName + ")");
                        result = false;
                    }
                }
            }
            if (!model.customCommand)
            {
                // at least a track need to be inserted
                if (model.trackList.Count == 0)
                {
                    errorIndex += 1;
                    AddError(Properties.Resources.ErrorLabel + " n." + errorIndex + ": " + Properties.Resources.AddTrackOrUseCustomModel);

                    result = false;
                }
                Boolean track0 = false;
                for (int i = 0; i < model.trackList.Count; i++)
                {
                    if (model.trackList[i].originalFileNumber == 0)
                    {
                        track0 = true;
                    }
                }
                // at least a track from file 0 need to be in track list
                if (!track0)
                {
                    errorIndex += 1;
                    AddError(Properties.Resources.ErrorLabel + " n." + errorIndex + ": " + Properties.Resources.AddTrackFromFileNumber0);
                    result = false;
                }
                if (model.customInputFileArguments.noAttachments && model.customOutputFileArguments.addAttachments)
                {
                    errorIndex += 1;
                    AddError(Properties.Resources.ErrorLabel + " n." + errorIndex + ": " + Properties.Resources.UseOneAttachmentFlag);

                    result = false;
                }
            }
            return result;
        }
        public bool CheckTrack(ManageTrackForm manageTrackForm)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            ModelsData.Model.Track track = manageTrackForm.track;
            ManageTrackForm.CallType callType = manageTrackForm.callType;
            int currentTrackIndex = manageTrackForm.currentTrackIndex;
            Boolean result = true;
            errorList = "";
            int errorIndex = 0;
            #region type
            if (String.IsNullOrEmpty(track.type))
            {
                errorIndex += 1;
                AddError(Properties.Resources.ErrorLabel + " n." + errorIndex + ": " + Properties.Resources.SelectTrackType);
                result = false;
            }
            #endregion
            #region original file number and position

            // the checks for the maximum file number available to insert/edit is removed. when generating the model, all originalFileNumber are fixed filling the holes

            for (int i = 0; i < ManageModelForm.model.trackList.Count; i++)
            {
                // if originalFileNumber and position already in tracklist, error
                if (track.originalFileNumber == ManageModelForm.model.trackList[i].originalFileNumber
                && track.originalFileTrackPosition == ManageModelForm.model.trackList[i].originalFileTrackPosition
                && i != currentTrackIndex)
                {
                    errorIndex += 1;
                    AddError(Properties.Resources.ErrorLabel + " n." + errorIndex + ": " + Properties.Resources.OriginalFileNumberPositionAlreadyInTrackList);

                    result = false;
                    break;
                }
            }
            // if originalFileNumber is > 0 (external) we need at least suffix or extension
            if (track.originalFileNumber > 0)
            {
                if (String.IsNullOrEmpty(track.originalFileSuffix) && String.IsNullOrEmpty(track.originalFileExtension))
                {
                    errorIndex += 1;
                    AddError(Properties.Resources.ErrorLabel + " n." + errorIndex + ": " + Properties.Resources.SpecifySuffixOrExtension);

                    result = false;
                }
            }
            #endregion
            #region language
            if (String.IsNullOrEmpty(track.language))
            {
                errorIndex += 1;
                AddError(Properties.Resources.ErrorLabel + " n." + errorIndex + ": " + Properties.Resources.InsertLanguageCode);

                result = false;
            }
            #endregion
            #region originalFileSuffix
            if (!String.IsNullOrEmpty(track.originalFileSuffix) && track.originalFileNumber == 0)
            {
                errorIndex += 1;
                AddError(Properties.Resources.ErrorLabel + " n." + errorIndex + ": " + Properties.Resources.SuffixNotRequired);
                result = false;
            }
            #endregion
            #region originalFileExtension
            if (!String.IsNullOrEmpty(track.originalFileExtension) && track.originalFileNumber == 0)
            {
                errorIndex += 1;
                AddError(Properties.Resources.ErrorLabel + " n." + errorIndex + ": " + Properties.Resources.ExtensionNotRequired);
                result = false;
            }
            #endregion
            return result;
        }
        private void AddError(string message)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            if (String.IsNullOrEmpty(errorList))
            {
                errorList += message;
            }
            else
            {
                errorList += "\n" + message;
            }
        }
        public string GenerateModel(ManageModelForm manageModelForm)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            model = manageModelForm.GetModel();

            string command = "";

            // mkvmerge Path
            command += "\"||mkvmergePath||\" ";

            // --output
            command += "--output ^\"||outputFileFullPath||^\" ";

            // work on track0 tracks
            command += GenerateTrackString(0);

            // work on other tracks
            bool done = false;
            int fileNumber = 0;
            while (!done)
            {
                fileNumber++;
                bool found = false;
                foreach (ModelsData.Model.Track track in model.trackList)
                {
                    if (track.originalFileNumber == fileNumber)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    command += GenerateTrackString(fileNumber);
                }
                else
                {
                    done = true;
                }
            }

            // --title
            if (model.customOutputFileArguments.emptyTitle)
            {
                command += "--title ^\"^\"" + " ";
            }

            // Add attachments
            if (model.customOutputFileArguments.addAttachments)
            {
                command += "||attachments|| ";
            }

            // Add chapters
            if (model.customOutputFileArguments.addChapters)
            {
                command += "||chapters|| ";
            }

            // add user defined custom output arguments
            if (!string.IsNullOrEmpty(model.customOutputFileArguments.text))
            {
                command += model.customOutputFileArguments.text + " ";
            }

            // --track-order
            command += "--track-order ";
            int i = 0;
            foreach (ModelsData.Model.Track track in model.trackList)
            {
                if (i == 0)
                {
                    command += track.originalFileNumber.ToString() + ':' + track.originalFileTrackPosition.ToString();
                }
                else
                {
                    command += "," + track.originalFileNumber.ToString() + ':' + track.originalFileTrackPosition.ToString();
                }
                i++;
            }
            return command;

        }

        private string GenerateTrackString(int fileNumber)
        {
            Logger.Trace(System.Reflection.MethodBase.GetCurrentMethod().Name);

            string videoTracks = "--video-tracks ";
            Boolean videoTracksFound = false;
            string audioTracks = "--audio-tracks ";
            Boolean audioTracksFound = false;
            string subtitleTracks = "--subtitle-tracks ";
            Boolean subtitleTracksFound = false;
            string suffix = "";
            string extension = "";
            string completeTrackString = "";
            List<string> tracksStringList = new List<string>();

            //scroble all tracks with the passed file number
            foreach (ModelsData.Model.Track track in model.trackList)
            {
                string singleTrackString = "";
                if (track.originalFileNumber == fileNumber)
                {
                    if (fileNumber != 0)
                    {
                        suffix = track.originalFileSuffix;
                        extension = track.originalFileExtension;
                    }
                    if (track.type == Properties.Resources.Video)
                    {
                        if (!videoTracksFound)  //if first video track insert without ","
                        {
                            videoTracks += track.originalFileTrackPosition;
                        }
                        else
                        {
                            videoTracks += "," + track.originalFileTrackPosition;
                        }
                        videoTracksFound = true;
                    }
                    if (track.type == Properties.Resources.Audio)
                    {
                        if (!audioTracksFound)  //if first audio track insert without ","
                        {
                            audioTracks += track.originalFileTrackPosition;
                        }
                        else
                        {
                            audioTracks += "," + track.originalFileTrackPosition;
                        }
                        audioTracksFound = true;
                    }
                    if (track.type == Properties.Resources.Subtitle)
                    {
                        if (!subtitleTracksFound)  //if first subtitle track insert without ","
                        {
                            subtitleTracks += track.originalFileTrackPosition;
                        }
                        else
                        {
                            subtitleTracks += "," + track.originalFileTrackPosition;
                        }
                        subtitleTracksFound = true;
                    }

                    singleTrackString += "--language ^\"" + track.originalFileTrackPosition + ":" + track.language + "^\" ";
                    singleTrackString += "--track-name ^\"" + track.originalFileTrackPosition + ":" + track.name + "^\" ";
                    singleTrackString += "--default-track ^\"" + track.originalFileTrackPosition + ":";
                    if (track.DefaultFlag)
                    {
                        singleTrackString += "yes" + "^\" ";
                    }
                    else
                    {
                        singleTrackString += "no" + "^\" ";
                    }
                    singleTrackString += "--forced-track ^\"" + track.originalFileTrackPosition + ":";
                    if (track.ForcedFlag)
                    {
                        singleTrackString += "yes" + "^\" ";
                    }
                    else
                    {
                        singleTrackString += "no" + "^\" ";
                    }
                    if (model.customInputFileArguments.noCompression)
                    {
                        singleTrackString += "--compression ^\"" + track.originalFileTrackPosition + ":none" + "^\" ";
                    }
                    tracksStringList.Add(singleTrackString);
                }
            }
            // --no-attachments
            if (model.customInputFileArguments.noAttachments)
            {
                completeTrackString += "--no-attachments ";
            }

            // --no-global-tags
            if (model.customInputFileArguments.noGlobalTags)
            {
                completeTrackString += "--no-global-tags ";
            }

            // --no-track-tags
            if (model.customInputFileArguments.noTrackTags)
            {
                completeTrackString += "--no-track-tags ";
            }

            // insert --video-tracks or --no-video
            if (videoTracksFound)
            {
                completeTrackString += videoTracks + " ";
            }
            else
            {
                completeTrackString += "--no-video ";
            }
            // insert --audio-tracks or --no-audio
            if (audioTracksFound)
            {
                completeTrackString += audioTracks + " ";
            }
            else
            {
                completeTrackString += "--no-audio ";
            }

            // insert --subtitle-tracks or --no-subtitles
            if (subtitleTracksFound)
            {
                completeTrackString += subtitleTracks + " ";
            }
            else
            {
                completeTrackString += "--no-subtitles ";
            }

            // add user defined custom arguments
            if (!string.IsNullOrEmpty(model.customInputFileArguments.text))
            {
                completeTrackString += model.customInputFileArguments.text + " ";
            }

            //copy all track data strings to preview
            foreach (string trackString in tracksStringList)
            {
                completeTrackString += trackString;
            }
            //for track 0 set the user choosen file name
            //for external tracks use the file name without extension and append the choosen suffix/extension/both
            if (fileNumber == 0)
            {
                completeTrackString += "^\"^(^\" ^\"||inputFileFolder||\\||inputFileName||^\" ^\"^)^\"" + " ";
            }
            else
            {
                completeTrackString += "^\"^(^\" ^\"||inputFileFolder||\\||inputFileNameWithoutExtension||";
                if (!string.IsNullOrEmpty(suffix))
                {
                    completeTrackString += suffix;
                }
                if (!string.IsNullOrEmpty(extension))
                {
                    if (extension.StartsWith("."))
                    {
                        completeTrackString += extension;
                    }
                    else
                    {
                        completeTrackString += "." + extension;
                    }
                }
                completeTrackString += "^\" ^\"^)^\"" + " ";
            }
            return completeTrackString;
        }
    }
}
