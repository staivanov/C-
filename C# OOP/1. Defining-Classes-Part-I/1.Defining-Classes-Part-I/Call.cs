using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Defining_Classes_Part_I
{
   public class Call: IComparable<Call>
    {
        private static uint dialCounter;

        private DateTime dateAndTime;
        private uint numberDialed;
        private uint duration;

        public int CompareTo(Call other)
        {
            if (this.duration > other.duration) return 1;
            else if (this.duration == other.duration) return 0;
            else return -1;
        }

        public DateTime DateAndTime
        {
            get
            {
                return this.dateAndTime;
            }
            private set
            {
                this.dateAndTime = value;
            }
        }

        public uint Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                this.duration = value;
            }
        }

        public uint NumberDialed
        {
            get
            {
                return this.numberDialed;
            }
            private set
            {
                this.numberDialed = value;
            }
        }

        public static uint DialCounter
        {
            get
            {
                return dialCounter;
            }
        }

        public Call() { }
        public Call(uint dialedNumber, uint duration)
        {

            this.DateAndTime = DateTime.Now;
            this.NumberDialed = dialedNumber;
            this.Duration = duration;
            Call.dialCounter++;
        }

        public override string ToString()
        {

            string callingDisplay = string.Format("{0} - Number {1} - {2} minutes", this.dateAndTime, this.numberDialed, this.duration);
            return callingDisplay;

        }

    }
}
