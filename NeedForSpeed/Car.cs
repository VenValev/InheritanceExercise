﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(int horsePower, decimal fuel) 
            : base(horsePower, fuel)
        {

        }
        public override decimal FuelConsumption
        {
            get => base.FuelConsumption; 
            set => base.FuelConsumption = 3m;
        }
    }
}
