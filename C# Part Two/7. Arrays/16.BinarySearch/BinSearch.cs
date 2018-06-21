using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.BinarySearch
{
    //Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

    class BinSearch
    {
        static void Main()
        {
            Console.WriteLine("How long will be your array?");
            int n = int.Parse(Console.ReadLine());
            int[] numbs = new int[n];

            //Filling array and sort array, because binary search rulles
            FillingArray(numbs);
            Array.Sort(numbs);

            //Entering key number
            Console.WriteLine("Enter searching number.");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine(BinarySearch(numbs, key));

        }

        private static void FillingArray(int[] numbs)
        {
            for (int i = 0; i < numbs.Length; i++)
            {
                Console.Write("Index {0} = ", i);
                numbs[i] = int.Parse(Console.ReadLine());
            }
        }

        public static int BinarySearch(int[] numbs, int key)
        {
            int low = 0;
            int high = numbs.Length - 1;
            

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (numbs[mid] < key)
                {
                    low = mid + 1;
                    continue;
                }
                else if (numbs[mid] > key)
                {
                    high = mid - 1;
                    continue;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
