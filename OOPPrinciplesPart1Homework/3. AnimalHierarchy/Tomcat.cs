using System;

namespace _3.AnimalHierarchy
{
    class Tomcat : Cat
    {
        public Tomcat(string name, byte age, string sex): base(name, age, sex)
        {
            if (Sex.ToLower() != "male")
            {
                throw new ArgumentException("Tomcat can only be male");
            }
            this.Sex = sex;
        }

        
    }
}
