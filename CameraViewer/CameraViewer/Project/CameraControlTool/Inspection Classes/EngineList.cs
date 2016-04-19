using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CameraControlTool.Inspection_Classes
{
    class EngineList
    {
        private static EngineList instance;
        private List<String> engineList;

        private EngineList()
        {
            this.engineList = new List<String>();
        }

        public static EngineList getInstance()
        {
            if (instance == null)
            {
                instance = new EngineList();
            }
            return instance;
        }

        public void addNewEngine(String description)
        {
            engineList.Add(description);
        }

        public void removeEngine(int index)
        {
            engineList.RemoveAt(index);
        }
    }
}
