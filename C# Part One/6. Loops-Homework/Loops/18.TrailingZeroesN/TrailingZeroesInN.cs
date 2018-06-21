using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _18.TrailingZeroesN
{
    class TrailingZeroesInN
    {
        //Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should work well for very big numbers, e.g. n=100000. 

        static void Main(string[] args)
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger count = 0;
            BigInteger result = 1;
            for (int j = 1; j <= a; j++)
            {
                result = result * j;
            }
            Console.WriteLine(result);

            string b = result.ToString();
            for (int i = (b.Length - 1); i >= 0; i--)
            {
                if (b[i].ToString() == "0")
                {
                    count++;
                }
                else break;

            }
            Console.WriteLine("Zeroes: {0}", count);

        }
    }
}
