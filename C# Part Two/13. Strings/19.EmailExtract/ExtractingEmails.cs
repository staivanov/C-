using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _19.EmailExtract
{
    class ExtractingEmails
    {
        //Write a program that extracts all e-mail addresses from a text. These are all substrings that are limited on both sides by text end or separator between words and match the shape <sender>@<host>…<domain>. Sample text:
        static void Main(string[] args)
        {
            //Valid email is: <sender>@<host>…<domain>. -> koki4a@abv.bg
            //Program dont match full email specifiaction.

            string text = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
            string pattern = @"\b[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}\b";
            MatchCollection emails = Regex.Matches(text, pattern);

            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }

        }
    }
}
