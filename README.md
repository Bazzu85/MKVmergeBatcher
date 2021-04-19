# MKVmergeBatcher

This windows form allow users to create/execute custom created mkv models.

## 1. Batcher Tab

Before using the Batcher tab add some model. See 3. Model Creator Tab and 2. Manage Models Tab

### 1.1 First steps
First at all select the mkvmerge.exe location. Without this nothing can be done
Customize the video extension of the file you want to manage (format: ext1,ext2,ext3)

### 1.2 Add file or entire folder to app
Using the second browse button a window appear to choose a single file or an entire folder (because of the limitation of the environment, using "Folder Selection." you can add all files from the folder and nested ones)
The files choosen are added at mid window. 
No file selected -> all files will be elaborated
Some file selected -> Only those files will be elaborated
Using mouse right click you can work on selection

### 1.3 Choosing model
With the drop down box at bottom of page you can select the right model based on choosen files structure. (use mediainfo to check every file structure)

### 1.4 Create bat
If all is ok, the app let you save a .bat file with the command line to exectute the batching work on the choosen files.

### 1.5 Exec Now
If all is ok, a new Window appear. Clicking Start the app start to directly elaborate the files/model choosen giving real time results.

## 2. Model Management

In this tab all model create can be modified/deleted/sorted

## 3. Model Creator Tab

### 3.1 Model Prepation
In this tab the app let you build a destination file structure specifing where every track come from.
We have some fields to populate:
- Track type: Video/Audio/Subtitle
- Position: The original position of the track in files. Format OriginalFileNumber:PositionInOriginalFile
The basic file (the one choosed in Batcher Tab) is the OriginalFileNumber 0 and cannot be external. Additional external files has to be > 0
The PositionInOriginalFile is the relative track position in choosen file starting from 0
- Language Code: default is und for no language code. You can specify any language code accepted by mkvmerge (ex. eng or ita)
- Language Name: can be empty and specify the track text in destination file
- External: not flagged for basic file (the one choosed in Batcher Tab), flagged for every external file
- Extension: the extension for external file. The file name without extension must be identical for every external file
- Suffix: a suffix for differentiate the external files with same extension.
- Default: if choosen the track will be marked as default in destination file.
PS only 1 track by type can be default at the same time
- Forced: if choosen the track will be marked as Forced in destination file.

Additional tags:
- --no-attachments: add in the model the --no-attachments parameter
- --title empty: add in the model the --title parameter with empty value
- --compression none: add in the model the --compression parameter with "none" value

NEW IN > 1.1.76 version
- Add attachments: add in the model the ||attachments|| tag. When executing the creating/executing the batch the app search for all file 
  under a folder named as executing file name and add them as attachments. The --no-attachments and Add attachements are exclusives
  
  Example:
  
  VideoFile: C:\Video\test.mkv
  
  Attachment1: C:\Video\test\font1.ttf
  
  Attachment1: C:\Video\test\font2.ttf

NEW IN > 1.1.77 version
- Add chapters: add in the model the ||chapters|| tag. The chapter must have this name fileName_chapters.xml. If the xml is not in the 
  folder, the tag is skipped
  
  Example:
  
  VideoFile: C:\Video\test.mkv
  
  Chapter file: C:\Video\test_chapters.xml

### 3.2 Preview and Model Creation
Clicking on preview the insered data will be validated.
If all is ok, a new window appear with the Model Generated. Typing a name and clicking Add, the generated model will be saved in Models List

## 4. Queue Tab new in > 1.1.78

Now MKVBatcher has the ability to store multiple video (with it's own model choosen) in a queue.
After finishing to build the queue you can choose to create a unique big bat file or execute al conversion with one click.
ATTENCTION: modifying the models (adding, reordering, deleting) cause the queue to automatically been emptied

# Known BUG and hot to fix it

## The GUI start but is not showing?

Close the program in taskbar if open (right click, close)
Open the %localappdata% folder (WIN+R and type %localappdata%) 
Delete the MKVmergeBatcher folder
Try to open MKVmergeBatcher
