using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StudentOOP
{
   public class Student
    {
        private static uint studentCounter;

        private string firstName;
        private string middleName;
        private string surName;
        private Course course;
        private Speciality speciality;
        private Uni uni;
        private string email;
        private uint mobile;

        public Student() { Student.studentCounter += 1; }
        public Student
            (string firstName = "", string middleName = "", string surName = "", Course course = Course.I, Speciality speciality = Speciality.Agriculture, Uni uni = Uni.VTU, string email = "", uint mobile = 0000000)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.SurName = surName;
            this.Course = course;
            this.Speciality = speciality;
            this.Uni = uni;
            this.Email = email;
            this.Mobile = mobile;
            Student.studentCounter += 1;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public string SurName
        {
            get { return this.surName; }
            set { this.surName = value; }
        }

        public Course Course
        {
            get { return this.course; }
            set { this.course = value; }
        }

        public Speciality Speciality
        {
            get { return this.speciality; }
            set { this.speciality = value; }
        }

        public Uni Uni
        {
            get { return this.uni; }
            set { this.uni = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public uint Mobile
        {
            get { return this.mobile; }
            set { this.mobile = value; }
        }


        public static void NumberCreated()
        {
            uint value = Student.studentCounter;
            Console.WriteLine("Number of created students: " + value);
        }

        public override string ToString()
        {
            return String.Format("Full name: {0} {1} {2}. Cours {3} speciality {4} in {5}. For contacts my mobile is: {6} or you can email me at {7}", this.firstName, this.middleName, this.surName, this.course, this.speciality, this.uni, this.email, this.mobile);
        }

    }
}
