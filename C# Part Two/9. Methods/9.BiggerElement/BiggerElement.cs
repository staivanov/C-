using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.BiggerElement
{
    class BiggerElement
    {
        //Write a method that finds the biggest element of an array. Use that method to implement sorting in descending order.

        static void Main(string[] args)
        {
            Console.WriteLine("How much numbers will enter?");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            FillingArrNumbers(numbers);
            NumberSortingMin(numbers);
            NumberSortingMax(numbers);
            Average(numbers);
            ProductNumbers(numbers);

        }


        public static int ProductNumbers(int[] numbers)
        {
            int product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            Console.WriteLine("Product of numbers is {0}", product);
            return product;

        }


        public static double Average(int[] numbers)
        {
            double sum = 0;
     
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double average = sum / (double)numbers.Length;

            Console.WriteLine("Average of numbers is {0}", average);
            return average;
        }


        public static int NumberSortingMax(int[] numbers)
        {
            int max = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }               
            }

            Console.WriteLine("Biggest number is {0}", max);
            return max;
        }


        public static int NumberSortingMin(int[] numbers)
        {
            int min = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine("Smallest number is {0}", min);
            return min;
        }


        public static int[] FillingArrNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            return numbers;
        }

    }
}
