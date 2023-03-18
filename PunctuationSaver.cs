using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pig_Latin_Translator
{
    internal class PunctuationSaver
    {
        public List<int> SavePunctuation(string input)
        {
            List<int> result = new List<int>();

            string[] inputArr = input.Split();

            char[] punctuation = { ',', '.', ';', ':', '!', '?', '\''};

            foreach(string word in inputArr)
            {
               

                List<char> chars = word.Where(x=> punctuation.Contains(x) == true).ToList();

                foreach (char c in chars)
                {
                    int punctIndex = word.IndexOf(c);


                }

            }

        }

        public int[] SaveCapitalization(string input)
        {

        }
    }
}
