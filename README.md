# MKVmergeBatcher

Create/execute custom created models to batch your Mkvmerge work.

If you like my work please consider to buy me a coffee, thanks!

<a href="https://www.buymeacoffee.com/bazzu85" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>

Join the MkvMergeBather Discord server to chat and support: https://discord.gg/Eztf8tQWdt

If you want to help translate please open a new issue here on GitHub!

## How the app works

- Fill all options in View-Options (only the first time)
- Create your preferd model
- Choose the input files to work on
- Add to the queue
- Launch the queue when you're ready

All app infos (options, models, queue) is stored in the "configuration" folder alongside the MKVmergeBatcher.exe
The logs are store in the "logs" folder alongside the MKVmergeBatcher.exe

## How models works

The scope of the app is to create and use a user created model for multiple files with the same track structure.

Example: lets say we have in the same folder 1 file **VideoFile**.mkv with:
- 1 video track (position number 0)
- 1 audio track (english one, position number 1)

and some addition files with the same name but with different extension or additional suffix. For example 
- An audio file: **VideoFile**.IT.mp3
- A subtitle file VideoFile.srt (italian subtitle)

and we want to create a mkv file with
- 1 video track (from original input file)
- 1 audio track (italian, from external file)
- 1 audio track (english, from original input file)
- 1 forced subtitle (italian, from external file)

we can create a model like this:

![image](https://user-images.githubusercontent.com/7345587/153687782-a062dccb-426c-478b-89e2-3b772c364285.png)

As you see we build the destination track structure specifying from where each track is taken.

Without adding additional flags-arguments the generated model is this:

![image](https://user-images.githubusercontent.com/7345587/153687907-22e5de70-0831-42a1-aacf-af7605e60d97.png)

This model is now ready to use with as many files you want with the above illustrated file structure

Check the [Add-edit model section](README.md#add-edit-model) for additional infos

## Main Page

![image](https://user-images.githubusercontent.com/7345587/153685326-bf11a3f4-76a5-46a4-b7ee-0539961db059.png)

- If the update check is enabled ([check here](README.md#app-version-options)), this is done at the start of the app opening a popup in case of new version available
- Video file path: the path from where to grab the video file to work on
- Search in subfolders? : If activated the video file grabbed are taken also from subfolders
- Apply file name exclusion? : if activated the file name exclusion is used according to the associated Options section
- Video file list: the video file found. 
  - You can drag and drop your files
  - With a right click you can revert or clear the selection
  - If no file are selected, all files are elaborated
- Model combobox: the model to use when adding to queue
- Show queue: Show the queue window. Please refer to the [queue section](README.md#Queue) to know how to use it
- Add to queue: Add to queue the selected file using the selected model. Please refer to the [queue section](README.md#Queue) to know how to use it

## File - Import v1 userdata.json

if you are a v1 Mkvmerge Batcher user you can import your old userdata.json configuration file to v2

All you previous model are imported

![image](https://user-images.githubusercontent.com/7345587/153686497-2e9ba031-0afd-46c0-b0f1-55ac623fc364.png)

- Old userdata.json file: Specify the v1 Mkvmerge Batcher userdata.json to import
- Import button: start to import the old configuration file converting it to the v2 standard

## View - Models

In this section you can organize your models. Selecting a model the right part of the window is updated with the model details

![image](https://user-images.githubusercontent.com/7345587/153686795-34bc4be2-2cb6-44a4-8ad0-5a3ea3088bf6.png)

- Move buttons: you can move to Top-Bottom-Up-Down the selected model
- Sort button: you can sort the models by his name
- Add model (+): Open the model creation window
- Delete model: delete the currently selected model
- Edit model: Open the model edit window

Double clicking on a model automatically opens the edit window.

### Add-Edit Model

![image](https://user-images.githubusercontent.com/7345587/153687047-6484de9e-b119-460c-a274-f660fe1a7b7f.png)

Every change made on this window (obviously if the custom command is not activated), is instantly reflected on the bottom command text.

#### Tracks section
- Move buttons: you can move to Top-Bottom-Up-Down the selected track
- Add track (+): Open the track creation window
- Delete track: delete the currently selected track
- Copy track: Open the track creation window using the selected track as model
- Edit track: Open the track edit window

Double clicking on a track automatically opens the edit window.

#### Input files arguments

This options affects all input files in the generated model. According to the [above example](README.md#how-models-works) this options are used for all 3 files (input file, external audio file, external subtitle files)
- --no-attachments: add this option to all input files
- --compression none: add the --compression <fileNumber>:none arguments to all input files
- --no-global-tags: add this option to all input files
- --no-track-tags: add this option to all input files
- Custom user arguments: With this text field you can specify any arguments to use for all input files. Please check the resulting model after adding it
  
#### Output file arguments

- --title empty: add the --title "" option to the output file
- Add attachments: add the ||attachments|| wildcard to the output files. Please refer to the [wildcard section](README.md#Wildcards) to know how to use it
- Add chapters: add the ||chapters|| wildcard to the output files. Please refer to the [wildcard section](README.md#Wildcards) to know how to use it
  
#### Custom commands
  
If you prefer to provide you custom command enable it and digit in the text field. You can use all the wildard. Please refer to the [wildcard section](README.md#Wildcards) to know how to use it
  
#### Wildcards

When using a model with many files, the wildcards are used to replace some core informations (input file/output file ecc) when adding these to the queue at runtime.
  
- ||mkvmergePath|| : the mkvmerge path specified in [options](README.md#view---options)
- ||outputFileFullPath|| : the output file full path. This path is generated by the program using
  - The input file name
  - Adding (n) at the end of the file name to make this unique
  - Forcing the mkv extension
- ||inputFileName|| : the input file name choosen when adding to queue
- ||inputFileNameWithoutExtension||: the input file name choosen when adding to queue but without the extension. Usefull for external files with a suffix/different externsion. According to the [above example](README.md#how-models-works) the model contains **||inputFileNameWithoutExtension||.IT.mp3** for the external audio file and **||inputFileNameWithoutExtension||.srt** for the external subtitle file
  this options are used for all 3 files (input file, external audio file, external subtitle files)
- ||inputFileFolder|| : the folder where the input file is stored
- ||attachments|| : the attachments to add to the output file. Create a folder alongside the input file with the same name and place the attachments into it. When adding to queue all files in this folder are added to the output file as attachments.
  
  Example: 
  
  Input file: c:\test\inputFile.mp4
  
  Attachments folder: c:\test\inputFile\
- ||chapters|| : the chapter file to add to the output file. The chapter file need to be name like this: 
  Example: 
  
  Input file: c:\test\inputFile.mp4
  
  chapters file: c:\test\inputFile__chapters.xml

## View - Options

### General options

![image](https://user-images.githubusercontent.com/7345587/154701986-07ed9275-bf97-4982-8c95-f5c61093ece9.png)

- Log level:  You can choose between
  - Info
  - Debug
  - Trace
  
  If you're having issues please activate the trace log, reproduce the problem and send me the log file
  
- Language: Choose the app localization language. If you want you can contact and help me to add you language.
- MKVmerge location: the location of mkvmerge.exe file (drag and drop allowed) 
- Extensions: the extension accepted in the main page file list. The file with different extension are not considered
- Exclude file names containing: like the extension options above, the file that contains the provided texts are not considered in the main page file list

### Queue options

![image](https://user-images.githubusercontent.com/7345587/154927484-d12424b5-731d-4c02-88ec-14efebd3db10.png)
  
- Move Ok files to: when a job ends with a exit code 0 (Ok), the output file will be moved in a destination folder according to this options. Default: ||originalFolder|| -> no move
- Move Warning files to: when a job ends with a exit code 1 (Warning), the output file will be moved in a destination folder according to this options. Default: ||originalFolder|| -> no move
- Output file format: You can specify some pattern to the generated output file name. For example using "before_||originalInputFile||_after" every output file is generated with the format "before_file_after.mkv". if the file exists "before_file_after (1).mkv" and so on
- Replace destination file (when moving): If this option is activated, when moving a file (check "Move Ok files to" and "Move Warning files to"), if the file is already in destination directory
  - The current destination file is renamed appending "_backup" to the file name
  - The output file is then moved to the destination folder
- Delete incomplete files when stopping queue: If this option is activated, when manually stopping the queue, the not completed output file is deleted
- Automatically remove Ok Jobs: If this option is activated, when the queue is not running, the jobs in status "Ok" are automatically removed. Can be changed even in [queue context menu](README.md#jobs-section)
- Automatically remove Warning Jobs: If this option is activated, when the queue is not running, the jobs in status "Warning" are automatically removed. Can be changed even in [queue context menu](README.md#jobs-section)
- Show queue window when adding a job?: If this option is activated, after adding a job the queue windows is shown. Otherwise not. Default: activated
- Show summary when the queue work end?: If this option is activated, when all jobs in the queue are ended, a Summary is shown. Otherwise not. Default: activated
- Only show summary when Warnings/Errors occurs?: If this option is activated, when all jobs in the queue are ended, a Summary is shown only if some Warnings or Errors occurred. Otherwise the summary is showed in every situation according to the "Show summary when the queue work end?" checkbox. Default: disabled

### App version options

![image](https://user-images.githubusercontent.com/7345587/154702153-81631b0d-be22-43b9-a134-482aa2b02b4c.png)

- Automatically check for updates: if enabled, when the app starts checks the last version here on Github. if a new version is available a popup appear to let the user open the release page
- Current version: the current running version
- Last version found: the last checked version on github. Using the Check now button you can force an update check.

## Queue

The queue window once opened remains active even if the user closes it. The queue work runs in background too giving a message when finishing
  
![image](https://user-images.githubusercontent.com/7345587/154110989-1d5aacf1-ba95-4f74-94db-f64670c67dc4.png)

#### Jobs section
- Move buttons: you can move to Top-Bottom-Up-Down the selected job
- Delete job: delete the currently selected track
- Copy track: Open the track creation window using the selected track as model
- Clear queue (X button): Clear all jobs
- Right click context menu:
  
  ![image](https://user-images.githubusercontent.com/7345587/154242552-626ae7c8-970a-4fb3-a97f-b1684ba5c2e0.png)

  - Clear queue: Same as above
  - Reset all Ok jobs: Change the status of all Ok Jobs in "Pending"
  - Reset all Warnning jobs: Change the status of all Warning Jobs in "Pending"
  - Reset all Error jobs: Change the status of all Error Jobs in "Pending"
  - Clear all Ok jobs: Delete all the job in status Ok
  - Clear all Warnning jobs: Delete all the job in status Warning
  - Clear all Error jobs: Delete all the job in status Error
  - Automatically remove Ok Jobs: If this option is activated, when the queue is not running, the jobs in status "Ok" are automatically removed.
  - Automatically remove Warning Jobs: If this option is activated, when the queue is not running, the jobs in status "Warning" are automatically removed. 

Create Bat: All eligible jobs (Pending status) will be saved to a choosen bat file. After the creation a job delete confirmation appear to let the user choose if delete the exported jobs from the queue.

Start: Start the queue elaboration

Stop: Stop the queue elaboration. 
