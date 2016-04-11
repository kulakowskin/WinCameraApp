using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace CameraControlTool
{
    public partial class FormNewInspection : Form
    {
        private static InspectionList inspecList;
        private DirectoryInfo di;
        private String filePath;

        public FormNewInspection()
        {
            InitializeComponent();
            inspecList = InspectionList.getInstance();
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
        }

        private void buttonSaveInspection_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            inspecList.addNewInspection(textDate.Text, textTitle.Text, textDescription.Text);
=======
            inspecList.addNewInspection("test",textTitle.Text, textDescription.Text);
>>>>>>> 5947d716f95da945342035244ba8fafb9bb3c2b6

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
                outputFile.WriteLine(textDate.Text + "\n");
                outputFile.WriteLine(textTitle.Text + "\n\n");
                outputFile.WriteLine(textDescription.Text);
            }

            this.Close();
        }

        private void FormNewInspection_Load(object sender, EventArgs e)
        {

        }
    }
}
