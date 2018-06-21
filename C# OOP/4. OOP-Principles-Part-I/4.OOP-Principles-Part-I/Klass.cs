using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InDaSchool
{
    class Klass
    {
        private string _textID;
        private List<Teacher> _teachers;
        private List<Student> _students;

        public string TextID
        {
            get
            {
                return this._textID;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Class cant be empty");
                }

                this._textID = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this._teachers;
            }
            set
            {
                this._teachers = value;
            }
        }

        public List<Student> Students
        {
            get 
            {
                return this._students;
            }
            set
            {
                this._students = value;
            }
        }

        public Klass(string textID, List<Teacher> teachers, List<Student> students)
        {
            this.TextID = textID;
            this.Teachers = new List<Teacher>();
            this.Students = new List<Student>();
        }
  
    }
}
