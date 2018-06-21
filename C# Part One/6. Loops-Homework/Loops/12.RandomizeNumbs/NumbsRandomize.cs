using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace _12.RandomizeNumbs
{
    class NumbsRandomize
    {
        //Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. 

        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 1; i < n + 1; i++)
            {
                Console.Write((rnd.Next(1, n + 1)) + " ");
            }
            Console.WriteLine();

        }
    }
}
