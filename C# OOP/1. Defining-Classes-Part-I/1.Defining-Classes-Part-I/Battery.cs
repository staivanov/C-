using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Defining_Classes_Part_I
{
    public class Battery
    {
        private string model;
        private uint hoursIdle;
        private uint hoursTalk;
        private BatteryType bType;

        //Constructors
        public Battery() { }

        public Battery(string model, BatteryType bType)
        {
            this.Model = model;
            this.BatteryT = bType;
        }

        public Battery(string model, uint hoursIdle)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
        }

        public Battery(uint hoursIdle, uint hoursTalk, BatteryType bType)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryT = bType;
        }

        public Battery(string model, uint hoursIdle, uint hoursTalk, BatteryType bType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryT = bType;
        }

        //Properties
        public string Model
        {
            get { return this.model; }
            set {
                if (value.Length >= 15)
                {
                    throw new ArgumentException("Battery name cant be too long");
                }
                this.model = value;
            }
        }

        public uint HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value <= 0 || value > 256)
                {
                    throw new ArgumentException("Battery idle cant be zero or above 256h!");
                }
                this.hoursIdle = value;
            }
        }

        public uint HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value <= 0 || value > 70)
                {
                    throw new ArgumentException("Battery talkt cant be zero or over 70h!");
                }
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryT
        {
            get { return this.bType; }
            set { this.bType = value; }
        }

        //Overriding
        public override string ToString()
        {
            return String.Format("model: {0}, hours Idle: {1}, hourse talk: {2}, battery type {3}", this.model, this.hoursIdle, this.hoursTalk, this.bType);
        }
    }
}
