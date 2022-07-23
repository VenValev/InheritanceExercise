using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        //Fields
        private double defFuelConsumtion;
        private double fuelConsumption;
        private double fuel;
        private int horsePower;

        //Constructor
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }
        //Properties
        public double DefFuelConsumtion 
        { 
            get => this.defFuelConsumtion;
            set => this.defFuelConsumtion = 1.25;
        }
        
        virtual public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = this.DefFuelConsumtion;
            }
        }
        public double Fuel 
        { 
            get => this.fuel;

            set
            {
                if(value < 0)
                {
                    this.fuel = 0;
                }
                else
                {
                    this.fuel = value;
                }
            }
        }
        public int HorsePower 
        {
            get 
            { 
                return this.horsePower; 
            }
            set
            {
                horsePower = value;
            }
        }

        //Methods
        virtual public void Drive(double kilometers)
        {
            while(Fuel - (kilometers * this.FuelConsumption) > 0)
            {
                Fuel -= kilometers * this.FuelConsumption;
            }
        }
    }
}
