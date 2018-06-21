using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StudentOOP
{
    class Program
    {
//1.        Define a class Student, which contains the following information about students: full name, course, subject, university, e-mail and phone number.
//2.    Declare several constructors for the class Student, which have different lists of parameters (for complete information about a student or part of it). Data, which has no initial value to be initialized with      null. Use nullable types for all non-mandatory data.
//3.    Add a static field for the class Student, which holds the number of created objects of this class.
//4.    Add a method in the class Student, which displays complete information about the student.
//5.    Modify the current source code of Student class so as to encapsulate the data in the class using properties.
//6.    Write a class StudentTest, which has to test the functionality of the class Student.

        public class StudentTest
        {
            public static void Testing()
            {
                Student Jeff = new Student("Jeff", "Hosse", "Gordon", Course.V, Speciality.Law, Uni.VTU, "nascar@abv.bg", 0888555666);
                Student Asq = new Student("Asq", "Kirova", "Pencheva", Course.I, Speciality.Nursing, Uni.TuSofia, "asinka@yahoo.com", 0883911911);
                Student Pharaona = new Student("Tutan", "Gospodinov", "Khamun", Course.II, Speciality.ScienceTechnologies, Uni.BurgasFree, "tutan@egypt.eg", 0000000);
                Student empty = new Student();

                Student[] students = new Student[4] { Jeff, Asq, Pharaona, empty };

                foreach (var s in students)
                {
                    Console.WriteLine(s);
                    Console.WriteLine(new string('+', 60));
                }

                Student.NumberCreated();
            }
        }

        static void Main(string[] args)
        {
            StudentTest.Testing();   
        }
    }
}
