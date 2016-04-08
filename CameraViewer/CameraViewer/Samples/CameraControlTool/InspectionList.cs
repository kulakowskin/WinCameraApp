using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CameraControlTool
{
    // This class holds all of the inspections created. An operator will be able to view all of the inspections
    class InspectionList
    {
        // List of all inspections
        private List<Inspection> mInspections;
        //private Inspection currentInspection;
        
        public InspectionList()
        {
            mInspections = new List<Inspection>();
        }

        // Adds a new inspection to the list
        public void addNewInspection(String title, String description)
        {
            // Creates a new inspection and adds it to the list
            Inspection inspection = new Inspection(title, description);
            mInspections.Add(inspection);

            // Sets the current inspection
            //currentInspection = inspection;
        }

        // Edits the description of the selected inspection
        public void editInspection(int index, String description)
        {
            mInspections.ElementAt(index).editDescription(description);
        }

        // Deletes the selected inspection
        public void deleteInspection(int index)
        {
            mInspections.RemoveAt(index);
        }

        // Returns the list of inspections
        public List<Inspection> getInspections()
        {
            return mInspections;
        }
    }
}
