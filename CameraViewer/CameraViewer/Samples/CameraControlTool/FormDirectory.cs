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
                
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        private void tableLayoutPanelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonNewInspection_Click(object sender, EventArgs e)
        {
            //displayEmptyTextFields();
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

            ListDirectory(treeView1, filePath);
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            return directoryNode;
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            // call some function to update textBoxes being displayed
        }

    }
}
