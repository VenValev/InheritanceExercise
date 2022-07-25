using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Fish : MainDish
    {
        private const double fGrams = 22;
        public Fish(string name, decimal price) 
            : base(name, price, fGrams)
        {

        }
    }
}
