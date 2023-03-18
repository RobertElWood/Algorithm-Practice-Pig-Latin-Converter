using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Pig_Latin_Translator
{
    internal class PigLatinConverter
    {
        public string ConvertToPigLatin(string input)
        {
            List<string> translation = new List<string>();

            //punctuation saver & capitalization here

            string inputLower = input.ToLower();

            string[] splitInput = inputLower.Split();

            foreach(string word in splitInput)
            {

                bool startsWithVowel = VowelChecker(word);

                bool hasSymbol = SymbolChecker(word);


                if (hasSymbol == true)
                {
                    translation.Add(word);
                }
                else if(startsWithVowel == true)
                {
                    translation.Add(word + "way");
                } 
                else
                {
                    int firstVowel = VowelPositionChecker(word);

                    string firstPart = word.Substring(firstVowel);
                    
                    string secondPart = word.Substring(0, firstVowel);

                    string fullWord = firstPart + secondPart + "ay";

                    translation.Add(fullWord);
                }
            }

            //re-insert punctuation and capitalization here.

            string outputString = String.Join(" ", translation);

            return outputString;
        }


        public bool VowelChecker(string word)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};

            if (vowels.Contains(word[0]) == true)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public int VowelPositionChecker(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            char firstVowel = word.FirstOrDefault(x => vowels.Contains(x) == true);

            int vowelIndex = word.IndexOf(firstVowel);

            return vowelIndex;
        }

        public bool SymbolChecker(string word)
        {

            bool isPresent = false;

            char[] symbols = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
            '-', '_', '[', ']', '{', '}','\"', '<', '>', '/', '\\',
            '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '=' };


            for (int i = 0; i < symbols.Length; i++)
            {
               if (word.Contains(symbols[i]) == true)
                {
                    isPresent = true;
                }
                
            }

            return isPresent;

        }

    }
}
