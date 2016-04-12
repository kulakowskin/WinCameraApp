using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CameraControlTool.Inspection_Classes
{
    class SectionList
    {
        private static SectionList instance;
        private List<String> sectionList;
        private SectionList()
        {
            this.sectionList = new List<String>();
        }

        public static SectionList getInstance()
        {
            if (instance == null)
            {
                instance = new SectionList();
            }
            return instance;
        }

        public void addNewSection(String description)
        {
            sectionList.Add(description);
        }

        public void removeSection(int index)
        {
            sectionList.RemoveAt(index);
        }

    }
}
