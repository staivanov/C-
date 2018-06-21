using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Defining_Classes_Homework
{
    class Program
    {
        //Define a class Person that has name, age and email. The name and age are mandatory. The email is optional. Define properties that accept non-empty name and age in the range [1...100]. In case of invalid argument, throw an exception. Define a property for the email that accepts either null or non-empty string containing '@'. Define two constructors. The first constructor should take name, age and email. The second constructor should take name and age only and call the first constructor. Implement the ToString() method to enable printing persons at the console.

        public class Person
        {
            private string name;
            private sbyte age;
            private string email;


            public Person() { }

            public Person(string name, sbyte age) : this(name, age, null) { }

            public Person(string name, sbyte age, string email)
            {
                this.Name = name;
                this.Age = age;
                this.Email = email;
            }

            public string Name
            {
                get { return this.name; }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException("No empty field!");
                    }
                    else
                    {
                        this.name = value;
                    }
                }
            }

            public sbyte Age
            {
                get { return this.age; }
                set
                {
                    if (value < 1 || value > 100)
                    {
                        throw new ArgumentException("Your age can't be below 0 and above 100!");
                    }
                    else
                    {
                        this.age = value;
                    }
                }

            }

            public string Email
            {
                get { return this.email; }
                set
                {

                    this.email = value;
                }
            }

            public override string ToString()
            {
                return String.Format("My name is {0}. I am {1} years old. You can contact with me at {2}", this.name, this.age, this.email);
            }
        }

        static void Main(string[] args)
        {

            Person achkata = new Person("Achkata", 23, "varachonio@abv.bg");
            Console.WriteLine(achkata);

        }
    }
}
