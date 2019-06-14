using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Degenerators
{
    [Serializable]
    public class LoremIpsumGenerator : IRandomGenerator
    {
        private Random r = new Random();
        public string ColumnName { get; set; }

        public string Name => "Lorem Ipsum";

        public Type Type => typeof(string);

        public IRandomGenerator Create()
        {
            return new LoremIpsumGenerator();
        }

        public object Next()
        {
            List<string> lipsum = new List<string>();
            string result = "";
            using (StreamReader sr = new StreamReader("../../../Degenerators/LoremIpsum.txt"))
            {
                while (!sr.EndOfStream)
                    lipsum.Add(sr.ReadLine());
            }
            /// Reshuffle words list
            for (int i = 0; i < lipsum.Count; i++)
            {
                string tmp = lipsum[i];
                lipsum.RemoveAt(i);
                lipsum.Insert(r.Next(lipsum.Count), tmp);
            }
            result += Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(lipsum[0]) + " ";
            foreach (string word in lipsum)
            {
                int diceRoll = r.Next(100);
                if (diceRoll <= 20 && diceRoll > 3) result += word + " ";
                else if (diceRoll <= 3) result += word + ", ";
            }
            result += lipsum[lipsum.Count-1]+".";
            return result;
        }
    }
}
