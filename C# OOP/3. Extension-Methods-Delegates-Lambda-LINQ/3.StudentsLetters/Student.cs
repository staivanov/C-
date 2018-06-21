using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.StudentsLetters
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student() { }

        public Student(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
        }

        public Student(string fname, string lname, int age)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Age = age;
        }

        public override string ToString()
        {
            string full =  this.FirstName + " " + this.LastName + " " + this.Age;
            if (this.Age == 0)
            {
                return this.FirstName + " " + this.LastName;
            }
            return full;
        }

    }
}
