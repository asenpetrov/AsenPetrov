using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    //the Fish class has a Default value for the Grams.
    public class Fish : MainDish
    {
        const double fishGrams = 22;
        public Fish(string name, decimal price)
            : base(name, price, fishGrams)
        {
        }
    }
}
