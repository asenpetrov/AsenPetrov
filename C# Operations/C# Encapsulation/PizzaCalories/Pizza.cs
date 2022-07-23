using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private int numberOfToppings;

        public Pizza(string name)
        {
            this.Name = name;
            this.Toppings = new List<Topping>();
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 15 || string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }
        public List<Topping> Toppings { get; set; }

        public int NumberOfToppings
        {
            get
            {
                return numberOfToppings;
            }
            set
            {
                if (numberOfToppings < 0 || numberOfToppings > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
            }
        }
     
    }
}
