using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PersonAndNullAge
{
    class NullAge
    {
        //Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so. Write a program to test this functionality.
        class Person
        {
            public string Name { get; set; }
            public int? Age { get; set; }

            public Person(string name, int? age)
            {
                this.Name = name;
                this.Age = age;
            }

            public override string ToString()
            {
                string result = String.Format("{0} {1}", this.Name, this.Age);

                if (this.Age == null)
                {
                    result = result = String.Format("Name is {0} Age is null", this.Name);
                }
                return result;
            }
        }

        static void Main(string[] args)
        {
            Person az = new Person("Dayne", null);
            Console.WriteLine(az);
        }
    }
}
