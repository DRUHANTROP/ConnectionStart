using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degenerators
{
    [Serializable]
    public class FirstNameGenerator : IRandomGenerator
    {
        private Random rnd = new Random(DateTime.Now.Millisecond+1337);
        private string[] names = {"Mike","Rose","John","Andrew","Danny","Duke","James","Jotaro","Mitchell","Gordon","Kate","Bruce","Mapat","Lisa","Logan","Milena", };

        public string Name => "First name";

        public Type Type => typeof(string);

        public string ColumnName { get; set; }

        public string Description => "Returns random name from list \nExample :"+Next();

        public IRandomGenerator Create()
        {
            return new FirstNameGenerator();
        }

        public object Next()
        {
            return names[rnd.Next(names.Length)];
        }
    }
}