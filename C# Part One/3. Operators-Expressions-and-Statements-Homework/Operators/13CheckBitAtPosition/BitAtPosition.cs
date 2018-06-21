using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13CheckBitAtPosition
{
    class BitAtPosition
    {
        //Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. 

        static void Main(string[] args)
        {
            Console.WriteLine("Boolean expression that returns if the bit at position p in giv integer number n has value of 1");
            Console.Write("Enter your number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position: ");
            int p = int.Parse(Console.ReadLine());
            
            int mask;
            int nAndmask;
            int bit;
            bool one = true;
            bool zero = false;

            mask = 1 << p;
            nAndmask = n & mask;
            bit = nAndmask >> p;

            if (bit == 1)
            {
                Console.WriteLine(one);
            }
            else
            {
                Console.WriteLine(zero);
            }

        }
    }
}
