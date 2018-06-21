using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3.RowsAdd
{
    class AddingRows
    {
        // Write a program that reads the contents of a text file and inserts the line numbers at the beginning of each line, then rewrites the file contents.

        static void Main(string[] args)
        {
            var sr = new StreamReader("input.txt", Encoding.Default);
            var sw = new StreamWriter("output.txt");
            int count = 0;
            string line;

            using (sw)
            {
                while((line = sr.ReadLine()) != null)
                {
                    sw.Write("Line {0}: ",count);
                    sw.WriteLine(line);
                    count++;
                }
            }

            Console.WriteLine("Build succeeded");
            
        }
    }
}
