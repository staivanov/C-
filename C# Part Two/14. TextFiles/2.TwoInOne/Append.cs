using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2.TwoInOne
{
    class Append
    {
        //Write a program that joins two text files and records the results in a third file.

        static void Main(string[] args)
        {
            Encoding encoding = Encoding.GetEncoding(1251);
            StreamReader sr = new StreamReader("text1.txt", encoding, false);
            StreamReader sr2 = new StreamReader("text2.txt", encoding, false);
            StreamWriter sw = new StreamWriter("text3.txt");
            string line;

            using (sw)
            {
                while ((line = sr.ReadLine()) != null)
                {
                    sw.WriteLine(line);
                }

                while ((line = sr2.ReadLine()) != null)
                {
                    sw.WriteLine(line);
                }

                Console.WriteLine("Process succeded");
            }

        }
    }
}
