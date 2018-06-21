using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CirclePerimeterAndArea
{
    class CirclePandArea
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. 

        public static float PerimeterCalc(float r)
        {
            float perimeter;
            perimeter = (float)(2 * 3.14 * r);
            return perimeter;
        }


        public static float AreaCalc(float r)
        {
            float area;
            area = (float)(3.14 * r * r);
            return area;
        }


        static void Main()
        {
            Console.WriteLine("This program calculate circle perimetre and area");
            Console.Write("Enter \'r\': ");
            float r = float.Parse(Console.ReadLine());

            float perimeter = PerimeterCalc(r);
            float area = AreaCalc(r);

            Console.WriteLine("Circle perimeter is: {0:F2} ", perimeter);
            Console.WriteLine("Area of circle is: {0:F2} ", area);

        }
    }
}
