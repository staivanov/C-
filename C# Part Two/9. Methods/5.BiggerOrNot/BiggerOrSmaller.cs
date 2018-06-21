using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BiggerOrNot
{
    class BiggerOrSmaller
    {
       // Write a method that checks whether an element, from a certain position in an array is greater than its two neighbors. Test whether the method works correctly.
        public static void LeftCheck(int[] arr, int n)
        {
            if (arr[n] > arr[n - 1])
            {
                Console.WriteLine("Number {0} at index {1} is bigger from number {2} at index {3}", arr[n], n, arr[n - 1], n - 1);
            }
            else if (arr[n] < arr[n - 1])
            {
                Console.WriteLine("Number {0} at index {1} is smaller from number {2} at index {3}", arr[n], n, arr[n - 1], n - 1);
            }
            else
            {
                Console.WriteLine("Elements at index {0} and index {1} are equal -> {2}", n, n - 1, arr[n]);
            }
        }

        public static void RightCheck(int[] arr, int n)
        {
            if (arr[n] > arr[n + 1])
            {
                Console.WriteLine("Number {0} at index {1} is bigger from number {2} at index {3}", arr[n], n, arr[n + 1], n + 1);
            }
            else if (arr[n] < arr[n + 1])
            {
                Console.WriteLine("Number {0} at index {1} is smaller from number {2} at index {3}", arr[n], n, arr[n + 1], n + 1);
            }
            else
            {
                Console.WriteLine("Elements at index {0} and index {1} are equal -> {2}", n, n + 1, arr[n]);
            }
        }

        public static void LeftEndCheck(int[] arr, int n)
        {
            if (arr[0] > arr[1])
            {
                Console.WriteLine("Number {0} at index {1} is bigger from number {2} at index {3}", arr[0], n, arr[1], 1);
            }
            else if (arr[0] < arr[1])
            {
                Console.WriteLine("Number {0} at index {1} is smaller from number {2} at index {3}", arr[0], n, arr[1], 1);
            }
            else
            {
                Console.WriteLine("Elements at index {0} are equal -> {1}", n, arr[1]);
            }
        }

        public static void RightEndCheck(int[] arr, int n)
        {
            if (arr[n] > arr[n - 1])
            {
                Console.WriteLine("Number {0} at index {1} is bigger from number {2} at index {3}", arr[n], n, arr[n - 1], n - 1);
            }
            else if (arr[n] < arr[n - 1])
            {
                Console.WriteLine("Number {0} at index {1} is smaller from number {2} at index {3}", arr[n], n, arr[n - 1], n - 1);
            }
            else
            {
                Console.WriteLine("Elements at index {0} and index {1} are equal -> {2}", n, n - 1, arr[n]);
            }
        }

        public static void CheckingNumber(int[] arr, int n)
        {
            if (arr[n] == arr[(arr.Length - 1)])
            {
                RightEndCheck(arr, n);
            }
            else if (arr[n] == arr[0])
            {
                LeftEndCheck(arr, n);
            }
            else
            {
                LeftCheck(arr, n);
                RightCheck(arr, n);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 5, 101, 1, 5, 8, 5, 5, 99 };
            Console.WriteLine("Indeox of element to check");
            int n = int.Parse(Console.ReadLine());
            CheckingNumber(arr, n);
        }

    }
}
