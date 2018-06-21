using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractBits
{
    class BitExtract
    {
        //Write an expression that extracts from given integer n the value of given bit at index p. 

        static void Main(string[] args)
        {
            Console.WriteLine("Write an expression that extracts from given integer n the value of given bit at index p");
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position: ");
            int p = int.Parse(Console.ReadLine());

            int mask;
            int nAndmask;
            int bit;

            mask = 1 << p;
            nAndmask = n & mask;
            bit = nAndmask >> p;

            Console.WriteLine(bit);

        }
    }
}
