using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenProduct
{
    class EvenAndOdd
    {
        //You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc. 

        static void Main()
        {
            Console.WriteLine("Enter five numbs in sigle line separated by space");
            string[] tokens = Console.ReadLine().Split();
            int product = 1;
            int product2 = 1;

            //tokens    [0][1][2][3][4]
            //numbers    2  1  1  6  3

            //odd elements
            for (int j = 0; j < tokens.Length; j += 2)
            {
                product = product * Convert.ToInt32(tokens[j]);
            }
            
            //even elements
            for (int i = 1; i < tokens.Length; i = i + 2)
            {
                product2 = product2 * Convert.ToInt32(tokens[i]);
            }

            if (product == product2)
            {
                Console.WriteLine("yes, product is {0}", product);
            }
            else {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", product);
                Console.WriteLine("even_product = {0}", product2);
            }

        }
    }
}
