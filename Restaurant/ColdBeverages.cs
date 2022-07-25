using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class ColdBeverages : Beverage
    {
        public ColdBeverages(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        }
    }
}
