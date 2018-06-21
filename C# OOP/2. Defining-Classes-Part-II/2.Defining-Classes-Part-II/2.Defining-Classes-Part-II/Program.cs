using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2.Defining_Classes_Part_II
{
    class Program
    {
        // Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point.
        //Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.
        //Write a static class with a static method to calculate the distance between two points in the 3D space.
        //Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.

        static void Main(string[] args)
        {
            //1
            Point3D f = new Point3D(-7, -4, 3);
            Point3D s = new Point3D(17, 6, 2.5);
            //2
            Console.WriteLine(Point3D.Start);
            //3
            Console.WriteLine("Distance is {0}", CalculatePoints.Two(f, s));
            //4
            PathStorage.Save(new Path(new Point3D(5, 2, 6), new Point3D(1, 3, 9), new Point3D(14, 6, 90)));
            //Console.WriteLine("Operation succeeded!");
            //5
            PathStorage.Load("output.txt");

        }
    }
}
