using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ReverseNumbers
{
    class ReverseNumbs
    {
        // Write a method that prints the digits of a given decimal number in a reversed order. For example 256, must be printed as 652.

        public static void ReversString(string n)
        {
            for (int i = n.Length - 1; i >= 0; i--)
            {
                Console.Write(n[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number below");
            string n = Console.ReadLine();
            ReversString(n);
            Console.WriteLine();
        }
    }
}
