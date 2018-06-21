using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HowOffen
{
    class HowOffenNumber
    {
        //Write a method that finds how many times certain number can be found in a given array. Write a program to test that the method works correctly.
        public static void CheckingNumber (int[] arr, int n) {
              int count = 0;
             for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    count++;
                }
            }
            Console.WriteLine(count);          
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 101, 5, 5, 5, 101, 1, 20, 18, 33, 64, 99 };
          
            Console.WriteLine("What number will check");
            int n = int.Parse(Console.ReadLine());
            CheckingNumber(arr, n);
           

        }
    }
}
