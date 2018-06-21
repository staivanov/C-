using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InDaSchool
{
    class Teacher : People
    {
        private List<Discipline> _myDiscipline;

        public List<Discipline> MyDiscipline
        {
            get { return this._myDiscipline; }
            set { this._myDiscipline = value; }
        }

        public Teacher(List<Discipline> discipline, string name) : base(name)
        {
            this._myDiscipline = new List<Discipline>();
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.MyDiscipline, base.Name);
        }

    }
}
