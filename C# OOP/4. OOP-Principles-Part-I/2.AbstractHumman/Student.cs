using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHumman
{
    class Student : Human
    {
        private int _grade;

        public int Grade
        {
            get { return this._grade; }
            private set { this._grade = value; }
        }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", base.FirstName, base.LastName, this.Grade);
        }

    }
}
