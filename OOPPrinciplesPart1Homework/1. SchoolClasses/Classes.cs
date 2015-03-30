using System;
using System.Collections.Generic;
using System.Text;

namespace _1.SchoolClasses
{
    class Classes : School, IComment
    {
        private Teacher[] setOfTeachers;
        

        public Classes(string name, Teacher[] setOfTeachers)
            : base(name)
        {
            this.Teachers = setOfTeachers;
        }

        public Teacher[] Teachers
        {
            get
            {
                return this.setOfTeachers;
            }
            private set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                setOfTeachers = value;
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
            sb.Append("Class Identifier: " + this.Name + " ");
            foreach (var item in setOfTeachers)
            {
                sb.Append(item + " ");
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
