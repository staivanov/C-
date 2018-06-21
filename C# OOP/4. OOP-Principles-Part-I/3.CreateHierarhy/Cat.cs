using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CreateHierarhy
{
    class Cat : Animal
    {
        public Cat(int age, string name, bool isMale)
            : base(age, name, isMale)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Myaau");
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", this.Age, this.Name, this.IsMale);
        }

    }
}
