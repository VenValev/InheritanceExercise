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
            this.DefFuelConsumtion = 1.25;
            this.FuelConsumption = defFuelConsumtion;
            
        }
        //Properties
        public double DefFuelConsumtion 
        { 
            get => this.defFuelConsumtion;
            set => this.defFuelConsumtion = value;
        }
        
        virtual public double FuelConsumption
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
            /*while(kilometers > 0)
            {
                if(Fuel - FuelConsumption < 0)
                {
                    break;
                }
                kilometers--;
                Fuel -= FuelConsumption;
            }*/

            Fuel = kilometers * FuelConsumption;
        }
    }
}
