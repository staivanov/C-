using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _24.SequenceString
{
    class StringSequence
    {
        //Write a program that reads a string from the console and replaces every sequence of identical letters in it with a single letter (the repeating letter). Example: "aaaaabbbbbcdddeeeedssaa" à "abcdedsa".
        static void Main(string[] args)
        {
            Console.WriteLine("Version 1");
            //Regular expressions
            string text = "aaaaabbbbbcdddeeeedsssaaa";
            Console.WriteLine(Regex.Replace(text, @"(\w)\1+", "$1"));

            //Version 2
            StringBuilder sb = new StringBuilder();
            sb.Append(text[0]);

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != text[i - 1])
                {
                    sb.Append(text[i]);
                }
            }

            Console.WriteLine("Version 2");
            Console.WriteLine(sb);

        }
    }
}
