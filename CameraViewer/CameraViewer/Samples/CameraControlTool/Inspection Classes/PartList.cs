﻿using System;
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

        public PartList getInstance()
        {
            if (instance == null)
            {
                instance = new PartList();
            }
            return instance;
        }

        public void addNewPart(String description)
        {
            Part part = new Part(description);
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
    }
}
