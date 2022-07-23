using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
            if (this.Age > 15)
            {
                
            }
        }

        public int Age
        {
            get { return this.Age; }
            set
            {
                if(value > 15)
                {
                    this.Age = 15;
                }
                else
                {
                    this.Age = value;
                }
            }
        }

    }
}
