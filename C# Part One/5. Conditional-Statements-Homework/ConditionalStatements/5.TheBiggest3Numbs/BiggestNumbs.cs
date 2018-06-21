using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.TheBiggest3Numbs
{
    class BiggestNumbs
    {
        //Write a program that finds the biggest of three numbers

        public static void MaxNumber(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Biggest number is {0}", arr.Max());
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Find the biggest numbers");
            int[] arr = new int[3];

            MaxNumber(arr);

        }
    }
}
