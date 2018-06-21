using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InDaSchool
{
    class School
    {
        private List<Klass> _klasses;

        public List<Klass> Klasses
        {
            get { return this._klasses;}
            set
            {
                this._klasses = value;
            }
        }

        public School(List<Klass> klasses)
        {
            this.Klasses = new List<Klass>();
        }

        public override string ToString()
        {
            return String.Format("{0}", this.Klasses);
        }
    }
}
