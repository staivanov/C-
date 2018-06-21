using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace _9.ReadFullPath
{
    class PathReading
    {
        //Write a method that takes as a parameter the name of a text file, reads the file and returns its content as string. What should the method do if and exception is thrown?

        static void Main()
        {
            try
            {
                Encoding encode = Encoding.GetEncoding("Windows-1251");
                string input = "input.txt";
                StreamReader reader = new StreamReader(input, encode);
                string line = reader.ReadLine();
                StringBuilder sb = new StringBuilder();

                using (reader)
                {
                    while (line != null)
                    {
                        sb.Append(line);
                        line = reader.ReadLine();
                    }
                }

                Console.WriteLine(sb);
            }

            catch (DirectoryNotFoundException dnf)
            {
                Console.WriteLine(dnf.Message);
            }

            catch (FileNotFoundException ff )
            {
                Console.WriteLine(ff.Message);
            }

            catch (FileLoadException fle)
            {
                Console.WriteLine(fle.Message);
            }

        }
    }
}
