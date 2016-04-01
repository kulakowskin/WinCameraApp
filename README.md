# WinCameraApp
UPDATES

Removed all the unnecessary projects and renamed the project to 'CameraViewer'.
The full path for the project file is: WinCameraApp/CameraViewer/CameraViewer/Samples/CameraSamples.sln.

DESCRIPTION

This C# application allows the use of external webcams.
Through the use of the CNET_Library, settings such as brightness, hue, contrast can be manipulated.

The key classes in working with this are:
  1. Camera.cs                            // Camera class
  2. CameraControl.cs                     // Controls the Camera
  3. FormCameraControlTool.Designer.cs    // holds the layout of the applet
  4. FormCameraControlTool.cs             // holds the core view functions

For example, the process to add the functionality of taking a picture:

1. Create a button in FormCameraControlTool.Designer.cs
  - defines its dimensions and features
  - add it to the tablelayoutpanel
2. Create function: private void buttonSavePicture_Click(object sender, EventArgs e){} in FormCameraControlTool.cs
3. Map the button to the function
  - this.buttonSavePicture.Click += new System.EventHandler(this.buttonSavePicture_Click);
