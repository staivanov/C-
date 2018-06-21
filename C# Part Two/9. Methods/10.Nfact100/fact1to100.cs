using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.Nfact100
{
    class fact1to100
    //  Write a program that calculates and prints the n! for any n in the range [1…100].
    {
        public static void FactorialForNumber(BigInteger[] nFact)
        {
            int c = 0;

            for (int i = 1; i <= 100; i++)
            {
                BigInteger power = 1;
                for (int j = 1; j <= i; j++)
                {
                    power *= j;
                }
                nFact[c] = power;
                c++;
            }    
      
        }


        public static void PrintFactorial(BigInteger[] nFact)
        {
            foreach (var factorial in nFact)
            {
                Console.WriteLine(factorial);
            }
        }


        static void Main()
        {
            BigInteger[] nFact = new BigInteger[100];
            FactorialForNumber(nFact);
            PrintFactorial(nFact);
        }
    }
}
