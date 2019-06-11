using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConnect;

namespace RandomicGenerator
{
    [Serializable]
    public class FirstNameGenerator : IRandomGenerator
    {
        private Random rnd = new Random(DateTime.Now.Millisecond+1337);
        private string[] names = {"Mike","Rose","John","Andrew","Danny","Duke","James","Jotaro","Mitchell","Gordon","Kate","Bruce","Mapat","Lisa","Logan","Milena", };

        public string Name { get; set; }

        public object Next()
        {
            return names[rnd.Next(names.Length)];
        }
    }
}