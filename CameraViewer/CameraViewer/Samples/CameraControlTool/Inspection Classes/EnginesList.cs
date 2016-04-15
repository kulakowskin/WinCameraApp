using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CameraControlTool
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

        public List<Engine> getEngineList()
        {
            return engines;
        }

        public List<String> getEngineNames()
        {
            List<String> nameList = new List<String>();
            foreach(Engine e in engines)
            {
               nameList.Add( e.getDescription() );
            }

            return nameList;
        }

        /*
        For testing purposes: A hard-coded Engine list
        */
        public void testEngineList()
        {
            engines.Add(new Engine("SGT6-5000F"));
            engines.Add(new Engine("SGT6-5000G"));
            engines.Add(new Engine("SGT6-8000H"));
        }
    }
}
