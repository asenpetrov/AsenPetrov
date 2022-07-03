using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    //The Food class is a child to Product and has 1 additional property.
    //The Food class has 3 child classes (Starter, MainDish, Dessert). 
    public class Food : Product
    {
        public Food(string name, decimal price, double grams) 
            : base(name, price)
        {
            this.Grams = grams;
        }
        public double Grams { get; set; }
    }
}
