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
        private DateTime mDate;
        private EnginePart currentPart;

        public Inspection(String title, String description)
        {
            this.title = title;
            this.mParts = new List<EnginePart>();
            this.description = description;
            // mDate = current date
        }

        // Called when inspector wants to associate a newly captured picture with a new Engine Part
        public void createNewPart(String description, String partName)
        {
            // Creates a new engine part and adds it to the list
            EnginePart part = new EnginePart(description, partName);
            mParts.Add(part);

            // Sets the current part to the newly added part
            currentPart = part;
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
            part.editDescription(description);
        }

        // Edits the part number of the selected Engine Part
        public void editPartNumber(int index, String partName)
        {
            EnginePart part = mParts.ElementAt(index);
            part.editPartName(partName);
        }
    }
}
