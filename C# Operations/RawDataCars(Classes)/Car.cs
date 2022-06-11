using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    internal class Car
    {
        //We create the Car class with fields and the other Classes.
        private string model;
        public Engine engine;
        public Cargo cargo;
        public List<Tyres> tyres;
        
        public Car(string model, Engine engine, Cargo cargo, List<Tyres> tyres)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tyres = tyres;

        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tyres> Tyres { get; set; }




    }
}
