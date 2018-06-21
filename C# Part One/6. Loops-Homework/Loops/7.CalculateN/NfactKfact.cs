using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



namespace _7.CalculateN
{
    class NfactKfact
    {
        //Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. 

        static void Main(string[] args)
        {
            Console.WriteLine("Calculate N!/K!");
            Console.Write("N= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K= ");
            int k = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            BigInteger result2 = 1;
            BigInteger result3 = 1;

            if ((1 < k) && (k < n) && (n < 100))
            {
                for (int i = 2; i <= n; i++)
                {
                    result = result * i;
                }

                for (int i = 2; i <= k; i++)
                {
                    result2 = result2 * i;
                }

                for (int q = 2; q <= n-k; q++)
                {
                    result3 = result3 * q;
                }

              
            }

            Console.WriteLine("N!/(K!*(N-K)!)= {0}", result / (result2*result3));
            
        }
    }
}
