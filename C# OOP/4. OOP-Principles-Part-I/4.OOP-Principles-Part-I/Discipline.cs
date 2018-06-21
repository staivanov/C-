using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InDaSchool
{
     class Discipline
    {
        private string _name;
        private int _numberOfLectures;
        private int _numberOfExercises;

        public string Name
        {
            get { return this._name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("It cant be emtpy");
                }
                this._name = value;
            }
        }

        public int NumberOfLectures
        {
            get { return this._numberOfLectures; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lectures cant be zero.");
                }
                this._numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get { return this._numberOfExercises; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lectures cant be zero.");
                }

                this._numberOfExercises = value;
            }
        }

        public Discipline(string name, int numbOfLectures, int numbOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numbOfLectures;
            this.NumberOfExercises = numbOfExercises;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", this.Name, this.NumberOfLectures, this.NumberOfExercises);
        }

    }
}
