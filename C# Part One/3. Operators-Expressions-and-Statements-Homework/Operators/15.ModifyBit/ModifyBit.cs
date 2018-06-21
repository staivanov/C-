using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ModifyBit
{
    class ModifyBit
    {
        //We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. 

        static void Main()
        {
            Console.Write("Enter your number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Bit value 1 or 0: ");
            int v = int.Parse(Console.ReadLine());

            int mask;
            int nOrMask;
            int bit;

            if (v == 0)
            {
                //Set bit to zero
                mask = ~(1 << p);
                bit = n & mask;
                Console.WriteLine(bit);
                Console.WriteLine(Convert.ToString(bit, 2));
            }
            else if (v == 1)
            {
                //Set bit to One
                mask = 1 << p;
                bit = n | mask;
                Console.WriteLine(bit);
            }
            else
            {
                Console.WriteLine("Incorect value input!!!");
            }
           
        }
    }
}
