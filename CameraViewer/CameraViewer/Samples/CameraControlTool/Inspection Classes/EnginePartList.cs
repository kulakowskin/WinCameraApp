using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CameraControlTool
{
    class EnginePartList
    {
        private static EnginePartList instance;
        private List<EnginePart> engineParts;
        private EnginePartList()
        {
            this.engineParts = new List<EnginePart>();
        }

        public static EnginePartList getInstance()
        {
            if (instance == null)
            {
                instance = new EnginePartList() { };
            }
            return instance;
        }

        public List<EnginePart> getEngineParts()
        {
            return engineParts;
        }

        public EnginePart getEnginePart(int index)
        {
            return engineParts.ElementAt(index);

        }

        public void removePart(int index)
        {
            engineParts.RemoveAt(index);
        }

        public void addNewPart(EnginePart enginePart)
        {
            engineParts.Add(enginePart);
        }

        public int getSize()
        {
            if (engineParts != null)
            {
                return engineParts.Count;
            }
            else
            {
                return 0;
            }
        }

    }
}
