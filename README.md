# WinCameraApp
This C# application allows the use of external webcams.

# Resources
The full path for the project file is: WinCameraApp/CameraViewer/CameraViewer/Project/CameraSamples.sln.
The full path for the source code is: WinCameraApp/CameraViewer/CameraViewer/Project/CameraControlTool

# Description
Through the use of the CNET_Library, settings such as brightness, hue, contrast can be manipulated.

The key classes in working with this are:
  1. Camera.cs                            // Camera class
  2. CameraControl.cs                     // Access methods for the Camera such as setting resolution, taking a picture, etc.
  3. FormCameraControlTool.Designer.cs    // holds the layout of the main applet
  4. FormCameraControlTool.cs             // holds the core view functions

For example, the process to add the functionality of taking a picture:

1. Create a button in FormCameraControlTool.Designer.cs
  - define its dimensions and features
  - add it to the tablelayoutpanel
2. Create function: private void buttonSavePicture_Click(object sender, EventArgs e){} in FormCameraControlTool.cs
3. Map the button to the function
  - this.buttonSavePicture.Click += new System.EventHandler(this.buttonSavePicture_Click);

# Further Development
The key classes for adding features are in CameraControlTool->Inspection Classes and CameraControlTool->Inspection Forms.
Currently custom parts can be added. This is done using the EnginePartListForm and Part.cs and PartList.cs. 
To expand this to have Sections and Engines follow the structure in EnginePartListForm. 
1. Create a form such as SectionPartListForm, following the template of EnginePartListForm.
2. Replace the PartList with SectionList
3. In the add/remove methods, replace Part with Section.
4. The same can be done with EnginesList and Engine

Then adding the features can easily be done using the built in designer in Visual Studio. 
In the designer:
1. Double Click File->Manage Engines and it will direct you to the corresponding function call.
2. Create the new form you created and show it
