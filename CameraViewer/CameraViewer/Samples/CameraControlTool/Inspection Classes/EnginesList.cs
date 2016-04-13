using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CameraControlTool.Inspection_Classes
{
    class EnginesList
    {
        private static EnginesList instance;
        private List<Engine> engines;
        private EnginesList()
        {
            this.engines = new List<Engine>();
        }

        public static EnginesList getInstance()
        {
            if (instance == null)
            {
                instance = new EnginesList();
            }
            return instance;
        }

        public void addNewEngine(String description)
        {
            Engine engine = new Engine(description);
            engines.Add(engine);
        }

        public void removeEngine(int index)
        {
            engines.RemoveAt(index);
        }

        public void editEngine(String description, int index)
        {
            Engine engine = engines.ElementAt(index);
            engine.setDescription(description);
        }
    }
}
