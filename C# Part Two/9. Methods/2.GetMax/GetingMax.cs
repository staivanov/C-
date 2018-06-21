using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GetMax
{
     //Create a method GetMax() with two integer (int) parameters, that returns maximal of the two numbers. Write a program that reads three numbers from the console and prints the biggest of them. Use the GetMax() method you just created. Write a test program that validates that the methods works correctly.

    class GetingMax
    {

        static int GetMax(int a, int b)
        {
            int max = a;
            if (a < b)
            {
                max = b;
            }
            Console.WriteLine("Max is {0}", max);
            return max;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b= ");
            int b = int.Parse(Console.ReadLine());
            GetMax(a, b);

           
        }
    }
}
