using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degenerators
{
    [Serializable]
    public class IntGenerator: IRandomGenerator
    {
        private Random rnd = new Random(DateTime.Now.Millisecond);

        public string Name => "Int";

        public Type Type => typeof(int);

        public string ColumnName { get; set; }

        public IRandomGenerator Create()
        {
            return new IntGenerator();
        }

        public object Next()
        {
            return rnd.Next(1000);
        }

        
    }
}