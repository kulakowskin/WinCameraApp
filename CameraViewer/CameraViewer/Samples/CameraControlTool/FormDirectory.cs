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
        private SaveLoad SL;

        public FormDirectory()
        {
            InitializeComponent();
            inspecList = InspectionList.getInstance();
            filePath = filePath = @"C:\Users\" + Environment.UserName + @"\Documents\FERITScope Inspections\";
            SL.loadData();
            ListDirectory(treeView1, filePath);
        }

        private void buttonSaveInspection_Click(object sender, EventArgs e)
        {
            Inspection inspec = inspecList.searchInspections(textTitle.Text);
            SL.saveInspection(inspec);
            // update any changes to description
            inspec.editDescription(textDescription.Text);
            EnginePart part = inspec.searchEngineParts(textPart.Text);
            // update any changes to part description
            part.setDescription(textPartDescription.Text);
            SL.savePart(part);
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
            textPart.Text = part.getPartName();
            textEngine.Text = part.getEngine();
            textSection.Text = part.getSection();
        }

        public void loadText(String node)
        {
            Inspection i = inspecList.searchInspections(node);
            textTitle.Text = node;
            textDescription.Text = i.getDescription();
            textDate.Text = i.getDate();
        }

        public void FormDirectory_Load(Object sender, EventArgs e)
        {

        }
    }
}
