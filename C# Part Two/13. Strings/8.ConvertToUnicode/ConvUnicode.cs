using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.ConvertToUnicode
{
    class ConvUnicode
    {
        //Write a program that converts a given string into the form of array of Unicode escape sequences in the format used in the C# language. Sample input: "Test". Result: "\u0054\u0065\u0073\u0074".
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word to convert in Unicode");
            Console.Write("word: ");
            string word = Console.ReadLine();       
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                sb.Append("\\u" + ((int)word[i]).ToString("X4"));          
            }

            Console.WriteLine(sb);

        }
    }
}
