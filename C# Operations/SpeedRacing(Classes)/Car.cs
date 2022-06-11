using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    internal class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionKM;
        private double travelledDistance;

        //We create a constructor for out Car.
        public Car(string model, double fuelAmount, double fuelConsumption, double travelledDistance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
            TravelledDistance = travelledDistance;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double TravelledDistance { get; set; }

        //We add a method to check if a car can travel the given distance or not.
        public void Drive(double distanceToTravel)
        {
            double fuelNeeded = distanceToTravel * this.FuelConsumption;
            if (fuelNeeded>FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                TravelledDistance += distanceToTravel;
                FuelAmount -= fuelNeeded;
            }
        }

    }
}
