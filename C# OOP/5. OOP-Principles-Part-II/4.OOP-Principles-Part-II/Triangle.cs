using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.OOP_Principles_Part_II
{
    class Triangle : Shape
    {
        private int _height;
        private int _width;

        public int Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        public int Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        public Triangle(int heigth, int width)
            : base(heigth, width)
        {
            this.Height = heigth;
            this.Width = width;
        }

        public override void CalculateSurface()
        {
            int surface = (this.Height * this.Width) / 2;
            Console.WriteLine(surface);
        }

        public override string ToString()
        {
            return String.Format("Heigth {0}, Width {1}", this.Height, this.Width);
        }

    }
}
