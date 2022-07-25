using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverages
    {
        public const double coffeeMilliliters = 50;
        public const decimal coffeePrice = 3.50m;

        private double caffeine;
        public Coffee(string name,double caffeine)
            : base(name, coffeePrice, coffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine
        {
            get { return this.caffeine; }
            set { this.caffeine = value; }
        }
    }
}
