using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.StudentsLetters;
using System.Collections;

namespace _5.SortStudents
{
    class Ss
    {
        static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
        //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ.
        static void Main(string[] args)
        {
            var students = new[] { 
                new Student { FirstName = "Stanislav", LastName = "Ivanov", Age = 24 },
                new Student { FirstName = "Nikolai", LastName = "Tapov", Age = 19 },
                new Student { FirstName = "Baleri", LastName = "Atanasov", Age = 50 }, 
                new Student { FirstName = "Angel", LastName = "Vitomirov", Age = 33},
                new Student { FirstName = "Tomas", LastName = "Berberov", Age = 42}

            };
           //Lamba
            var res = students.OrderByDescending(s => s.FirstName).ThenBy(s => s.LastName);
            PrintCollection(res);
            Console.WriteLine(new string('*', 50));
            //LiNQ
            var result =
                from student in students           
                orderby student.FirstName descending, student.LastName descending              
                select student;
            PrintCollection(result);
        }
    }
}
