using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CameraControlTool
{
    class Part
    {
        private String description;
        private String partNumber;

        public Part(String description, String partNumber)
        {
            this.description = description;
            this.partNumber = partNumber;
        }

        private String getDescription()
        {
            return description; 
        }

        private String getPartNumber()
        {
            return partNumber;
        }

        private void setPartNumber(String partNumber)
        {
            this.partNumber = partNumber;
        }

        private void setDescription(String description)
        {
            this.description = description;
        }
    }
}
