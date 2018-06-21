using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _9.OddLineDelete
{
    class OddDel
    {
        //Write a program that deletes all the odd lines of a text file.
        static void Main(string[] args)
        {
            string input = "input.txt";
            string output = "output.txt";
            StreamReader sr = new StreamReader(input);
            StreamWriter sw = new StreamWriter(output);
            string line = sr.ReadLine();
            int count = 0;

            using (sr)
            {
                using (sw)
                {
                    while (line != null)
                    {
                        count++;
                        if (count % 2 != 0)
                        {
                            sw.WriteLine(line);
                        }
                        line = sr.ReadLine();
                    }
                }
            }







        }
    }
}
