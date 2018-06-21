using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _11.DelAllWords
{
    class DeleteAllWrods
    {
        //Write a program that deletes all words that begin with the word "test". The words will contain only the following chars: 0…9, a…z, A…Z.
        static void Main()
        {
            string text = "text.txt";
            string output = "output.txt";
            StreamReader sr = new StreamReader(text);
            StreamWriter sw = new StreamWriter(output, false);
            string line;
            string pattern = @"\btest+?";

            using (sw)
            {
                using (sr)
                {
                    while ((line =  sr.ReadLine()) != null)
                    {
                       
                        sw.WriteLine(Regex.Replace(line, pattern, " "));
                        line = sr.ReadLine();
                    }
                }
            }

        }
    }
}
