using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SumOfNumbs
{
    class SumNumbs
    {
        //Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop

        public static void SumN(int n, int[] arr){

            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Number {0} is ", i+1);
                arr[i] = int.Parse(Console.ReadLine());
                result += arr[i];
            }

            Console.WriteLine("Sum is: " + result);
        }

        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            SumN(n, arr);

        }
    }
}
