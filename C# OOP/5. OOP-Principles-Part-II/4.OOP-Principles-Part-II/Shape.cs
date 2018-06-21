using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.OOP_Principles_Part_II
{
    abstract class Shape
    {
        private int _height;
        private int _width;


        public Shape(int heigth, int width)
        {
            this._height = heigth;
            this._width = width;
        }


        public abstract void CalculateSurface();
    }
}
