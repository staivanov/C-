using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.OOP_Principles_Part_II
{
    class Circle : Shape
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


        public Circle(int heigth, int width)
            : base(heigth, width)
        {
            if (heigth != width)
            {
                throw new ArgumentException("Heigth and Width must be equal!");
            }
            this.Height = heigth;
            this.Width = width;
        }

        public override void CalculateSurface()
        {
            double surface = Math.PI * this.Height * this.Height;
            Console.WriteLine(surface);
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.Height, this.Width);
        }


    }
}
