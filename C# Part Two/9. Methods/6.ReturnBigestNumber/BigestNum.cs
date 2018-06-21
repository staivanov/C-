using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ReturnBigestNumber
{
    class BigestNum
    {
        //Write a method that returns the position of the first occurrence of an element from an array, such that it is greater than its two neighbors simultaneously. Otherwise the result must be -1

        public static int Checker(int[] arr)
        {
            int index = 0;
            for (int i = 1; i < arr.Length - 1; i++)
			{
                
                if ((arr[i] > arr[i - 1]) && (arr[i] > arr[i + 1]))
                {
                    index = i;
                }
                else
                {
                    index = -1;
                }
            }
            return index;
        }


        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(Checker(arr));
        }
    }
}
