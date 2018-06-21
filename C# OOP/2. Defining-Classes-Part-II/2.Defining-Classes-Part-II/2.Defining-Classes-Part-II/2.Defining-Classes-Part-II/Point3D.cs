using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Defining_Classes_Part_II
{
    public struct Point3D
    {
        private static readonly Point3D start = new Point3D(0, 0, 0);

        public static Point3D Start { get { return start; } }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x = 0, double y = 0, double z = 0)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;        
        }

        public override string ToString()
        {
            string view = String.Format("P x = {0} y = {1} z =  {2}", this.X, this.Y, this.Z);
            return view;
        }
    }
}
