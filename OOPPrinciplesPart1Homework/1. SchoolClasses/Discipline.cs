using System;
namespace _1.SchoolClasses
{
    class Discipline : School, IComment
    {
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures = 0, int numberOfExercises = 0) :  base(name)
        {
            
        }

        public int NumberOfExercises
        {
            get { return numberOfExercises; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of exercises can not be negative");
                }
                this.numberOfExercises = value;
            }
        }

        public int NumberOfLectures
        {
            get { return numberOfLectures; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of lectures can not be negative");
                }
                this.numberOfLectures = value;
            }
        }

        public string Comment { get; private set; }

        public void AddComment(string text)
        {
            this.Comment = text;
        }

        public override string ToString()
        {
            return string.Format("Discipline: {0} Number of lectures: {1} Number of exercises: {2}", this.Name, this.NumberOfLectures, this.NumberOfExercises);
        }
    }
}
