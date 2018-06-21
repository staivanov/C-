using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Type_System
{
    public class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string Adress { get; set; }
        public uint PhoneNumber { get; set; }
        public string Email { get; set; }
        public Specialities Speciality { get; set; }
        public Universities Univeristy { get; set; }
        public Faculties Faculty { get; set; }

        public Student() { }

        public Student(string fName, string mName, string lName, int ssn, string adress, uint phone, string email, Specialities speciality, Universities uni, Faculties facultet)
        {
            this.FirstName = fName;
            this.MiddleName = mName;
            this.LastName = lName;
            this.SSN = ssn;
            this.Adress = adress;
            this.PhoneNumber = phone;
            this.Email = email;
            this.Speciality = speciality;
            this.Univeristy = uni;
            this.Faculty = facultet;
        }

        public override string ToString()
        {
            string overridedStudent = String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Adress, this.PhoneNumber, this.Email, this.Speciality, this.Univeristy, this.Faculty);

            return overridedStudent;
        }

        public override bool Equals(object obj)
        {

            var otherStudent = obj as Student;

            if (otherStudent == null)
            {
                return false;
            }

            if (!(Object.Equals(otherStudent.FirstName, this.FirstName)))
            {
                return false;
            }

            if (!(Object.Equals(otherStudent.LastName, this.LastName)))
            {
                return false;
            }

            if (otherStudent.SSN != this.SSN)
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Student first, Student second)
        {

            return object.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !object.Equals(first, second);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode() ^ this.SSN.GetHashCode() ^ this.PhoneNumber.GetHashCode();
        }

        //Need to be Deep copy
        public object Clone()
        {
            var student = new Student();

            student.FirstName = this.FirstName;
            student.MiddleName = this.MiddleName;
            student.LastName = this.LastName;
            student.SSN = this.SSN;
            student.Adress = this.Adress;
            student.PhoneNumber = this.PhoneNumber;
            student.Email = this.Email;
            student.Speciality = this.Speciality;
            student.Univeristy = this.Univeristy;
            student.Faculty = this.Faculty;

            return student;
        }

        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return (this.FirstName.CompareTo(student.FirstName));
            }

            if (this.LastName != student.LastName)
            {
                return (this.LastName.CompareTo(student.LastName));
            }

            if (this.SSN != student.SSN)
            {
                return (this.SSN - student.SSN);
            }

            return 0;
        }
    }
}
