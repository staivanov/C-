using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.QuadraticEquation
{
    class QuadraticEquation
    {
        //Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). 

        public static void Print(float a, float b, float d, float x2, float x1)
        {
            if (d < 0)
            {
                Console.WriteLine("No real roots");
            }
            else if (d == 0)
            {
                Console.WriteLine("x = {0}", -b / (2 * a));
            }
            else
            {
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
        }

        public static void Quadratic(float a, float b, float c)
        {
            float d = (b * b) - (4 * a * c);
            float dRoot = (float)Math.Sqrt(d);
            float x2 = (-b + dRoot) / (2 * a);
            float x1 = (-b - dRoot) / (2 * a);

            Print(a, b, d, x2, x1);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("This program solve quadratic equation");
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float c = float.Parse(Console.ReadLine());

            Quadratic(a, b, c);
 
        }
    }
}
