﻿using System;
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
                //throw new ArgumentException();
                this.Age = 15;
            }
        }



    }
}
