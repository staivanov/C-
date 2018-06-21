using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _12.TwoFileOperation
{
    class WordsOperation
    {
        //   A text file words.txt is given, containing a list of words, one per line. Write a program that deletes in the file text.txt all the words that occur in the other file. Catch and handle all possible exceptions.

        static void Main(string[] args)
        {
            try
            {
                string regex = @"\b(" + String.Join("|", File.ReadAllLines("words.txt")) + @")\b";
                using (StreamReader input = new StreamReader("input.txt"))
                using (StreamWriter output = new StreamWriter("output.txt"))

                    for (string line; (line = input.ReadLine()) != null; )
                    { 
                        output.WriteLine(Regex.Replace(line, regex, String.Empty));
                    }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            } 

            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
