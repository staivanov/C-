using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _8.WordReplace
{
    class replaceWord
    {
        //Write the previous program so that it changes only the whole words (not parts of the word).
        static void Main(string[] args)
        {
            string input = "input.txt";
            string output = "output.txt";
            StreamReader reader = new StreamReader(input);
            StreamWriter writer = new StreamWriter(output, false);
            string line;
            string pattern = @"\bstart\b";

            using (writer)
            {
                using (reader)
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(Regex.Replace(line,pattern, "finish"));
                        line = reader.ReadLine();
                    }
                }
            }

        }
    }
}
