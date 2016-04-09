using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CameraControlTool
{
    // This class describes the current Engine Part an operator is inspecting. An operator will be able to add/edit the description and part name.
    class EnginePart
    {
        private List<Bitmap> pictures;
        private String description;
        private String partName;

        public EnginePart(String description, String partName)
        {
            this.pictures = new List<Bitmap>();
            this.description = description;
            this.partName = partName;
        }


        // Methods for pictures
        public List<Bitmap> getPictures()
        {
            return pictures;
        }

        // Might not need this method, getPictures already returns the list of pictures
        public Bitmap getPictureAt(int index)
        {
            return pictures.ElementAt(index);
        }

        public void addPicture(Bitmap picture)
        {
            pictures.Add(picture);
        }

        public void deletePicture(int index)
        {
            pictures.RemoveAt(index);
        }

        // Methods for description

        public String getDescription()
        {
            return description; 
        }

        public void editDescription(String description)
        {
            this.description = description;
        }


        // Methods for part name

        public String getPartName()
        {
            return partName;
        }

        public void editPartName(String partName)
        {
            this.partName = partName;
        }

    }
}
