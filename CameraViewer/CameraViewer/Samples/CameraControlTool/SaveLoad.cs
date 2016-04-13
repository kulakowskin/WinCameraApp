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

        // pulls txt files from local computer and assigns to inspection and EnginePart lists
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
                    String description = sr.ReadToEnd();
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
            StreamWriter outputFile;
            try {

                if (File.Exists(inspectionPath + @"\" + inspec.getTitle() + ".txt"))
                {
                    outputFile = new StreamWriter(inspectionPath + @"\" + inspec.getTitle() + ".txt", false);
                }
                else
                {
                    outputFile = new StreamWriter(inspectionPath + @"\" + inspec.getTitle() + ".txt", true);
                }

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
            catch(Exception ex)
            {
                Console.WriteLine("Issue saving file.");
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

            try {

                // all part file names start with 'PART-' for sorting and organization reasons
                StreamWriter outputFile;

                if (File.Exists(inspectionPath + @"\" + part.getPartName() + ".txt"))
                {
                    outputFile = new StreamWriter(inspectionPath + @"\PART-" + part.getPartName() + ".txt", false);
                }
                else
                {
                    outputFile = new StreamWriter(inspectionPath + @"\PART-" + part.getPartName() + ".txt", true);
                }

                using (outputFile)
                {
                    outputFile.WriteLine(part.getEngine());
                    outputFile.WriteLine(part.getSection());
                    outputFile.WriteLine(part.getPartName());
                    outputFile.WriteLine();
                    outputFile.WriteLine();
                    outputFile.WriteLine(part.getDescription());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Issue saveing file.");
            }

        }
    }
}
