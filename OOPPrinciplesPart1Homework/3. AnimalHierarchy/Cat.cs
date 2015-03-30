using System;

namespace _3.AnimalHierarchy
{
    class Cat : Animal
    {
        public Cat(string name, byte age, string sex) : base(name, age, sex)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Myau");
        }
    }
}
