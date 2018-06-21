using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Arrays
{
    class From1toN
    {
        //Write a program that prints all the numbers from 1 to N.

        static void Main(string[] args)
        {
            Console.WriteLine("From 1 to N");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }

        }
    }
}
