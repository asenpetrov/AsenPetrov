using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesMan
{
    internal class Car
    {
        //We create a constructor for each possible input variation.
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }
        public Car(string model, Engine engine, int weight)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
        }
        public Car(string model, Engine engine, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Color = color;
        }
        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight= weight;
            this.Color = color;
        }
        //We create the properties for each Car.
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        
    }
}
