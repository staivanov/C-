using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RandomNumbers
{
    class RandNumbers
    {
        //Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max]. 

        static void Main()
        {
            Console.WriteLine("We have min, max and N for numbers to print");
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("min= ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("max= ");
            int max = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int j = 0; j < n; j++)
            {
                Console.Write((rnd.Next(min, max)) + " ");
            }
            Console.WriteLine();

        }
    }
}
