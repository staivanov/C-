using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrintWordFromNames
{
    class NameWordPrint
    {
        static void Main(string[] args)
        {

            char[] alphabet = new char[27];
            int initializizationOfArray = 97; 

            
            for (int i = 1; i < 27; i++)
            {
                alphabet[i] = (char)initializizationOfArray;
                initializizationOfArray++;
            }

            Console.WriteLine("Please enter a word with capital letters:");

            string word = Console.ReadLine().ToLower();
          
            foreach (char letter in word)
            {
                for (int i = 1; i < 27; i++)
                {
                    if (letter == alphabet[i])
                    {
                        Console.WriteLine("Index of letter is {0} is {1}", letter, i);
                        break;
                    }
                }
            }

        }
    }
}
