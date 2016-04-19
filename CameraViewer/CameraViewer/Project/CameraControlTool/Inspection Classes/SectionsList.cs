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

        public List<Sections> getSections()
        {
            return sections;
        }

        public List<String> getSectionNames()
        {
            List<String> nameList = new List<String>();
            foreach (Sections s in sections)
            {
                nameList.Add(s.getDescription());
            }

            return nameList;
        }

        /*
       For testing purposes: A hard-coded Section list
       */
        public void testSectionsList()
        {
            sections.Add(new Sections("compressor IGV"));
            sections.Add(new Sections("compressor vane row 12"));
            sections.Add(new Sections("compressor blade row 14"));
            sections.Add(new Sections("combustor"));
            sections.Add(new Sections("turbine vane row 01"));
            sections.Add(new Sections("turbine blade row 04"));
        }

    }
}
