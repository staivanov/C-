using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _15.TextFiles
{
    class PrintOdd
    {
        // Write a program that reads a text file and prints its odd lines on the console.
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("text.txt");
            int lineNum = 0;
            string line;

            using (reader)
            {
                while ((line = reader.ReadLine()) != null)
                {
                    lineNum++;
                    if (lineNum % 2 == 0)
                    {
                        Console.WriteLine(line);
                    }
                }
            }

        }
    }
}
