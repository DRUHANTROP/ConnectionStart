using FastReport.Utils;
using Degenerators;

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
                RegisteredObjects.AddConnection(typeof(MeGonnaBeRandom), "Генератор случайных величин");

                Utils.Register(new DateGenerator());
                Utils.Register(new FirstNameGenerator());
                Utils.Register(new FullNameGenerator());
                Utils.Register(new LastNameGenerator());
                Utils.Register(new IntGenerator());
                Utils.Register(new MixedGenerator());
                Utils.Register(new LoremIpsumGenerator());

            }
        }

    } 
}
