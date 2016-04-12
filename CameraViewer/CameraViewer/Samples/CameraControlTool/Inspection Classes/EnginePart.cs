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
        //private String partName;
        //private String section;
        //private String engine;
        private Part partName;
        private Sections section;
        private Engine engine;
        private bool flag;

        //public EnginePart(String description, String partName, String section, String engine)
        public EnginePart(String description, Part partName, Sections section, Engine engine)
        {
            this.pictures = new List<Bitmap>();
            this.description = description;
            //this.partName = partName;
            //this.section = section;
            //this.engine = engine;
            this.flag = false;
        }
        
        public EnginePart()
        {

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

        // getters

        public String getDescription()
        {
            return description; 
        }

        //public String getPartName()
        public Part getPartName()
        {
            return partName;
        }

        //public String getSection()
        public Sections getSection()
        {
            return section;
        }

        //public String getEngine()
        public Engine getEngine()
        {
            return engine;
        }

        public bool isFlagged()
        {
            return flag;
        }

        // setters



        public void setPartName(String partName)
        {
            //this.partName = partName;
            this.partName.setDescription(partName);
        }

        public void setDescription(String description)
        {
            this.description = description;
        }

        public void setSection(String section)
        {
            //this.section = section;
            this.section.setDescription(section);
        }

        public void setEngine(String engine)
        {
            //this.engine = engine;
            this.engine.setDescription(engine);
        }

        public void setFlag(bool flag)
        {
            this.flag = flag;
        }

    }
}
