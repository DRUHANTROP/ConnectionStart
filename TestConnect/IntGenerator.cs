using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomicGenerator
{
    [Serializable]
    class IntGenerator:IRandomGenerator
    {
        private Random rnd = new Random(DateTime.Now.Millisecond);

        public string Name { get; set; }
        public object Next()
        {
            return rnd.Next();
        }
    }
}
