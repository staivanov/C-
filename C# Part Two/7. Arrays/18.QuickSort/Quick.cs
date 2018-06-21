using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.QuickSort
{
    class Quick
    {
        static void Swap(int[] arr, int i, int j)
        {
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }
        static int Partition(int[] arr, int l, int r)
        {
            Swap(arr, new Random().Next(l, r + 1), r);
            int pivot = arr[r], i = l;
            for (int j = l; j < r; j++) if (arr[j] <= pivot) Swap(arr, i++, j);
            Swap(arr, i, r);
            return i;
        }
        static void QuickSort(int[] arr, int l, int r)
        {
            if (l >= r) return;
            int q = Partition(arr, l, r);
            QuickSort(arr, l, q - 1);
            QuickSort(arr, q + 1, r);
        }


        static void Main(string[] args)
        {
            int[] arr = { -1, 2, -3, 4, -5, 6, -7 };
            QuickSort(arr, 0, arr.Length - 1);
            foreach (int item in arr) Console.WriteLine(item);
        }
    }
}
