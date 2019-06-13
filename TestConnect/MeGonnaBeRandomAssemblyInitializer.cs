using FastReport.Utils;
using RandomicGenerator;

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
