using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MultiplicationSign
{
    class MultiSign
    {
        //Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators. 

        private static void Checking(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("+");
            }
            else if (num == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("-");
            }
        }


        static void Main()
        {
            Console.Write("num = ");
            int num = int.Parse(Console.ReadLine());
            Checking(num);
        }


    }
}
