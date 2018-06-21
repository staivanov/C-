using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BiggestNumbsFive
{
    class Biggest5Numbs
    {
        //Write a program that finds the biggest of five numbers by using only five if statements. 

        static void Main(string[] args)
        {
            Console.WriteLine("Find the biggest numbers");

            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Biggest number is {0}", arr.Max());

        }
    }
}
