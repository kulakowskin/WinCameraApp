# WinCameraApp
This C# application allows the use of external webcams.

# Resources
The full path for the project file is: WinCameraApp/CameraViewer/CameraViewer/Project/CameraSamples.sln.
The full path for the source code is: WinCameraApp/CameraViewer/CameraViewer/Project/CameraControlTool

# Usage
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
