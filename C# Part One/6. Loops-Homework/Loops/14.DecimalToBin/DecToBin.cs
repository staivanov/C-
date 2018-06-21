using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DecimalToBin
{
    class DecToBin
    {
        //Using loops write a program that converts an integer number to its binary representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. 

        static void Main(string[] args)
        {

            //Version 1
            //long n = long.Parse(Console.ReadLine());
            //long remainder = 0;
            //long[] result = new long[32];


            //for (int i = 0; i < result.Length; i++)
            //{
            //    remainder = n % 2;
            //    result[i] = remainder;
            //    n /= 2;
            //}

            //Console.WriteLine();

            //for (int j = result.Length - 1; j >= 0; j--)
            //{
            //    Console.Write(result[j]);
            //}
            //Console.WriteLine();

            //Version 2
            long decimalNumber = long.Parse(Console.ReadLine());
            long remainder;
            string result = string.Empty;

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine(result);

        }
    }
}
