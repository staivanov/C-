using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.From1toN
{
    class Program
    {
        //Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line. Note that you may need to use a for-loop. 

        public static void PrintNumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("This program print numbs from  1 to N");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            PrintNumbers(n);

        }
    }
}
