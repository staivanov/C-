using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BinToDec
{
    //Write a program that converts a binary number to decimal one.

    class BinToDec
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Binary Number: ");
            string n = Console.ReadLine();
            int[] num = new int[100];
            int p = 1;
            int result = 0;

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == ('0'))
                {
                    num[i] = 0;
                }
                else if (n[i] == '1')
                {
                    num[i] = 1;
                }
            }

            for (int j = n.Length - 1; j >= 0; j--)
            {
                result = result + num[j] * p;
                p = p * 2;
            }
            Console.WriteLine("Decimal value is {0}", result);



        }
    }
}
