using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double fc = 10.0;
        public SportCar(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
            //this.FuelConsumption = fc;
        }
        public override double FuelConsumption
        {
            get => fc;
        }
    }
}
