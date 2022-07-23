using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private double defFuelConsumtion;
        private double fuelConsumption;
        private double fuel;
        private int horspePower;


        public Vehicle(int horsePower, double fuel)
        {

        }

        public double DefFuelConsumtion 
        { 
            get => this.defFuelConsumtion;
            set => this.defFuelConsumtion = value;
        }


        virtual public void Drive(double kilometers)
        {

        }
    }
}
