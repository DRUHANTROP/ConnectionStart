using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConnect;

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