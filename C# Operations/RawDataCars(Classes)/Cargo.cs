using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    internal class Cargo
    {
        //We create the Cargo class with props and ctor.
        public string TypeCargo { get; set; }
        public int WeightCargo { get; set; }

        public Cargo(string type, int weight)
        {
            this.TypeCargo = type;
            this.WeightCargo = weight;
        }

    }
}
