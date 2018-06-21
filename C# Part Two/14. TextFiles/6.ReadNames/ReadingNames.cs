using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6.ReadNames
{
    class ReadingNames
    {
        //Write a program that reads a list of names from a text file, arranges them in alphabetical order, and writes them to another file. The lines are written one per row.

        static void Main(string[] args)
        {

            string input = "input.txt";
            string output = "output.txt";
            string line;
            StreamReader reader = new StreamReader(input);
            StreamWriter write = new StreamWriter(output);
            List<string> names = new List<string>();

            using (reader)
            {
                while ((line = reader.ReadLine()) != null)
                {
                    names.Add(line);
                }
            }

            names.Sort();

            using (write)
            {

                foreach (var name in names)
                {
                    write.WriteLine(name);
                }
            }

            Console.WriteLine("Result is: ");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
