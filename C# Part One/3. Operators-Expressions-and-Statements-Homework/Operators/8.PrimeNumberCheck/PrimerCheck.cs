using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.PrimeNumberCheck
{
    class PrimerCheck
    {
        //Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). 

        static void Main(string[] args)
        {
            Console.WriteLine("Expression that checks if given positive integer number \'n\' (n <= 100) is prime");
            Console.Write("Enter your number to check: ");

            int num = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(num);
            bool prime = true;

            while (prime && (divider <= maxDivider))
            {
                if (num % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }

            Console.WriteLine("Prime? " + prime);

        }
    }
}
