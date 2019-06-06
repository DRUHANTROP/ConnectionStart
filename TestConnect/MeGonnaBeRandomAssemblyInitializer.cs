using FastReport.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConnect
{
    public class MeGonnaBeRandomAssemblyInitializer : AssemblyInitializerBase
    {
        private static bool isInitied = false;
        public MeGonnaBeRandomAssemblyInitializer()
        {
            if (!isInitied)
            {
                isInitied = true;
                RegisteredObjects.AddConnection(typeof(MeGonnaBeRandom));
            }
        }

    }
}
