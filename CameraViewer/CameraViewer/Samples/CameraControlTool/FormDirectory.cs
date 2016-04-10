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
            loadData();
            ListDirectory(treeView1, filePath);
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
            String textPart = comboBoxParts.Text;
            Inspection inspec = inspecList.searchInspections(textTitle.Text);
            // checks if the part already exists and either edit or add
            if (inspec.exists(textPart))
            {
                inspec.editPartDescription(inspec.getPartIndex(textPart), textPartDescription.Text);
            }
            else
            {
                comboBoxParts.Items.Add(textPart);
                inspec.createNewPart(textPartDescription.Text, textPart);
            }

            // save part to local directory
            String inspectionPath = filePath + textTitle.Text;
            // if there's no folder for this inspection yet, create one
            if (!Directory.Exists(inspectionPath))
            {
                System.IO.Directory.CreateDirectory(inspectionPath);
            }

            // all part file names start with 'PART-' for sorting and organization reasons
            StreamWriter outputFile = new StreamWriter(inspectionPath + @"\PART-" + textPart + ".txt");

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

        private void treeNode_Select(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            String title = node.Text;
            if (title.Contains(".txt"))
            {
                title.Replace(".txt", "");
            }
            loadText(title);
            loadComboBox(title);
        }

        public void loadText(String title)
        {
            foreach (Inspection inspec in inspecList.getInspections())
            {
                if (inspec.getTitle() == title)
                {
                    textTitle.Text = title;
                    textDescription.Text = inspec.getDescription();
                    textDate.Text = (inspec.getDate()).ToString();
                }
                // condition if the file is in the local directory but hasn't been put in 
                // InspectionList since app was last opened
                else
                {
                    //StreamReader inputFile = new StreamReader(filePath + title + @"\" + title + ".txt");
                }
            }
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

            foreach (var directory in di.GetDirectories())
            {
                    loadInspection(directory.Name);
            }   
        }
    
        // each time a new inspection is selected, the parts drop down is updated
        public void loadComboBox(String title)
        {
            Inspection inspec = inspecList.searchInspections(title);
            foreach (EnginePart ep in inspec.getEngineParts())
                {
                    comboBoxParts.Items.Add(ep.getPartName());
                }
        }

        public void loadInspection(String title)
        {
            foreach (var file in di.GetFiles())
            {
                if(file.Name == title)
                {
                   // inspecList.addNewInspection(title);
                }
            }
        }

        public void buttonShowNotes_Click(Object sender, EventArgs e)
        {
            String part = comboBoxParts.Text;
            Inspection inspec = inspecList.searchInspections(textTitle.Text);
            if (inspec.exists(part)){
                EnginePart p = inspec.getEngineParts().ElementAt(inspec.getPartIndex(part));
                textPartDescription.Text = p.getDescription();
            }
        }
    }
}
