using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomicGenerator
{
    [Serializable]
    public class FullNameGenerator : IRandomGenerator
    {
        string fullName;
        FirstNameGenerator fng = new FirstNameGenerator();
        LastNameGenerator lng = new LastNameGenerator();

        public string Name => "Full name";

        public Type Type => typeof(string);

        public string ColumnName { get; set; }

        public IRandomGenerator Create()
        {
            return new FullNameGenerator();
        }

        public object Next()
        {
            fullName = fng.Next() + " " + lng.Next();
            return fullName;
        }
    }
}