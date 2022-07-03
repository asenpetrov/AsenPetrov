using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        //We set a constant for the gender for the specific class.
        private const string DEFAULTGENDER = "Male";
        public Tomcat(string name, int age)
            : base(name, age, DEFAULTGENDER)
        {

        }
        //We override ProduceSound with the specific sound.
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
