using System;

namespace _3.AnimalHierarchy
{
    class Kitten : Cat
    {
        public Kitten(string name, byte age, string sex): base(name, age, sex)
        {
            if (Sex.ToLower() != "female")
            {
                throw new ArgumentException("Kitten can only be female");
            }
            this.Sex = sex;
        }

        
    }
}
