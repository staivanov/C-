using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.FibonaciNumbers
{
    class Fibonaci
    {
        //Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops. 

        public static void Fibo(int n)
        {
            BigInteger firstNumber = 0;
            BigInteger secondNumber = 1;
            BigInteger sum = 0;

            for (int i = 0; i < n; i++)
            {
                firstNumber = secondNumber;
                secondNumber = sum;
                Console.Write(sum + " ");
                sum = firstNumber + secondNumber;
            }
            Console.WriteLine();
        }


        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Fibo(n);
        }
    }
}
