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

        public List<String> getPartNames()
        {
            List<String> nameList = new List<String>();
            foreach (Part p in parts)
            {
                nameList.Add(p.getDescription());
            }

            return nameList;
        }

        /*
       For testing purposes: A hard-coded Parts list
       */
        public void testPartList()
        {
            parts.Add(new Part("blade 3"));
            parts.Add(new Part("support housing"));
            parts.Add(new Part("vane 3"));
            parts.Add(new Part("pilot nozzle 8"));
            parts.Add(new Part("basket 2"));
            parts.Add(new Part("transition 4"));
            parts.Add(new Part("inner transition seal 1"));
            parts.Add(new Part("outer transition seal 2"));
        }
    }
}
