using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MostOftenElement
{
    class OftenElement
    {
        private static void CountingNumberHowOften(int[] arr, ref int index, ref int bestIndex, ref int count, ref int bestCount)
        {
            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] == arr[i - 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestIndex = index;
                    }
                }

                else if (arr[i] != arr[i - 1])
                {
                    index = i;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers will enter?");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int index = 0;
            int bestIndex = 0;
            int count = 1;
            int bestCount = 0;

            for (int q = 0; q < arr.Length; q++)
            {
                arr[q] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            CountingNumberHowOften(arr, ref index, ref bestIndex, ref count, ref bestCount);

            Console.WriteLine();
            Console.WriteLine("Most often number is: " + arr[bestIndex]);
            Console.WriteLine("Number used " + bestCount);

        }
    }
}
