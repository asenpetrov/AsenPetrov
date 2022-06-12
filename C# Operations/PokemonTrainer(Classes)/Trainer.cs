using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Trainer
{
    public class Trainer
    {
        //We create the Trainer class with the respective props (+ the Pokemon class).

        public Trainer(string name, int badges, List<Pokemon> pokemons)
        {
            this.Name = name;
            this.Badges = badges;
            this.Pokemons = pokemons;
        }
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}
