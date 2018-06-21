using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.NumbersNotDividet
{
    class ThreeAndSeven
    {
        //Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
        static void Main(string[] args)
        {
            Console.WriteLine("From 1 to N");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if ((((i % 3) != 0) && ((i % 7) != 0)))
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
