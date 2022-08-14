using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        //Fields
        private const double defFuelConsumtion = 1.25;
        private double fuelConsumption;
        private double fuel;
        private int horsePower;

        //Constructor
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
            this.FuelConsumption = defFuelConsumtion;
            
        }
        //Properties
        
        
        public virtual double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }
        public double Fuel 
        { 
            get => this.fuel;

            set
            {
                /*if(value < 0)
                {
                    this.fuel = 0;
                }
                else
                {
                    this.fuel = value;
                }*/
                this.fuel = value;
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
        public virtual void Drive(double kilometers)
        {
            while(kilometers > 0)
            {
                if(Fuel - FuelConsumption < 0)
                {
                    break;
                }
                if(kilometers < 1)
                {
                    Fuel -= kilometers * FuelConsumption;
                    kilometers = 0;
                    break;
                }
                kilometers--;
                Fuel -= FuelConsumption;
            }
        }
    }
}
