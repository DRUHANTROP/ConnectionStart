<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomicGenerator
{
    [Serializable]
    class DateGenerator : IRandomGenerator
    {
        Random r = new Random();
        public string Name { get; set; }

        public object Next()
        {
            return new DateTime(r.Next(2000,DateTime.Now.Year),r.Next(1,12),r.Next(1,30));
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
    class DateGenerator : IRandomGenerator
    {
        Random r = new Random();
        public string Name { get; set; }

        public object Next()
        {
            return new DateTime(r.Next(2000,DateTime.Now.Year),r.Next(1,12),r.Next(1,30));
        }
    }
}
>>>>>>> 0c7653ce58b613fb77733e43695e44721ddfed95
