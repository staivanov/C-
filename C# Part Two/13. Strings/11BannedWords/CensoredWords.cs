using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _11BannedWords
{
    class CensoredWords
    {
        // A string is given, composed of several "forbidden" words separated by commas. Also a text is given, containing those words. Write a program that replaces the forbidden words with asterisks. Sample text:
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.";
            string banned = "C#,CLR,Microsoft";
            char[] chars = new char[] { ' ',',', '.' };
            string[] words = banned.Split(chars);
            string[] n = new string[3] { "**", "***", "******" };
            StringBuilder sb = new StringBuilder(text);
           
            for (int i = 0; i < words.Length; i++)
            {
                sb.Replace(words[i], n[i]);               
            }

            Console.WriteLine(text);
            Console.WriteLine("---Censored text---");
            Console.WriteLine(sb);
        }
    }
}
