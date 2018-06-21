using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHumman
{
    class AbstractTask
    {
        //Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy. Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per hour in descending order.

        static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            Student stanislav = new Student("Stanislav", "Ivanov", 6);
            Student nekoi = new Student("Nekoi", "Tam", 2);
            Student boiko = new Student("Boiko", "Borisov", 5);
            Student toni = new Student("Toni", "Storaro", 6);
            Student kelly = new Student("Kelly", "Clarcson", 3);
            Student molly = new Student("Molly", "Dolly", 4);
            Student ganio = new Student("Bai", "Ganio", 1);
            Student ani = new Student("Ani", "Banani", 2);
            Student fani = new Student("Fani", "Shamani", 4);
            Student mraz = new Student("Dedo", "Mraz", 6);

            List<Student> aces = new List<Student>() { stanislav, nekoi, boiko, toni, kelly, molly, ganio, ani, fani, mraz };

            //Lamba
            //var sortedAces = aces.OrderBy(x => x.Grade);
            //PrintCollection(sortedAces);
            //LiNQ
            //var sortedAces = 
            //    from ace in aces
            //    orderby ace.Grade ascending
            //    select ace;
            //PrintCollection(sortedAces);

            Worker elf = new Worker("Elf", "Nekaf", 200, 8);
            Worker dog = new Worker("Elmo", "Doga", 300, 5);
            Worker cat = new Worker("Tom", "Kota", 150, 10);
            Worker horse = new Worker("White", "Power", 500, 5);
            Worker buzz = new Worker("Evel", "Knievel", 1000, 2);
            Worker alf = new Worker("Alfonso", "Taner", 350, 7);
            Worker adolf = new Worker("Adolf", "Hitler", 800, 5);
            Worker worker = new Worker("Unnamed", "Worker", 2000, 12);
            Worker stefan = new Worker("Stefan", "Stambolov", 2000, 24);
            Worker ceco = new Worker("Ceco", "Elvisa", 1000, 2);
            
            List<Worker> machines = new List<Worker>() { elf, dog, cat, horse, buzz, alf, adolf, worker, stefan, ceco };

            var sortedMachines =
                from machine in machines
                orderby machine.MoneyPerHours() descending
                select machine;

            PrintCollection(sortedMachines);

        }
    }
}
