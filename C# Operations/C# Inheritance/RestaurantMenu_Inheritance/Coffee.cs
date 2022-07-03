using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    //Coffee is a child class to HotBeverage and it has 1 additional property (Caffeine)
    //and 2 Default properties (Price and Milliliters).
    public class Coffee : HotBeverage
    {
        const double CoffeeMilliliters = 50;
        const decimal CoffeePrice = 3.50m;
        public Coffee(string name, double caffeine)
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }
      
        public double Caffeine { get; set; }
    }
}
