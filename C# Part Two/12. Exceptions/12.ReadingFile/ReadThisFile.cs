using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _12.ReadingFile
{
    class ReadThisFile
    {
        //ReadAllText(…) method. Make sure all possible exceptions will be caught and a user-friendly message will be printed on the console.
        // Write a program that gets from the user the full path to a file (for example C:\Windows\win.ini), reads the content of the file and prints it to the console. Find in MSDN how to us the   System.IO.File.

        static void Main(string[] args)
        {
            try
            {
                string path = "output.txt";
                string readText = "";

                if (File.Exists(path))
                {
                    readText = File.ReadAllText(path);
                }

                Console.WriteLine(readText);                   
            }

            catch (ArgumentException)
            {
                Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters");
            }

            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length");
            }

            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid");
            }

            catch (IOException)
            {
                Console.WriteLine("I/O error occurred while opening the file");
            }

            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("The caller does not have the required permission");
            }

            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in invalid format");
            }

        }
    }
}
