using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    //We create the base class Product with only 2 properties.
    public class Product
    {
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;

        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
