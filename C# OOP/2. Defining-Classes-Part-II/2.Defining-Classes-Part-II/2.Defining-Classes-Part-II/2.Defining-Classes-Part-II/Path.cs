using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Defining_Classes_Part_II
{
    public class Path
    {
        public Point3D FirstPoint { get; set; }
        public Point3D SecondPoint { get; set; }
        public Point3D ThirdPoint { get; set; }

        public Path(Point3D one = new Point3D(), Point3D two = new Point3D(), Point3D three = new Point3D())
        {
            this.FirstPoint = one;
            this.SecondPoint = two;
            this.ThirdPoint = three;
        }

        public override string ToString()
        {
            string view = String.Format("{0}, {1}, {2}", this.FirstPoint, this.SecondPoint, this.ThirdPoint);
            return view;
        }

    }
}
