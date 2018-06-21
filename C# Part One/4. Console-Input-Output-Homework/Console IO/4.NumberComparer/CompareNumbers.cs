using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NumberComparer
{
    class CompareNumbers
    {
        //Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements. 

        public static void CompareNumbs(float a, float b)
        {

            Console.WriteLine(a > b ? "{0}" : "{1}", a, b);
        }


        static void Main()
        {
            Console.WriteLine("This app compare two number and print greaer");
            Console.Write("Enter first num: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter second num: ");
            float b = float.Parse(Console.ReadLine());

            CompareNumbs(a, b);
         
        }
    }
}
