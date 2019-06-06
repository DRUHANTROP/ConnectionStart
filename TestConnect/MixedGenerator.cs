<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomicGenerator
{
    [Serializable]
    class MixedGenerator : IRandomGenerator
    {
        IRandomGenerator[] generators = { new IntGenerator(), new FirstNameGenerator(), new LastNameGenerator(), new FullNameGenerator(), new DateGenerator() };
        private Random r = new Random();

        public string Name { get; set; }

        public object Next()
        {
            IRandomGenerator generator = generators[r.Next(generators.Length)];
            return generator.Next();
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
    class MixedGenerator : IRandomGenerator
    {
        IRandomGenerator[] generators = { new IntGenerator(), new FirstNameGenerator(), new LastNameGenerator(), new FullNameGenerator(), new DateGenerator() };
        private Random r = new Random();

        public string Name { get; set; }

        public object Next()
        {
            IRandomGenerator generator = generators[r.Next(generators.Length)];
            return generator.Next();
        }

    }
}
>>>>>>> 0c7653ce58b613fb77733e43695e44721ddfed95
