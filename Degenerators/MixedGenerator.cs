using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degenerators
{
    [Serializable]
    public class MixedGenerator : IRandomGenerator
    {
        IRandomGenerator[] generators = { new IntGenerator(), new FirstNameGenerator(), new LastNameGenerator(), new FullNameGenerator(), new DateGenerator() };
        private Random r = new Random();

        public string Name => "Mixed";

        public string ColumnName { get; set; }

        public Type Type => typeof(object);

        public IRandomGenerator Create()
        {
            return new MixedGenerator();
        }


        public object Next()
        {
            IRandomGenerator generator = generators[r.Next(generators.Length)];
            return generator.Next();
        }

    }
}