using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _26.RemoveTags
{
    class ExtractTextFromURL
    {
        //Write a program that extracts all the text without any tags and attribute values from an HTML document.
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\..\text.html");

            using (reader)
            {
                string line = string.Empty;
                MatchCollection matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");
                while ((line = reader.ReadLine()) != null)
                {
                    matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");

                    foreach (var word in matchProtocolAndSiteName)
                        Console.WriteLine(word);
                }
            }

        }
    }
}
