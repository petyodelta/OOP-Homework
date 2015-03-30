using System;

namespace _3.AnimalHierarchy
{
    class Dog : Animal
    {
        public Dog(string name, byte age, string sex) : base(name, age, sex)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Bau");
        }
    }
}
