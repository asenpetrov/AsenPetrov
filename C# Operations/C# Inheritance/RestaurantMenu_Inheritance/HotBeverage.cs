using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    //HotBeverage is a child class to Beverage, but it has no additional properties.
    public class HotBeverage : Beverage
    {
        public HotBeverage(string name, decimal price, double milliliters) 
            : base(name, price, milliliters)
        {

        }
    }
}
