using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _6.TextChangeInTags
{
    class ChangingText
    {
        //A text is given. Write a program that modifies the casing of letters to uppercase at all places in the text surrounded by <upcase> and </upcase> tags. Tags cannot be nested.
        public static string UpperCaseInTags(string text, string tag)
        {
            string TagStart = "<" + tag + ">";
            string TagEnd = "</" + tag + ">";

            while (text.IndexOf(TagStart) != -1)
            {
                int PosStart = text.IndexOf(TagStart);
                int PosEnd = text.IndexOf(TagEnd);
                string temp = text.Substring(PosStart + TagStart.Length, PosEnd - PosStart - TagStart.Length);
                text = text.Replace(TagStart + temp + TagEnd, temp.ToUpper());
            }

            return text;
        }

        static void Main(string[] args)
        {
            string text = "We are living in a <upcase> yellow submarine </upcase>. We don't have <upcase> anything </upcase> else.";
            //Version 1
            //Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper()));

            //Version 2
            string tag = "upcase";
            Console.WriteLine(UpperCaseInTags(text, tag));

        }
    }
}
