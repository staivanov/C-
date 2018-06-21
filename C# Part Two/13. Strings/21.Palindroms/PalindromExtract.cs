using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _21.Palindroms
{
    class PalindromExtract
    {
        //Write a program that extracts from a text all words which are palindromes, such as ABBA", "lamal", "exe".
        static void Main(string[] args)
        {
            string text = "Contrary to popular belief, Lorem Ipsum is ehe not simply random text. It has roots in a piece of, penep, classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia. rotor";
            char[] ch = new char[5] { ' ', ',', '.', '?', '!' };
            string[] newText = text.Split(ch, StringSplitOptions.RemoveEmptyEntries);
            List<string> str = new List<string>();
            byte min = 2;

            PalindromSearch(newText, str, min);
        }

        public static void PalindromSearch(string[] newText, List<string> str, byte min)
        {

            for (int i = 0; i < newText.Length; i++)
            {
                int iLength = newText[i].Length;
                string initial = "";
                string word = newText[i].ToString();
                //Check for palindrom

                for (int j = iLength - 1; j >= 0; j--)
                {
                    initial = initial + word[j];
                }

                if (initial == newText[i])
                {
                    if (initial.Length > min)
                    {
                        str.Add(initial);
                    }
                }
            }

            foreach (var s in str)
            {
                Console.WriteLine(s);
            }
        }
    }
}
