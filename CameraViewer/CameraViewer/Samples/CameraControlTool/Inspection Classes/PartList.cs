using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CameraControlTool
{
    class PartList
    {
        private static PartList instance;
        private List<Part> parts;
        private PartList()
        {
            this.parts = new List<Part>();
        }

        public static PartList getInstance()
        {
            if (instance == null)
            {
                instance = new PartList();
            }
            return instance;
        }

        public List<Part> getParts()
        {
            return parts;
        }

        public void addNewPart(Part part)
        {
            parts.Add(part);
        }

        public void removePart(int index)
        {
            parts.RemoveAt(index);
        }

        public void editPart(String description, int index)
        {
            Part part = parts.ElementAt(index);
            part.setDescription(description);
        }

        public Part getPart(int index)
        {
            return parts.ElementAt(index);
        }

        public int getSize()
        {
            if (parts != null)
            {
                return parts.Count;
            }
            return 0;
        }
    }
}
