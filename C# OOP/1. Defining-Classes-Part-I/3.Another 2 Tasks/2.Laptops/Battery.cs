using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Laptops
{
    public class Battery
    {
        private BatteryType bType;
        private sbyte cells;
        private uint mAh;

        public Battery() { }
        public Battery(sbyte cels, uint mah) { this.Cells = cells; this.MAh = mah; }
        public Battery(BatteryType btype, sbyte cells, uint mah)
        {
            this.Btype = btype;
            this.Cells = cells;
            this.MAh = mah;
        }

        public BatteryType Btype
        {
            get { return this.bType; }
            set { this.bType = value; }
        }

        public sbyte Cells
        {
            get { return this.cells; }
            set { this.cells = value; }
        }

        public uint MAh
        {
            get { return this.mAh; }
            set
            { this.mAh = value; }
        }

        public override string ToString()
        {
            return String.Format(" type {0} {1} cells {2} mAh", this.bType, this.cells, this.mAh);
        }

    }
}
