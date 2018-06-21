using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.CalculateNandK
{
    class NDividedKfactorials
    {
        //Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.

        static void Main(string[] args)
        {
            Console.WriteLine("Calculate N!/K!");
            Console.Write("N= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K= ");
            int k = int.Parse(Console.ReadLine());
            int result = 1;
            int result2 = 1;

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

                Console.WriteLine("Result is {0}", result/result2);
            }


        }
    }
}
