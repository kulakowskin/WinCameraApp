using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CameraControlTool
{
    class InspectionList
    {
        // List of all inspections
        private List<Inspection> mInspections;
        private int lastIndex = -1;

        public InspectionList()
        {
            mInspections = new List<Inspection>();
        }
        
        private void addInspection(Inspection inspection)
        {
            mInspections.Add(inspection);
            lastIndex++;
        }

        private Inspection getCurrentInspection()
        {
            return mInspections[lastIndex];
        }
        
        private void deleteInspection(int index)
        {
            mInspections.RemoveAt(index);
            lastIndex--;
        }

        private List<Inspection> getInspections()
        {
            return mInspections;
        }
    }
}
