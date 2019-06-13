using System;
using System.Data.Common;

namespace TestConnect
{
    public class MeGonnaBeRandomConnectionStringBuilder : DbConnectionStringBuilder
    {
        
        public int RowCount
        {
            get
            {
                object count;
                int result;
                if (TryGetValue("RowCount", out count) && int.TryParse(count.ToString(), out result))
                {
                    return result;
                }
                return 0;
            }
            set
            {
                base["RowCount"] = value;
            }
        }

        public string[] Generators
        {
            get
            {
                object generators;
                
                if (TryGetValue("Generators", out generators))
                {
                    return generators.ToString().Split(',');
                }
                return new string[0];
            }

            set
            {
                base["Generators"] = String.Join(",", value);
            }
        }
    }
}
