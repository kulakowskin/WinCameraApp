using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CameraControlTool
{
    class Inspection
    {
        private List<Part> mParts;
        private String description;
        private DateTime mDate;

        public Inspection()
        {
            mParts = new List<Part>();
        }

        private void addPart(Part part)
        {
            mParts.Add(part);
        }

        public void removePart(int index)
        {
            mParts.RemoveAt(index);
        }
    }
}
