using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _4.RowMatch
{
    class RowMatching
    {
        //Write a program that compares two text files with the same number of rows line by line and prints the number of equal and the number of different lines.

        static void Main(string[] args)
        {
            string path = "text.txt";
            string path2 = "text2.txt";
            StreamReader readerOne = new StreamReader(path);
            StreamReader readerTwo = new StreamReader(path2);
            string line;
            string line2;
            int equal = 0;
            int diffrent = 0;

            try
            {
                using (readerOne)
                {
                    using (readerTwo)
                    {
                        while (((line = readerOne.ReadLine()) != null) && ((line2 = readerTwo.ReadLine()) != null))
                        {
                            if (line == line2)
                            {
                                equal++;
                            }
                            else
                            {
                                diffrent++;
                            }
                        }
                    }
                    Console.WriteLine("Different lines are {0}", diffrent);
                    Console.WriteLine("Equal lines are {0}", equal);
                }
            }

            catch (FileNotFoundException e)
            {
                Console.Error.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the file path.");
            }
            catch (IOException e)
            {
                Console.Error.WriteLine(e.Message);
            }

        }
    }
}
