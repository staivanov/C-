using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumbersInInterval
{
    class IntervalNumbersDivided
    {
        //Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0

        public static int IntervalD(int a, int b){

            int p = 0;

            for (int i = a; i <= b; i++)
            {
                if ((i % 5) == 0)              
                    p++;
            }

            Console.WriteLine(p);
            return p;

        }

        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            IntervalD(a, b);

        }
    }
}
