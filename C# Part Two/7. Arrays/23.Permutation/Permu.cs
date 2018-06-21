using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Permutation
{
    //Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example: n = 3 -> {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
    class Permu
    {
        static void Check(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + 1 + (i == arr.Length - 1 ? "\n" : " "));
            }
        }

        static void Permutation(int[] arr, bool[] used, int i)
        {
            if (i == arr.Length)
            {
                Check(arr);
                return;
            }

            for (int j = 0; j < arr.Length; j++)
            {
                if (used[j]) continue;
                arr[i] = j;
                used[j] = true;
                Permutation(arr, used, i + 1);
                used[j] = false;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[int.Parse(Console.ReadLine())];
            bool[] used = new bool[arr.Length];
            Permutation(arr, used, 0);

        }
    }
}
