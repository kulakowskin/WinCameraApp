using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CameraControlTool
{
    // This class describes the current Engine Part an operator is inspecting. An operator will be able to add/edit the description and part number.
    class EnginePart
    {
        private List<Bitmap> pictures;
        private String description;
        private String partNumber;

        public EnginePart(String description, String partNumber)
        {
            this.pictures = new List<Bitmap>();
            this.description = description;
            this.partNumber = partNumber;
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


        // Methods for part number

        public String getPartNumber()
        {
            return partNumber;
        }

        public void editPartNumber(String partNumber)
        {
            this.partNumber = partNumber;
        }

    }
}
