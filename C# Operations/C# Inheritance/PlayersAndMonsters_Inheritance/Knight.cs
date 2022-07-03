using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    //Knight is a child class to Hero and a Parent class to DarkKnight
    public class Knight : Hero
    {
        public Knight(string username, int level)
            : base(username, level)
        {
        }
    }
}
