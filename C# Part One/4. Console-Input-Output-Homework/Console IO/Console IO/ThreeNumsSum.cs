using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_IO
{
    class ThreeNumsSum
    {
        //Write a program that reads 3 real numbers from the console and prints their sum. 

        public static int SumNumbers(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }

        static void Main()
        {
            Console.WriteLine("Enter three numbers one by one: ");
            Console.Write("\'a\': ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\'b\': ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("\'c\': ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Result a + b + c is: {0}", SumNumbers(a,b,c));

        }
    }
}
