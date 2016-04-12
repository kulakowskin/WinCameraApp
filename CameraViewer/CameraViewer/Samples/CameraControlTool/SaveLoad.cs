using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CameraControlTool
{
    class SaveLoad
    {
        private DirectoryInfo di;
        private String filePath;
        private InspectionList inspecList;

        public SaveLoad()
        {
            inspecList = InspectionList.getInstance();
            di = new DirectoryInfo(@"C:\Users\" + Environment.UserName + @"\Documents\FERITScope Inspections\");
            filePath = @"C:\Users\" + Environment.UserName + @"\Documents\FERITScope Inspections\";
        }

        public void loadData()
        {
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
            String title = dir.Name + ".txt";
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
                    String engine = sr.ReadLine();
                    String section = sr.ReadLine();
                    String part = sr.ReadLine();
                    String ignore = sr.ReadLine(); 
                    ignore = sr.ReadLine();
                    String partDesc = sr.ReadToEnd();

                    partNames.Add(new EnginePart(partDesc, part, section, engine));
                }
                // add another condition for loading jpgs or pngs
            }
            Inspection inspec = inspecList.searchInspections(dir.Name);
            foreach (EnginePart part in partNames)
            {
                inspec.addExistingPart(part);
            }
        }
  
        public void saveInspection(Inspection inspec)
        {
            inspecList.addNewInspection(inspec.getDate(), inspec.getTitle(), inspec.getDescription());

            // save to local directory
            String inspectionPath = filePath + inspec.getTitle();
            // if there's no folder for this inspection yet, create one
            if (!Directory.Exists(inspectionPath))
            {
                System.IO.Directory.CreateDirectory(inspectionPath);
            }

            StreamWriter outputFile = new StreamWriter(inspectionPath + @"\" + inspec.getTitle() + ".txt");

            using (outputFile)
            {
                outputFile.WriteLine(inspec.getDate());
                outputFile.WriteLine();
                outputFile.WriteLine(inspec.getTitle());
                outputFile.WriteLine();
                outputFile.WriteLine();
                outputFile.WriteLine(inspec.getDescription());
            }
        }

        public void savePart(EnginePart part, Inspection inspec)
        {
            // save part to local directory
            string inspectionPath = filePath + inspec.getTitle();

            // if there's no folder for this inspection yet, create one
            if (!Directory.Exists(inspectionPath))
             {
                System.IO.Directory.CreateDirectory(inspectionPath);
             }

            // all part file names start with 'part-' for sorting and organization reasons
            StreamWriter outputfile = new StreamWriter(inspectionPath + @"\PART-" + part.getPartName() + ".txt", true);

            using (outputfile)
            {
                outputfile.WriteLine(part.getEngine());
                outputfile.WriteLine(part.getSection());
                outputfile.WriteLine(part.getPartName());
                outputfile.WriteLine();
                outputfile.WriteLine();
                outputfile.WriteLine(part.getDescription());
            }

        }
    }
}
