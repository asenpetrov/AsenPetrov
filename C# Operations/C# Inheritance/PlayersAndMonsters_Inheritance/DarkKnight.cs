using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    //DarkKnight is a child class to Knight and a Parent class to BladeKnight
    public class DarkKnight : Knight
    {
        public DarkKnight(string username, int level) 
            : base(username, level)
        {
        }
    }
}
