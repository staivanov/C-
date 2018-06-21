using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Rectangle
{
    class Rectnl
    {
        //Write an expression that calculates rectangle’s perimeter and area by given width and height. 

        static void Main()
        {
            Console.WriteLine("This program calculates rectangle’s perimeter and area by given width and height");
            Console.Write("Enter valid width: ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Enter valid height: ");
            float height = float.Parse(Console.ReadLine());
 
            float p = (2 * width) + (2 * height);
            float a = width * height;

            Console.WriteLine("Perimetre is {0} and area is {1}", p, a);
            Console.WriteLine();

        }
    }
}
