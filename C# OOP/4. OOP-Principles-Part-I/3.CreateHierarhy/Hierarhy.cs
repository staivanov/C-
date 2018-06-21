using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CreateHierarhy
{
    //Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals.
    //All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age,
    //name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. 
    //Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

    class Hierarhy
    {
        static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            Frog karmit = new Frog(5, "Karmit", true);
            Frog moshka = new Frog(10, "Moshka", false);
            Dog balhar = new Dog(5, "Balhar", true);
            Dog chez = new Dog(10, "Chestur", true);
            Kitten mya = new Kitten(6, "Mya", false);
            Kitten belle = new Kitten(4, "Belle", false);
            Tomcat tom = new Tomcat(8, "Tom", true);
            Tomcat jerry = new Tomcat(2, "Jerry", true);
            Animal d = new Animal(20, "Da", true);
            
            Animal[] zoo = new Animal[] { karmit, moshka, balhar, chez, mya, belle, tom, jerry };

            PrintCollection(zoo);

            var averageAge = zoo.Average(x => x.Age);
            Console.WriteLine("Average age is {0}", averageAge);

        }
    }
}
