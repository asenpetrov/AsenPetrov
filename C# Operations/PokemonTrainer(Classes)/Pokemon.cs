using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Trainer
{
    public class Pokemon
    {
        //We create the Pokemon class with the respective props.
        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }
        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }
    }
}
