using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Defining_Classes_Part_I
{
    public class Display
    {
        private double size;
        private uint colors;

        //Constructors
        public Display() { }

        public Display(double size)
        {
            this.Size = size;
        }

        public Display(double size, uint colors)
        {
            this.Size = size;
            this.Colors = colors;
        }

        //Properties
        public double Size
        {
            get { return this.size; }
            set
            {
                if (value <= 0 || value >= 6)
                {
                    throw new ArgumentException("Displays with six or more inches are phablest");
                }
                this.size = value;
            }
        }

        public uint Colors
        {
            get { return this.colors; }
            set
            {
                if (value <= 0 || value >= 16000001)
                {
                    throw new ArgumentException("Highest displays are with 16 000 000 colors");
                }
                this.colors = value;
            }
        }

        //Overriding
        public override string ToString()
        {
            return String.Format("{0} inch and colors are {1}", this.size, this.colors);
        }
    }
}
