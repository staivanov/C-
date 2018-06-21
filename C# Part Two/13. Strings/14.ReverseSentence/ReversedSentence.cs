using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _14.ReverseSentence
{
    class ReversedSentence
    {
        //Write a program that reverses the words in a given sentence without changing punctuation and spaces. For example: "C# is not C++ and PHP is not Delphi" à "Delphi not is PHP and C++ not is C#".
        static void Main(string[] args)
        {

            //Version 1
            //string str = "C# is not C++, not PHP and not Delphi! Test 1, 2,3";
            //string regex = @"\s+|,\s*|\.\s*|!\s*|$";
            //var words = new Stack<string>();

            //foreach (var word in Regex.Split(str, regex))
            //{
            //    if (!String.IsNullOrEmpty(word)) words.Push(word);
            //}
            //foreach (var separator in Regex.Matches(str, regex))
            //{
            //    Console.Write(words.Pop() + separator);
            //}
            //Console.WriteLine();


            string str = "C# is not C++, not, PHP .and not Delphi! Test 1, 2,3.";
            List<char> listLetters = new List<char>();

            for (char i = 'a'; i <= 'z'; i++) listLetters.Add(i);
            for (char i = 'A'; i <= 'Z'; i++) listLetters.Add(i);
            for (char i = '0'; i <= '9'; i++) listLetters.Add(i);

            listLetters.Add('@'); listLetters.Add('#'); listLetters.Add('$');
            listLetters.Add('%'); listLetters.Add('&'); listLetters.Add('&');
            listLetters.Add('*'); listLetters.Add('+'); listLetters.Add('-');
            listLetters.Add('^'); listLetters.Add('~');

            string[] strWords = str.Split(new char[] { '.', ',', '!', '?', ':', ';', '"', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] signs = str.Split(listLetters.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(strWords);
            StringBuilder strWordsReversed = new StringBuilder();

            for (int i = 0; i < signs.Length; i++)
            {
                strWordsReversed.Append(strWords[i]);
                strWordsReversed.Append(signs[i]);
            }
            Console.WriteLine(strWordsReversed.ToString());

        }
    }
}
