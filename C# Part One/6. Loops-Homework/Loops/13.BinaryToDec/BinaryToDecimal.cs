
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryToDecimal
{
    class Program
    {
        //Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 

        static void Main(string[] args)
        {
            //            //.Net Built-in fuction
            //            //int value = int.Parse(Console.ReadLine());
            //            //string binary = Convert.ToString(value, 2);
            //            //Console.WriteLine(binary);

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