using System;
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
