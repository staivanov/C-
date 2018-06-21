using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.StudentsLetters
{
    public class NameSearch
    {
        //Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.

        public static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            var students = new[] { 
                new Student { FirstName = "Stanislav", LastName = "Ivanov" },
                new Student { FirstName = "Nikolai", LastName = "Kalinov" },
                new Student { FirstName = "Asenn", LastName = "Asenov" }, 
                new Student { FirstName = "Angel", LastName = "Vi"},
                new Student { FirstName = "Tomas", LastName = "Berberov"}

            };

            var firstBeforeLast =
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            PrintCollection(firstBeforeLast);

        }
    }
}
