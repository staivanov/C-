using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Type_System
{
    public class Program
    {
        //Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, 
        //course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. 
        //    Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

        static void Main(string[] args)
        {
            Student bill = new Student("Bil", "Nqkoi", "Pich", 555509999, "MyAdress", 331567, "nekaf@abv.eu", Specialities.Engineer, Universities.MIT, Faculties.ComputerScience);
            Student balhar = new Student("Balhar", "Nqkoi", "Pich", 789019999, "MyAdress", 331567, "nekaf@abv.eu", Specialities.Doctor, Universities.MIT, Faculties.ComputerScience);
            Student nekaf = new Student("Nekaf", "Si", "Tam", 123409999, "HollyMolly", 555567, "ngtee2kaf@abv.eu", Specialities.Lawer, Universities.Lufthansa, Faculties.Aviation);
            Student ko = new Student("Ko", "Shi", "Qm", 666509999, "HollyMolly", 555567, "ngtee2kaf@abv.eu", Specialities.Lawer, Universities.Lufthansa, Faculties.Aviation);
            Student koto = new Student("Ko", "To", "Ima", 901450931, "Uber", 55123, "grezko@da.ne", Specialities.Doctor, Universities.Princeton, Faculties.Law);


            //Cloning test
            Student cloned = (Student)bill.Clone();
            Console.WriteLine(Object.Equals(bill, cloned));
            //Sorting and compare
            List<Student> rappers = new List<Student>() { bill, balhar, nekaf, ko, koto };
            rappers.Sort();

            foreach (var s in rappers)
            {
                Console.WriteLine(s);
            }

        }
    }
}
