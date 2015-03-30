using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    class Animal : ISound
    {
        private string name;
        private byte age;
        private string sex;

        public Animal(string name, byte age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Sex
        {
            get { return sex; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Gender can not be null");
                }
                sex = value;
            }
        }
        

        public byte Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age can not be negative or zero");
                }
                this.age = value;
            }
        }
        

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name can not be null");
                }
                name = value;
            }
        }

        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
        
    }
}
