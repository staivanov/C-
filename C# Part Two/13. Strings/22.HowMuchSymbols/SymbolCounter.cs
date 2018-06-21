using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.HowMuchSymbols
{
    class SymbolCounter
    {
        //Write a program that reads a string from the console and prints in alphabetical order all letters from the input string and how many times each one of them occurs in the string.
        static void Main(string[] args)
        {
            var text = "aaaaa bcd eeeff";

            char[] letters = new char[65536];

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    letters[text[i]]++;
                }
            }

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] > 0 && char.IsLetter((char)i))
                {
                    Console.WriteLine("{0} {1}", (char)i, (int)letters[i]);
                }
            }

        }
    }
}
