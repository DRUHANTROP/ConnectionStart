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
        IRandomGenerator[] generators = { new IdGenerator(), new FirstNameGenerator(), new LastNameGenerator(), new FullNameGenerator(), new DateGenerator(), new SalaryGenerator() };
        private Random r = new Random();

        public string Name => "Mixed";

        public string ColumnName { get; set; }

        public Type Type => typeof(object);

        public string Description => "Returns return from random generator \n(still in progress)\nExample :" + Next();

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