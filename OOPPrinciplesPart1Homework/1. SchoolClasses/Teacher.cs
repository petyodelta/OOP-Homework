using System;
using System.Collections.Generic;
using System.Text;

namespace _1.SchoolClasses
{
    class Teacher : Human, IComment
    {
        private Discipline[] setOFDisciplines;
        
        public Teacher(string name, Discipline[] setOfDisciplines)
            : base(name)
        {
            this.Disciplines = setOfDisciplines;
        }

        public Discipline[] Disciplines
        {
            get
            {
                return this.setOFDisciplines;
            }
            private set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.setOFDisciplines = value;
            }
        }

        public string Comment { get; private set; }

        public void AddComment(string text)
        {
            this.Comment = text;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Teacher name: " + this.Name + " ");
            foreach (var item in setOFDisciplines)
            {
                sb.Append(item + " ");
            }
            return sb.ToString();
        }
    }
}
