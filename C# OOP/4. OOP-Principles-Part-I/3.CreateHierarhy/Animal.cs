using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CreateHierarhy
{
    class Animal : ISound
    {
        private int _age;
        private string _name;
        private bool isMale;

        public int Age
        {
            get { return this._age; }
            protected set { this._age = value; }
        }

        public string Name
        {
            get { return this._name; }
            protected set { this._name = value; }
        }

        public bool IsMale
        {
            get { return this.isMale; }
            protected set { this.isMale = value; }
        }

        public Animal(int age, string name, bool isMale)
        {
            this.Age = age;
            this.Name = name;
            this.IsMale = isMale;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Grrr");
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", this.Age, this.Name, this.IsMale);
        }
    }
}
