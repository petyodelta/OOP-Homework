﻿using System;

namespace _1.SchoolClasses
{
    class Human
    {
        private string name;

        public Human(string name)
        {
            this.Name = name;
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
                this.name = value;
            }
        }
        
    }
}
