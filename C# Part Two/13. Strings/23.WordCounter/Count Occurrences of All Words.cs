using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.WordCounter
{
    class CounterWord
    {
        //Write a program that reads a string from the console and prints in alphabetical order all words from the input string and how many times each one of them occurs in the string
        static void Main(string[] args)
        {
            string text = "i will try to explain, what is dictionary and how to use dictionary.";
            string[] allWordsArr = text.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> rechnik = new Dictionary<string, int>();

            foreach (var word in allWordsArr)
            {
                if (rechnik.ContainsKey(word))
                {
                    rechnik[word] = rechnik[word] + 1;
                }
                else //(!rechnik.ContainsKey(word))
                {
                    rechnik.Add(word, 1);
                }
            }

            foreach (var word in rechnik)
            {
                Console.WriteLine("{0,-15} - {1} times", word.Key, word.Value);
            }

        }
    }
}
