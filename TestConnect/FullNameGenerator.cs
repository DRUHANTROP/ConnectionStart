<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomicGenerator
{
    [Serializable]
    class FullNameGenerator : IRandomGenerator
    {
        string fullName;
        FirstNameGenerator fng = new FirstNameGenerator();
        LastNameGenerator lng = new LastNameGenerator();

        public string Name { get; set; }

        public object Next()
        {
            fullName = fng.Next() + " " + lng.Next();
            return fullName;
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
    class FullNameGenerator : IRandomGenerator
    {
        string fullName;
        FirstNameGenerator fng = new FirstNameGenerator();
        LastNameGenerator lng = new LastNameGenerator();

        public string Name { get; set; }

        public object Next()
        {
            fullName = fng.Next() + " " + lng.Next();
            return fullName;
        }
    }
}
>>>>>>> 0c7653ce58b613fb77733e43695e44721ddfed95
