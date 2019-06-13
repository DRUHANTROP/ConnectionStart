using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomicGenerator
{
    [Serializable]
   public class DateGenerator : IRandomGenerator
    {
        Random r = new Random();
        public string Name => "Date";

        public Type Type => typeof(DateTime);

        public string ColumnName { get; set; }

        public IRandomGenerator Create()
        {
            return new DateGenerator();
        }

        public object Next()
        {
            return new DateTime(r.Next(2000,DateTime.Now.Year),r.Next(1,12),r.Next(1,28));
        }
    }
}