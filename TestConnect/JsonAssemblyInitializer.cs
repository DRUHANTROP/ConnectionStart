using FastReport.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConnect
{
    public class JsonAssemblyInitializer : AssemblyInitializerBase
    {
        public JsonAssemblyInitializer()
        {
            RegisteredObjects.AddConnection(typeof(MeGonnaBeRandom));
        }
    }
}
