using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    //Hero is the base class from which we shall create the specific heroes.
    //It has 2 properties and an override Method.
    public class Hero
    {
       
        public Hero(string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }
        public string Username { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
