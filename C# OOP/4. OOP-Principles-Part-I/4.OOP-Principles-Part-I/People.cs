using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InDaSchool
{
      class People
    {
        private const sbyte NAME_LENGTH = 2;
        private string _name;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Enter name");
                }
                else if (value.Length <= NAME_LENGTH)
                {
                    throw new ArgumentOutOfRangeException("Name must be three or more symbols!");
                }
                this._name = value;
            }
        }

        public People(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return String.Format("{0}", this.Name);
        }

    }
}
