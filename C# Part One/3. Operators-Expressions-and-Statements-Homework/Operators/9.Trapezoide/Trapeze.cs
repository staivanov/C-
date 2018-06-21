using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Trapezoide
{
    class Trapeze
    {
        //Write an expression that calculates trapezoid's area by given sides a and b and height h. 

        static void Main(string[] args)
        {
            Console.WriteLine("Expression that calculates trapezoid's area by given sides a and b and height h");

            Console.Write("Enter \'a\': ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter \'b\': ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter \'h\': ");
            float h = float.Parse(Console.ReadLine());

            float area = ((a + b) / 2) * h;

            Console.WriteLine("Trapezoide are is: {0}", area);

        }
    }
}
