using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.OOP_Principles_Part_II
{
    class ShapedModeling
    {
        //Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method. Write a program that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.

        static void Main(string[] args)
        {
            Rectangle bd = new Rectangle(10, 4);
            Triangle abc = new Triangle(10, 5);
            Circle cc = new Circle(3, 3);

            Shape[] shapes = new Shape[] { bd, abc, cc };

            foreach (var shape in shapes)
            {
                shape.CalculateSurface();
            }

        }
    }
}
