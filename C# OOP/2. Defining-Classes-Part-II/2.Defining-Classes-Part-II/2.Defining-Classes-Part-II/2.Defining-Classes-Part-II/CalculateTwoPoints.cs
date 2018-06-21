using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Defining_Classes_Part_II
{
    public static class CalculatePoints
    {      
        public static double Two(Point3D first, Point3D second)
        {
            double xPart = (second.X - first.X) * (second.X - first.X);
            double yPart = (second.Y - first.Y) * (second.Y - first.Y);
            double zPart = (second.Z - first.Z) * (second.Z - first.Z);

            double result = Math.Sqrt(xPart + yPart + zPart);
            return result;
        }
    }
}
