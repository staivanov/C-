using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MinMaxSum
{
    class MaxMinSum
    {
        //Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            Console.WriteLine("min= {0}", numbers.Min());
            Console.WriteLine("max= {0}", numbers.Max());
            Console.WriteLine("sum= {0}", sum);
            Console.WriteLine("avg= {0:F2}", (double)sum/n);
          //  Console.WriteLine("avg= {0}", avg);
            
        }
    }
}
