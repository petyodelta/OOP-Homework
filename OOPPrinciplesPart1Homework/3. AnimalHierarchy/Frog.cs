using System;

namespace _3.AnimalHierarchy
{
    class Frog : Animal
    {
        public Frog(string name, byte age, string sex) : base(name, age, sex)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Kvak");
        }
    }
}
