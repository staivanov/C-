using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Hypotenuse
{
    class TriangleHypotenuse
    {

        public static double Pitagor(double a, double b)
        {
            //Formula is C^2 = A^2 + B^2
            // c = sqrt(a^2+b^2)
            double c;
            c = Math.Sqrt(Math.Pow(a, a) + Math.Pow(b, b));
            Console.WriteLine(c);
            return c;
        }


        static void Main(string[] args)
        {
            //Write a program which by given two sides finds the hypotenuse of a right triangle. Implement entering of the lengths of the sides from the standard input, and for the calculation of the hypotenuse use methods of the class Math.
            Console.Write("Enter catetus one length: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter catetus two length: ");
            double b = double.Parse(Console.ReadLine());

            Pitagor(a, b);

        }
    }
}
