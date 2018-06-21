using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InDaSchool
{
    class Program
    {
        //    We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
        //Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.

        static void Main(string[] args)
        {
            Discipline biology = new Discipline("Biology", 15, 15);
            Discipline mathematic = new Discipline("Mathematic", 20, 20);
            Discipline history = new Discipline("History", 30, 30);
            Discipline sport = new Discipline("Sport", 5, 25);

            Student nelly = new Student(12, "Nelly");
            Student kelly = new Student(7, "Kelly");
            Student stenlly = new Student(21, "Stenlly");

            Teacher bogdan = new Teacher(new List<Discipline> { biology, history }, "Bogdan");
            Teacher andrey = new Teacher(new List<Discipline> { history, sport }, "Andrey");
            Teacher kalin = new Teacher(new List<Discipline> { mathematic, history }, "Kalin");

            Klass secondB = new Klass("B", new List<Teacher> { bogdan, kalin }, new List<Student> { nelly, kelly });
            Klass thirdG = new Klass("G", new List<Teacher> { kalin, andrey }, new List<Student> { nelly, kelly, stenlly });
            Klass firstA = new Klass("A", new List<Teacher> { bogdan, andrey, kalin }, new List<Student> { nelly, kelly, stenlly });
        }
    }
}
