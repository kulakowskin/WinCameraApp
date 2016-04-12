﻿using System;
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
            inspecList = InspectionList.getInstance();
            loadData();
            ListDirectory(treeView1, filePath);
        }

        private void buttonNewInspection_Click(object sender, EventArgs e)
        {
            //displayEmptyTextFields();
        }

        private void buttonSaveInspection_Click(object sender, EventArgs e)
        {
            inspecList.addNewInspection(textDate.Text, textTitle.Text, textDescription.Text);

            // save to local directory
            String inspectionPath = filePath + textTitle.Text;
            // if there's no folder for this inspection yet, create one
            if (!Directory.Exists(inspectionPath))
            {
                System.IO.Directory.CreateDirectory(inspectionPath);
            }

            StreamWriter outputFile = new StreamWriter(inspectionPath + @"\" + textTitle.Text + ".txt");

            using (outputFile)
            {
                outputFile.WriteLine(textDate.Text);
                outputFile.WriteLine();
                outputFile.WriteLine(textTitle.Text);
                outputFile.WriteLine();
                outputFile.WriteLine();
                outputFile.WriteLine(textDescription.Text);
            }

            savePart();

            ListDirectory(treeView1, filePath);
        }

        private void savePart()
        {

            Inspection inspec = inspecList.searchInspections(textTitle.Text);
            // checks if the part already exists and either edit or add
            if (inspec.exists(textPart.Text))
            {
                inspec.editPartDescription(inspec.getPartIndex(textPart.Text), textPartDescription.Text);
            }
            else
            {
               // inspec.createNewPart(textPartDescription.Text, textPart.Text);
            }

            // save part to local directory
            String inspectionPath = filePath + textTitle.Text;
            // if there's no folder for this inspection yet, create one
            if (!Directory.Exists(inspectionPath))
            {
                System.IO.Directory.CreateDirectory(inspectionPath);
            }

            // all part file names start with 'PART-' for sorting and organization reasons
            StreamWriter outputFile = new StreamWriter(inspectionPath + @"\PART-" + textPart + ".txt", true);

            using (outputFile)
            {
                outputFile.WriteLine(textPart);
                outputFile.WriteLine();
                outputFile.WriteLine();
                outputFile.WriteLine(textPartDescription.Text);
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

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {   
            TreeNode node = treeView1.SelectedNode;

            try {
                // checks that it isn't the parent node
                if (e.Node.Parent.Text != null)
                {
                    String title = e.Node.Text;
                    String parent = e.Node.Parent.Text;

                    title.Replace(".txt", "");
                    if (e.Node.GetNodeCount(true) == 1)
                    {
                        loadText(title);
                    }
                    if (title.Contains("PART"))
                    {
                        title.Replace("PART-", "");
                        loadPartText(title, parent);
                    }
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void loadPartText(String partName, String inspecName)
        {
            // find part with matching name and load text boxes   
            Inspection i = inspecList.searchInspections(inspecName);
            EnginePart part = i.searchEngineParts(partName);
            textPart.Text = part.getPartName().ToString();
            textEngine.Text = part.getEngine().ToString();
            textSection.Text = part.getSection().ToString();
        }

        public void loadText(String node)
        {
            Inspection i = inspecList.searchInspections(node);
            textTitle.Text = node;
            textDescription.Text = i.getDescription();
            textDate.Text = i.getDate();
        }

        public void loadData()
        {
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
                if (!di.Exists)
                {
                    di.Create();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }

            // for loading data of each Inspection folder
            foreach (var directory in di.GetDirectories())
            {
                    loadInspection(directory);
            }   
        }
    
        public void loadInspection(DirectoryInfo dir)
        {
            String title = dir.Name+".txt";
            List<EnginePart> partNames = new List<EnginePart>();

            foreach (var file in dir.GetFiles())
            {
                if (file.Name == title)  // looking for primary inspection .txt
                {
                    StreamReader sr = file.OpenText();
                    String date = sr.ReadLine();
                    String ignore = sr.ReadLine();      // ignore is just white space
                    String name = sr.ReadLine();
                    ignore = sr.ReadLine();
                    ignore = sr.ReadLine();
                    string description = sr.ReadToEnd();
                    inspecList.addNewInspection(date, name, description);
                }
                else if (file.Name.Contains("PART"))   // for loading PART files
                {
                    StreamReader sr = file.OpenText();
                    String partName = sr.ReadLine();
                    String ignore = sr.ReadLine();
                    ignore = sr.ReadLine();
                    String partDesc = sr.ReadToEnd();

                   // partNames.Add(new EnginePart(partDesc, partName));
                }
                // add another condition for loading jpgs or pngs
            }
            Inspection inspec = inspecList.searchInspections(dir.Name);
            foreach(EnginePart part in partNames)
            {
                inspec.addExistingPart(part);
            }
        }
        public void FormDirectory_Load(Object sender, EventArgs e)
        {

        }
    }
}
