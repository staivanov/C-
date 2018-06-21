using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.CommaWords
{
    class PrintWordsCommas
    {
        //Write a program that reads a list of words separated by commas from the console and prints them in alphabetical order (after sorting).
        static void Main(string[] args)
        {
            string words = "smeshka, hudojnik, xFactor, DMX, Superman, YOLO, WTF, hey";
            char[] ch = new char[2] { ' ', ',' };
            string[] wordsWithoutComma = words.Split(ch, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(wordsWithoutComma);

            foreach (string w in wordsWithoutComma)
            {
                Console.WriteLine(w);
            }

        }
    }
}
