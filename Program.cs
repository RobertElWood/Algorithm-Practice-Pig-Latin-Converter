using System.Security.Cryptography.X509Certificates;

namespace Pig_Latin_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pig Latin: String Manipulation Practice

            //Goal =  create an application that can translate a sentence in natural English into a silly, pig-latin sentence.

            //STEPS:
            //1) Take in user input as a string.
            //2) Split that string into a list of words along natural language breaks (spaces)
            //3) Store positional data of capital letters present within the string in an array.
            //4) Store positional data of punctuation in the overall array.
            //   -Note: if punctuation other than apostrophes present WITHIN A WORD, don't translate that word.
            //5) 

            var goOn = true;

            PigLatinConverter p = new PigLatinConverter();

            PunctuationSaver ps = new PunctuationSaver();

            while (goOn == true)
            {

                Console.WriteLine("\nPlease enter a sentence that you'd like translated to Pig Latin: \n");

                string input = Console.ReadLine();

                string output = p.ConvertToPigLatin(input);

                Console.WriteLine("\n\n" + "Your translated Sentence is:\n" + output + "\n\n");

                goOn = AskToGoOn();
            }

        }

        public static bool AskToGoOn()
        {
            Console.WriteLine("Would you like to translate another sentence? Please enter yes (Y) or no (N).\n");

            string input = Console.ReadLine().ToLower();

            if (input == "Y" || input == "y" || input == "yes")
            {
                Console.WriteLine("\nAlright! Let's translate another sentence!");
                return true;
            }
            else if (input == "N" || input == "n" || input == "no")
            {
                Console.WriteLine("\nGoodbye!\n");
                return false;
            }
            else
            {
                Console.WriteLine("\nI'm sorry. I didn't understand that. Please try again.\n");
                return AskToGoOn();
            }
        }
    }
}