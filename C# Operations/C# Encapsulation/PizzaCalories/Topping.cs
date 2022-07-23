using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        //We set our constant modifiers so we can calculate the calories later
        private const double Meat = 1.2;
        private const double Veggies = 0.8;
        private const double Cheese = 1.1;
        private const double Sauce = 0.9;

        //We set 2 fields for type and weight
        private string toppingType;
        private int weight;

        //We initiate the constructor
        public Topping(string toppingType, int weight)
        {
            this.Type = toppingType;
            this.Weight = weight;
        }

        //We make the necessary checks to be sure that the input is correct
        public string Type
        {
            get
            {
                return toppingType;
            }
            set
            {
                string newValue = value.ToLower();
                if (newValue == "meat" || newValue == "veggies" || newValue == "cheese" || newValue == "sauce")
                {
                    toppingType = newValue;
                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }

        //We create a method to calcute the calories for each type of topping
        public double CalculateCalories()
        {
            double rawCalories = weight * 2;
            if (this.Type == "meat")
            {
                rawCalories *= Meat;
            }
            else if (this.Type == "veggies")
            {
                rawCalories *= Veggies;

            }
            else if (this.Type == "cheese")
            {
                rawCalories *= Cheese;

            }
            else if (this.Type == "sauce")
            {
                rawCalories *= Sauce;

            }

            return rawCalories;
        }
    }
}
