﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base(name, age, gender)
        {

        }

        //We override ProduceSound with the specific sound.
        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
