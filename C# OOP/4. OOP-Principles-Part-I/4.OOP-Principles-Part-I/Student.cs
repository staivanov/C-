using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InDaSchool
{
    class Student : People
    {
        private int _klasNumber;

        public int KlasNumber
        {
            get { return this._klasNumber; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Your number cant be zero!");
                }
                this._klasNumber = value;
            }
        }

        public Student(int klasNumber, string name)
            : base(name)
        {
            this._klasNumber = klasNumber;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.KlasNumber, base.Name);
        }

    }
}
