using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.SelectionSort
{
    class SSort
    {


        private static int[] FillingArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        private static void SortingNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                int temp = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        temp = arr[j];
                        arr[j] = arr[min];
                        arr[min] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];


            FillingArr(arr);
            SortingNumbers(arr);
            foreach (var num in arr)
            {
                Console.WriteLine(num);
            }


        }
    }
}
