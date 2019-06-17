using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Degenerators
{
    [Serializable]
    public class LastNameGenerator : IRandomGenerator
    {
        private Random r = new Random(DateTime.Now.Millisecond);
        private string[] syllable = { "ma", "lee", "cru", "ste", "ve", "la", "le", "si", "va", "mo", "mi", "lo", "su", "sa", "no", "ge", "tri", "co", "de", "da", "cro", "wo", "wi", "lli", "am" };
        private string lastName;

        public string Name => "Last name";

        public string ColumnName { get; set; }

        public Type Type => typeof(string);

        public string Description => "Returns randomly generated last name \nExample :" + Next();

        public IRandomGenerator Create()
        {
            return new LastNameGenerator();
        }

        public object Next()
        {
            lastName = "";
            for (int i = 0; i < r.Next(5) + 2; i++)
            {
                lastName += syllable[r.Next(syllable.Length)];
            }
            //Преобразует первый символ получившейся строки в верхний регистр 
            lastName = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(lastName);

            return lastName;
        }
    }
}