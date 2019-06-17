using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degenerators
{
    [Serializable]
   public class DateGenerator : IRandomGenerator
    {
        Random r = new Random();
        public string Name => "Date";

        public Type Type => typeof(DateTime);

        public string ColumnName { get; set; }

        public string Description => "Returns random date \nExample :" + Next();

        public IRandomGenerator Create()
        {
            return new DateGenerator();
        }

        public object Next()
        {
            int month,day,year;
            year = r.Next(1990, DateTime.Now.Year);
            month = r.Next(1, 13);
            day = r.Next(1, DateTime.DaysInMonth(year, month)+1);
            return new DateTime(year,month,day);
        }
    }
}