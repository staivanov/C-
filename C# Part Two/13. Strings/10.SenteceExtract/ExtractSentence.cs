using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _10.SenteceExtract
{
    class ExtractSentence
    {//Write a program that extracts from a text all sentences that contain a particular word. We accept that the sentences are separated from each other by the character "." and the words are separated from one another by a character which is not a letter. 
        static void Main(string[] args)
        {
            //Version 1
            //string str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            //string word = "in";
            //foreach (Match sentence in Regex.Matches(str, @"\s*([^\.]*\b" + word + @"\b.*?\.)"))
            //{
            //    Console.WriteLine(sentence.Groups[1]);
            //}

            //Version 2
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string word = "in";
            string[] sentences = text.Split('.');

            for (int i = 0; i < sentences.Length; i++)
            {
                if (Regex.Matches(sentences[i], @"\b" + word + @"\b").Count > 0)
                {
                    Console.WriteLine((sentences[i] + ".").Trim());
                }
            }


        }
    }
}
