using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.HalfSum
{
    class SumHalf
    {
        //Nakov likes numbers. He often plays with their sums and differences. Once he invented the following game. He takes a sequence of numbers, splits them into two subsequences with the same number of elements and sums the left and right sub-sums, and compares the sub-sums. Please help him.
//You are given a number n and 2*n numbers. Write a program to check whether the sum of the first n numbers is equal to the sum of the second n numbers. Print as result “Yes” or “No”. In case of yes, print also the sum. In case of no, print also the difference between the left and the right sums.


        static void Main()
        {


            //int n = int.Parse(Console.ReadLine());
            //if (n < 500)
            //{
            //    int result = 0;
            //    int resultTwo = 0;
            //    int D;
            //    int a = 500000;
            //    int b = - 500000;

            //    //Sub-sequence one
            //    int[] arr1 = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        arr1[i] = int.Parse(Console.ReadLine());
            //       if (b <= arr1[i] & arr1[i] <= a) {

            //           continue;
            //       }
            //       else
            //       {
            //           break;
            //       }
               
            //    }

            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        result += arr1[i];
            //    }


            //    //Sub-sequence two
            //    int[] arr2 = new int[n];
            //    for (int j = 0; j < n; j++)
            //    {
            //        arr2[j] = int.Parse(Console.ReadLine());
            //        if (b <= arr2[j] & arr1[j] <= a)
            //        {

            //            continue;
            //        }
            //        else
            //        {
            //            break;
            //        }
                    
            //    }

            //    for (int q = 0; q < arr1.Length; q++)
            //    {
            //        resultTwo += arr2[q];
            //    }

            //    //Compare
            //    D = result - resultTwo;
            //    if (result == resultTwo)
            //    {
            //        int S = result;
            //        Console.WriteLine("Yes, sum={0}", S);
            //    }
            //    if (result != resultTwo)
            //    {
            //        Console.WriteLine("No, diff={0}", D);
            //    }
            //}


            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                sum1 = sum1 + element;
            }
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                sum2 = sum2 + element;
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum=" + sum1);
            }
            else
            {
                int diff = Math.Abs(sum1 - sum2);
                Console.WriteLine("No, diff=" + diff);
            }

        }
    }
}