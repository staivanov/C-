using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Calculation
{
    class CalculateExpression
    {
        //Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. Print the result with 5 digits after the decimal point.

        static void Main(string[] args)
        {
            Console.WriteLine("1 + 1!/X + 2!/X2 + … + N!/XN");
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x= ");
            int x = int.Parse(Console.ReadLine());

        }
    }
}
