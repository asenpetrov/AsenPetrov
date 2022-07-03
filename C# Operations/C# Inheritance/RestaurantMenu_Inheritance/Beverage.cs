using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    //The Beverage class is a child to Product and has 1 additional property.
    public class Beverage : Product
    {
        public Beverage(string name, decimal price, double milliliters) 
            : base(name, price)
        {
            this.Milliliters = milliliters;
        }
        public double Milliliters  { get; set; }
    }
}
