using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace CameraControlTool
{
    public partial class FormDirectory : Form
    {
        private static InspectionList inspecList;
        private DirectoryInfo di;
        private String filePath;

        public FormDirectory()
        {
            InitializeComponent();
            inspecList = new InspectionList();
            di = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\Documents\FERITScope Inspections\");
            filePath = @"C:\Users\" + Environment.UserName + @"\Documents\FERITScope Inspections\";
            // makes the master directory if it doesn't yet exist
            if (!Directory.Exists(filePath))
            {
                System.IO.Directory.CreateDirectory(filePath);
            }
            try
            {
                // Determine whether the directory exists.
                if (di.Exists)
                {
                    // Indicate that the directory already exists.
                    Console.WriteLine("That path exists already.");
                }
                // Try to create the directory.
                else
                {
                    di.Create();
                    Console.WriteLine("The directory was created successfully.");
                }

                // collects all the txt files in the directory
                FileInfo[] Files = di.GetFiles("*.txt");

                // puts local files in listBox format for app UI
                foreach (FileInfo file in Files)
                {
                    listBoxDirectory.Items.Add(file.Name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        private void tableLayoutPanelForm_Paint(object sender, PaintEventArgs e)
        {

        }
        // makes buttons in side pain for each inspection
        private void updateDirectory()
        {
            // gets last txt file added to the directory
            //FileInfo[] Files = di.GetFiles("*.txt");
           // FileInfo lastAdded = Files[Files.Length - 1];

            // updates listBoxDirectory with newly added inspection
           // listBoxDirectory.Items.Add(lastAdded.Name);
        }
        private void buttonNewInspection_Click(object sender, EventArgs e)
        {
            displayEmptyTextFields();
        }

        private void buttonSaveInspection_Click(object sender, EventArgs e)
        {
            inspecList.addNewInspection(textTitle.Text, textDescription.Text);

            // save to local directory
            String inspectionPath = filePath + textTitle.Text;
            // if there's no folder for this inspection yet, create one
            if (!Directory.Exists(inspectionPath))
            {
                System.IO.Directory.CreateDirectory(inspectionPath);
            }

            StreamWriter outputFile = new StreamWriter(inspectionPath +@"\"+textTitle.Text + ".txt");

            using (outputFile)
            {
                outputFile.WriteLine(textTitle.Text);
                outputFile.WriteLine();
                outputFile.WriteLine(textDescription.Text);
            }

            // if this inspection doesn't exist yet, it's added to the listBox in UI
            if (!File.Exists(inspectionPath))  
            {
                // update directory UI
                updateDirectory();
            }

            this.Close();
        }

        private void displayEmptyTextFields()
        {

        }

       
    }
}
