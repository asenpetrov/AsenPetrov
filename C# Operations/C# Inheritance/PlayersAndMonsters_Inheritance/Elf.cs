using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    //Elf is a child class to Hero and a Parent class to MuseElf

    public class Elf : Hero
    {
        public Elf(string username, int level) : base(username, level)
        {
        }
    }
}
