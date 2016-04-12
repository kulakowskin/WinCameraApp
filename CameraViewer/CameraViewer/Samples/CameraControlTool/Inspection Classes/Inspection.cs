using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CameraControlTool
{

    // This class contains all of the EngineParts and their associated pictures created by an operator. 
    class Inspection
    {
        private List<EnginePart> mParts;
        private String title;
        private String description;
        private String date;
        //private DateTime mDate;
        private EnginePart currentPart;

        public Inspection(String date, String title, String description)
        {
            this.date = date;
            this.title = title;
            this.mParts = new List<EnginePart>();
            this.description = description;
            // mDate = current date
        }

        // Called when inspector wants to associate a newly captured picture with a new Engine Part
        public void createNewPart(String description, String partName, String section, String engine)
        {
            // Creates a new engine part and adds it to the list
            EnginePart part = new EnginePart(description, partName, section, engine);
            mParts.Add(part);

            // Sets the current part to the newly added part
            currentPart = part;
        }
        // used in loading data because List of parts already exists
        public void addExistingPart(EnginePart part)
        {
            mParts.Add(part);
        }

        // Adds a picture to the current part
        public void addPicture(Bitmap picture)
        {
            currentPart.addPicture(picture);
        }

        public void editDescription(String description)
        {
            this.description = description;
        }

        // Removes an unwanted Engine part from the inspection
        public void removeEnginePart(int index)
        {
            mParts.RemoveAt(index);
        }

        // Edits the description of the selected Engine Part
        public void editPartDescription(int index, String description)
        {
            EnginePart part = mParts.ElementAt(index);
            part.setDescription(description);
        }

        // Edits the part number of the selected Engine Part
        public void editPartName(int index, String partName)
        {
            EnginePart part = mParts.ElementAt(index);
            part.setPartName(partName);
        }
        public bool exists(String part)
        {
            foreach(EnginePart p in mParts)
            {
                if (part == p.getPartName())
                {
                    return true;
                }
            }
            return false;
        }

        public int getPartIndex(String partName)
        {
            for(int i = 0; i < mParts.Count; i++)
            {
                if(partName == mParts.ElementAt(i).getPartName())
                {
                    return i;
                }
            }
            return 0;
        }


        // Search for EnginePart by name
        public EnginePart searchEngineParts(String name)
        {
            foreach (EnginePart part in mParts)
            {
                if (part.getPartName() == name)
                {
                    return part;
                }
            }
            // this is a really horrible fix for not finding the inspection
            EnginePart e = new EnginePart("date", "description", "section", "engine");
            return e;
        }


        /******** getters **************/
        public String getTitle()
        {
            return title;
        }
        public String getDescription()
        {
            return description;
        }
        public String getDate()
        {
            return date;
        }
        public List<EnginePart> getEngineParts()
        {
            return mParts;
        }
    }
}
