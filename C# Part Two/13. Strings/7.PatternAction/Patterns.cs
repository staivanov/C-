using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PatternAction
{
    class Patterns
    {
        //Write a program that reads a string from the console (20 characters maximum) and if shorter complements it right with "*" to 20 characters.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter something to 20 symbols, but no more.");
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);

            if (input.Length <= 19)
            {
                for (int i = input.Length; i < 20; i++)
                {
                    sb.Append('*');

                }
                
                Console.WriteLine(sb);
            }
            else
            {
                Console.WriteLine("Your word is {0} lenght and don't match to condition", input.Length);
            }

        }
    }
}
