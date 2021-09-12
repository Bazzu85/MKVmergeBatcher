using MKVmergeBatcher.src.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MKVmergeBatcher.src
{
    public class ModelCreatorManagement
    {
        public UserData userData = new UserData();

        List<UserData.ModelCreator.Tracks> trackList = new List<UserData.ModelCreator.Tracks>();

        private static Regex regex = new Regex(@"^\d+$");

        public ModelCreatorManagement(UserData userData)
        {
            this.userData = userData;
        }

        /// <summary>
        /// Check Model Creator list content
        /// </summary>
        public string CheckLists()
        {
            string errorString = "";
            Boolean track0Found = false;
            List<string> errorList = new List<string>();
            List<UserData.ModelCreator.Tracks> trackList = userData.modelCreator.tracks.ToList();
            userData.modelCreator.externalFilesNumbers.Clear();
            //Check track list
            int i = 0;
            foreach (UserData.ModelCreator.Tracks item in trackList)
            {
                i++;
                #region Type
                //must be populated
                if (String.IsNullOrEmpty(item.type))
                {
                    errorList.Add("Row " + i + " >> Type >> " + "Empty");
                }
                #endregion
                #region Position
                //Must be populated, 
                if (String.IsNullOrEmpty(item.position))
                {
                    errorList.Add("Row " + i + " >> Position >> " + "Empty");
                }
                //in correct format
                string[] positionElements = item.position.Split(':');
                if (positionElements.Length != 2)
                {
                    errorList.Add("Row " + i + " >> Position >> " + "Not in F:P format");
                    //break positioned here beacause if continuing the evaluation on positionElements with a length < 2, cause expection in next ifs
                    break;
                }
                if (positionElements[0] == "0" && item.externalFlag)
                {
                    errorList.Add("Row " + i + " >> Position >> " + item.position + " cannot be external");
                }
                if (positionElements[0] != "0" && !item.externalFlag)
                {
                    errorList.Add("Row " + i + " >> Position >> " + item.position + " must be external");
                }
                //each side must be numeric
                if (!regex.IsMatch(positionElements[0])) //if not numeric
                {
                    errorList.Add("Row " + i + " >> Position >> " + "First part not numeric");
                }
                if (!regex.IsMatch(positionElements[1])) //if not numeric
                {
                    errorList.Add("Row " + i + " >> Position >> " + "Second part not numeric");
                }
                //if track0 or external, remember it
                if (regex.IsMatch(positionElements[0])) //if numeric
                {
                    if (positionElements[0] == "0")
                    {
                        track0Found = true;
                    }
                    else
                    {
                        //search if external track number is yet in external tracks list
                        Boolean found = false;
                        foreach (int number in userData.modelCreator.externalFilesNumbers)
                        {
                            if (number == int.Parse(positionElements[0]))
                            {
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            userData.modelCreator.externalFilesNumbers.Add(int.Parse(positionElements[0]));
                        }
                        //check if the external track has a congruent suffix/extension
                        string savedExtension = item.extension;
                        string savedSuffix = item.suffix;
                        foreach (UserData.ModelCreator.Tracks tmpItem in trackList)
                        {
                            string[] tmpPositionElements = tmpItem.position.Split(':');

                            if (tmpPositionElements[0] == positionElements[0] && tmpItem.extension != savedExtension && !String.IsNullOrEmpty(savedExtension))
                            {
                                errorList.Add("Row " + i + " >> Extension >> " + "File number " + tmpPositionElements[0] + " has incogruent extensions");
                            }
                            if (tmpPositionElements[0] == positionElements[0] && tmpItem.suffix != savedSuffix && !String.IsNullOrEmpty(savedSuffix))
                            {
                                errorList.Add("Row " + i + " >> Suffix >> " + "File number " + tmpPositionElements[0] + " has incogruent suffixes");
                            }
                        }

                    }
                }
                //not duplicated
                int x = 0;
                foreach (UserData.ModelCreator.Tracks tmpItem in trackList)
                {
                    x++;
                    if (x == i)
                    {
                        break;
                    }
                    if (tmpItem.position == item.position)
                    {
                        errorList.Add("Row " + i + " >> Position >> " + "Duplicated");
                    }
                }
                #endregion
                #region Language Code
                //Must be populated, 
                if (String.IsNullOrEmpty(item.languageCode))
                {
                    errorList.Add("Row " + i + " >> Language Code >> " + "Empty");
                }
                #endregion
                #region Extension
                if (item.externalFlag && String.IsNullOrEmpty(item.extension))
                {
                    errorList.Add("Row " + i + " >> Extension >> " + "Empty");
                }
                if (!item.externalFlag && !String.IsNullOrEmpty(item.extension))
                {
                    errorList.Add("Row " + i + " >> Extension >> " + "Extension must be empty");
                }
                #endregion
                #region Suffix
                if (!item.externalFlag && !String.IsNullOrEmpty(item.suffix))
                {
                    errorList.Add("Row " + i + " >> Suffix >> " + "Suffix must be empty");
                }
                #endregion
            }
            #region Track0 not found error
            if (!track0Found)
            {
                errorList.Add("Position >> " + "No tracks found for base file (0:*)");
            }
            #endregion
            #region External tracks numeric order
            userData.modelCreator.externalFilesNumbers.Sort();
            i = 0;
            foreach (int item in userData.modelCreator.externalFilesNumbers)
            {
                i++;
                if (item != i)
                {
                    errorList.Add("Position >> " + "Missing external file number " + i);
                    break;
                }
            }
            #endregion
            #region --no-attachments and add attachments
            if (userData.modelCreator.additionalFlags.noAttachments && userData.modelCreator.additionalFlags.addAttachments)
            {
                errorList.Add("Use only one flag between --no-attachments and Add Attachments");
            }
            #endregion


            //Transfer errorList to single string
            foreach (string item in errorList)
            {
                if (String.IsNullOrEmpty(errorString))
                {
                    errorString += item;
                }
                else
                {
                    errorString += "\n" + item;
                }
            }
            return errorString;
        }

        /// <summary>
        /// Generate the preview
        /// </summary>
        public void GeneratePreview()
        {
            string preview = "";
            trackList = userData.modelCreator.tracks.ToList();

            #region mkvmerge Path
            preview += "\"||mkvmergePath||\" ";
            #endregion
            #region --output
            preview += "--output ^\"||outputFileName||^\" ";
            #endregion
            #region--no-attachments
            //Adding noAttachments Flag
            if (userData.modelCreator.additionalFlags.noAttachments)
            {
                preview += "--no-attachments ";
            }
            #endregion

            #region track0 Data
            preview += GenerateTrackString(0);
            #endregion
            #region externalTracksData
            foreach (int fileNumber in userData.modelCreator.externalFilesNumbers)
            {
                preview += GenerateTrackString(fileNumber);
            }
            #endregion
            #region --title
            if (userData.modelCreator.additionalFlags.cleanTitle)
            {
                preview += "--title ^\"^\"" + " ";
            }
            #endregion
            #region Add attachments
            if (userData.modelCreator.additionalFlags.addAttachments)
            {
                preview += "||attachments|| ";
            }
            #endregion
            #region Add chapters
            if (userData.modelCreator.additionalFlags.addChapters)
            {
                preview += "||chapters|| ";
            }
            #endregion
            #region --track-order
            preview += "--track-order ";
            int i = 0;
            foreach (UserData.ModelCreator.Tracks track in trackList)
            {
                if (i == 0)
                {
                    preview += track.position;
                }
                else
                {
                    preview += "," + track.position;
                }
                i++;
            }
            #endregion
            this.userData.modelCreator.preview = preview;
        }

        private string GenerateTrackString(int trackNumber)
        {
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
            //scroble all track 0 tracks
            foreach (UserData.ModelCreator.Tracks track in trackList)
            {
                string[] positionElements = track.position.Split(':');
                string singleTrackString = "";
                if (positionElements[0] == trackNumber.ToString())
                {
                    if (trackNumber != 0)
                    {
                        suffix = track.suffix;
                        extension = track.extension;
                    }
                    switch (track.type)
                    {
                        case "Video":
                            if (!videoTracksFound)  //if first video track insert without ","
                            {
                                videoTracks += positionElements[1];
                            }
                            else
                            {
                                videoTracks += "," + positionElements[1];
                            }
                            videoTracksFound = true;
                            break;
                        case "Audio":
                            if (!audioTracksFound)  //if first audio track insert without ","
                            {
                                audioTracks += positionElements[1];
                            }
                            else
                            {
                                audioTracks += "," + positionElements[1];
                            }
                            audioTracksFound = true;
                            break;
                        case "Subtitle":
                            if (!subtitleTracksFound)  //if first subtitle track insert without ","
                            {
                                subtitleTracks += positionElements[1];
                            }
                            else
                            {
                                subtitleTracks += "," + positionElements[1];
                            }
                            subtitleTracksFound = true;
                            break;
                    }
                    singleTrackString += "--language ^\"" + positionElements[1] + ":" + track.languageCode + "^\" ";
                    singleTrackString += "--track-name ^\"" + positionElements[1] + ":" + track.languageName + "^\" ";
                    singleTrackString += "--default-track ^\"" + positionElements[1] + ":";
                    if (track.defaultFlag)
                    {
                        singleTrackString += "yes" + "^\" ";
                    }
                    else
                    {
                        singleTrackString += "no" + "^\" ";
                    }
                    singleTrackString += "--forced-track ^\"" + positionElements[1] + ":";
                    if (track.forcedFlag)
                    {
                        singleTrackString += "yes" + "^\" ";
                    }
                    else
                    {
                        singleTrackString += "no" + "^\" ";
                    }
                    if (userData.modelCreator.additionalFlags.disableCompression)
                    {
                        singleTrackString += "--compression ^\"" + positionElements[1] + ":none" + "^\" ";
                    }
                    tracksStringList.Add(singleTrackString);
                }
            }
            #region insert --video-tracks or --no-video
            if (videoTracksFound)
            {
                completeTrackString += videoTracks + " ";
            }
            else
            {
                completeTrackString += "--no-video ";
            }
            #endregion
            #region insert --audio-tracks or --no-audio
            if (audioTracksFound)
            {
                completeTrackString += audioTracks + " ";
            }
            else
            {
                completeTrackString += "--no-audio ";
            }
            #endregion
            #region insert --subtitle-tracks or --no-subtitles
            if (subtitleTracksFound)
            {
                completeTrackString += subtitleTracks + " ";
            }
            else
            {
                completeTrackString += "--no-subtitles ";
            }
            #endregion

            //copy all track0 data strings to preview
            foreach (string track0String in tracksStringList)
            {
                completeTrackString += track0String;
            }
            //for track 0 set the user choosen file name
            //for external tracks use the file name without extension and append the choosen suffix/extension/both
            if (trackNumber == 0)
            {
                completeTrackString += "^\"^(^\" ^\"||inputFileName||^\" ^\"^)^\"" + " ";
            }
            else
            {
                completeTrackString += "^\"^(^\" ^\"||inputFileNameWithoutExtension||";
                if (!string.IsNullOrEmpty(suffix))
                {
                    completeTrackString += "." + suffix;
                }
                if (!string.IsNullOrEmpty(extension))
                {
                    completeTrackString += "." + extension;
                }
                completeTrackString += "^\" ^\"^)^\"" + " ";
            }
            return completeTrackString;
        }
    }
}
