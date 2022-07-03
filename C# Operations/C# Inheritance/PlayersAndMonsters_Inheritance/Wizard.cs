using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    //Wizard is a child class to Hero and a Parent class to DarkWizard.

    public class Wizard : Hero
    {
        public Wizard(string username, int level) : base(username, level)
        {
        }
    }
}
