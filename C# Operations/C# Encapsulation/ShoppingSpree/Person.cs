using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShoppingSpree
{
    internal class Person
    {
        //we create private fields
        private string name;
        private int money;

        //we initiate our constructor with the name of the person, budget and an empty List<Products>
        public Person(string name, int money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<Product>();
        }

        //We make sure that the input is valid (name not null/empty and money not negative
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
        public int Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public List<Product> Products { get; set; }

        //We create an Override method so we can print all the information for each person at the end.
        public override string ToString()
        {
            if (Products.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
                       
            else
            {
                var products = this.Products.Select(p => p.Name);
                return $"{this.Name} - {string.Join(", ", products)}";
            }
           
        }
    }
}
