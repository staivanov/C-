using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SumOfFiveNumbs
{
    class FiveNUmbs
    {
        //Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 

        public static void Sum(int a, int b, int c, int d, int e)
        {
            Console.WriteLine("Sum is {0}", a + b + c + d + e);
        }

        static void Main()
        {
            //Enter in single line 5 variables and sum it
            Console.WriteLine("Enter five numbs in sigle line separated by space");
            string[] tokens = Console.ReadLine().Split();
            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);
            int c = int.Parse(tokens[2]);
            int d = int.Parse(tokens[3]);
            int e = int.Parse(tokens[4]);

            Sum(a, b, c, d, e);

        }

    }
}
