using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _8.CatalanNumbers
{
    class NumbersCatalan
    {
        //In combinatorics, the Catalan numbers are calculated by the following formula.
      

        static void Main(string[] args)
        {
            Console.WriteLine("Catalan Numbers");
            Console.Write("N= ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger result = 1;
            BigInteger result2 = 1;
            BigInteger result3 = 1;

            //Formula (2n)! / (n+1)!n!

            //SideLeft
            if ((1 < n) && (n <100))
            {
                for (int i = 2; i <= 2 * n; i++)
                {
                    result *= i;
                }

                //SideRight part 1
                for (int j = 2; j <= n + 1; j++)
                {
                    result2 *= j;
                }

                //SideRight part 2
                for (int q = 2; q <= n; q++)
                {
                    result3 *= q;
                }

                //Result
                Console.WriteLine("Catalan: {0}", result / (result2 * result3));
            }
            else
            {
                Console.WriteLine("Enter 1 < n < 100");
            }

        }
    }
}
