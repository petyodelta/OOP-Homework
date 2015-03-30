using System;
using System.Linq;

namespace _3.AnimalHierarchy
{
    class AnimalHierarchy
    {
        static void Main()
        {
            Animal[] animals = new Animal[]
            {
                new Dog("Sharo", 5, "Male"),
                new Dog("Rex", 3, "Male"),
                new Dog("Dora", 6, "Female"),
                new Dog("Lasi", 9, "Female"),
                 new Cat("Tigar", 4, "Male"),
                new Cat("Bobo", 7, "Male"),
                new Cat("Pupi", 2, "Female"),
                new Cat("Gabi", 8, "Female")
            };
            animals[0].Sound();
            animals[7].Sound();
            double dogAverage = animals.Where(animal => animal is Dog).Average(x => x.Age);
            double catAverage = animals.Where(animal => animal is Cat).Average(x => x.Age);

            Console.WriteLine("Dog's average age is {0}",dogAverage);
            Console.WriteLine("Cat's average age is {0}",catAverage);
        }
    }
}
