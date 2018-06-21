using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test
{
    class Program
    {
        //Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. 

        static void Main()
        {
            Console.WriteLine("Check bit at position \'p\'");

            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            int p = 3;
            int mask = 1 << p;
            int nAndmask = n & mask;
            int bit = nAndmask >> p;
            Console.WriteLine(bit);

        }
    }
}
