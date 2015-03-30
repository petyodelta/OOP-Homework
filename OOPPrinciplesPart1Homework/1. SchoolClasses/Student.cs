using System;

namespace _1.SchoolClasses
{
    class Student : Human, IComment
    {
        private int classNumber;


        public Student(string name, int classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get { return classNumber; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Student number can not be negative number or zero");
                }
                this.classNumber = value;
            }
        }

        public string Comment { get; private set; }

        public void AddComment(string text)
        {
            this.Comment = text;
        }

        public override string ToString()
        {
            return string.Format("Student name: {0} Class Number: {1}", Name, ClassNumber);
        }
    }
}
