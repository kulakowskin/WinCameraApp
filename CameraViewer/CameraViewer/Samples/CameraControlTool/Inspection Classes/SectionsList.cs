using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CameraControlTool
{
    class SectionsList
    {
        private static SectionsList instance;
        private List<Sections> sections;
        private SectionsList()
        {
            this.sections = new List<Sections>();
        }

        public static SectionsList getInstance()
        {
            if (instance == null)
            {
                instance = new SectionsList();
            }
            return instance;
        }

        public void addNewSection(String description)
        {
            Sections section = new Sections(description);
            sections.Add(section);
        }

        public void removeSection(int index)
        {
            sections.RemoveAt(index);
        }

        public void editSection(String description, int index)
        {
            Sections section = sections.ElementAt(index);
            section.setDescription(description);
        }


    }
}
