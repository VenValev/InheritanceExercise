using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        //Fields
        private decimal defFuelConsumtion;
        private decimal fuelConsumption;
        private decimal fuel;
        private int horsePower;

        //Constructor
        public Vehicle(int horsePower, decimal fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
            this.DefFuelConsumtion = 1.25m;
            this.FuelConsumption = defFuelConsumtion;
            
        }
        //Properties
        public decimal DefFuelConsumtion 
        { 
            get => this.defFuelConsumtion;
            set => this.defFuelConsumtion = value;
        }
        
        virtual public decimal FuelConsumption
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
        public decimal Fuel 
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
        virtual public void Drive(decimal kilometers)
        {
            while(kilometers > 0)
            {
                if(Fuel - FuelConsumption < 0)
                {
                    break;
                }
                kilometers--;
                Fuel -= FuelConsumption;
            }

            
        }
    }
}
