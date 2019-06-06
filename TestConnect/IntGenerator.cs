<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomicGenerator
{
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
>>>>>>> 0c7653ce58b613fb77733e43695e44721ddfed95
