using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.StudentsLetters;
using System.Collections;

namespace _4.FirstAndLastName
{
    class NameAndAge
    {
       // Write a LINQ query and Lambda that finds the first name and last name of all students with age between 18 and 24.
        static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            var students = new List<Student>() { 
                new Student { FirstName = "Stanislav", LastName = "Ivanov", Age = 24 },
                new Student { FirstName = "Nikolai", LastName = "Tapov", Age = 19 },
                new Student { FirstName = "Valeri", LastName = "Atanasov", Age = 50 }, 
                new Student { FirstName = "Angel", LastName = "Vitomirov", Age = 33},
                new Student { FirstName = "Tomas", LastName = "Berberov", Age = 42}
            };
            //LINQ
            var result =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            PrintCollection(result);
            Console.WriteLine(new string('*', 50));
            //LAMBA
            var res = students.FindAll(x => x.Age >= 18 && x.Age <= 24);
            PrintCollection(res);
            
        }
    }
}
