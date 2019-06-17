using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degenerators
{
    [Serializable]
    public class IdGenerator : IRandomGenerator
    {
        private int i = 0;
        public string Name => "Id";

        public Type Type => typeof(int);

        public string ColumnName { get; set; }

        public string Description => "Returns sequence like 1,2,3,4... \nExample : 1";

        public IRandomGenerator Create()
        {
            return new IdGenerator();
        }

        public object Next()
        {
            return ++i;

        }


    }
}