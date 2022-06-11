using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesMan
{
    internal class Engine
    {
        //We create a constructor for each possible input variation.
        public Engine()
        {

        }
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }
        public Engine(string model, int power, int displacement)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
        }
        public Engine(string model, int power, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Efficiency = efficiency;
        }
        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Efficiency = efficiency;
            this.Displacement = displacement;

        }
        //We add the properties for each engine.
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

    }
}
