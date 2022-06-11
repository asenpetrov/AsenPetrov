using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    internal class Engine
    {
        //We create the Engine class with props and ctor.

        public int Speed { get; set; }
        public int Power { get; set; }

        public Engine(int engineSpeed, int enginePower)
        {
            this.Speed = engineSpeed;
            this.Power = enginePower;
        }
    }
}
