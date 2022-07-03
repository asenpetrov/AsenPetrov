using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    //The Cake has 3 Default values (Grams, Calories, Price) -> Calories is a property for the Desserts. 
    public class Cake : Dessert
    {
        const double cakeGrams = 250;
        const double cakeCalories = 1000;
        const decimal cakePrice = 5;

        public Cake(string name)
            : base(name, cakePrice, cakeGrams, cakeCalories)
        {

        }
    }
}
