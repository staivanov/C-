using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Soft3Numbers
{
    class Program
    {
        //Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality. 

        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            if ((a > 0) && (b > 0) && (c > 0))
            {
                Console.WriteLine("+");
            }
            else if ((a == 0) || (b == 0) || (c == 0))
            {
                Console.WriteLine("0");
            }
            else if ((a < 0) || (b < 0) || (c < 0))
            {
                Console.WriteLine("-");
            }
            else
            {
                Main();
            }

        }
    }
}
