using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.PrimeNumbers
{
    class Prime
    {



        static void Main(string[] args)
        {
            int n = 10000000;
            for (int i = 0; i < n; i++)
            {
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(i);
                bool prime = true;

                for (int j = divider; j <= maxDivider; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                }
                    }                   

                if (prime && true)
                {
                    Console.WriteLine(i);
                }
                      
            }


        }
    }
}
