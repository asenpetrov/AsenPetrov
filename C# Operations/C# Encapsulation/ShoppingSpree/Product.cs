using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        //we create private fields
        private string name;
        private int price;

        //we initiate our constructor with the name of the person and price
        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        //We make sure that the input is valid (name not null/empty and price not negative
        public string Name 
        { 
            get 
            {
                return name;   
            }
            set 
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                name = value;
            } 
        }
        public int Price 
        {
            get 
            {
                return price;
            } 
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                price = value;
            } 
        }
    }
}
