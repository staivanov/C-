using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DecToBin
{
    class DecToBin
    {
        //Write a program that converts a decimal number to binary one.
        static void Main(string[] args)
        {
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
