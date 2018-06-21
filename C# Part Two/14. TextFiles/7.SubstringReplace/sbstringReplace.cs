using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _7.SubstringReplace
{
    class sbstringReplace
    {
        //  Write a program that replaces every occurrence of the substring "start" with "finish" in a text file. Can you rewrite the program to replace whole words only? Does the program work for large files.

        static void Main()
        {
            string input = "input.txt";
            string output = "output.txt";
            StreamReader reader = new StreamReader(input);
            StreamWriter writer = new StreamWriter(output, false);
            string line;
            string pattern = "finish";

            using (writer)
            {
                using (reader)
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line.Replace("start", pattern));
                        line = reader.ReadLine();
                    }
                }
            }

        }
    }
}
