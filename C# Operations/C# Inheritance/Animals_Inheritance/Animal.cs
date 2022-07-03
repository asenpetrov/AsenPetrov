using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    //We create an abstract class Animal.
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        //We put some constraints for the properties.
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(nameof(this.Name), "Invalid input!");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(nameof(this.Age), "Invalid input!");
                }
                this.age = value;
            }
        }
        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(nameof(this.Gender), "Invalid input!");
                }
                this.gender = value;
            }
        }

        //No Default behaviour.
        //Behaviour will be defined in the inherited class.
        public abstract string ProduceSound();

        //We create ToString method which will be used in the end of our program.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.AppendLine($"{this.ProduceSound()}");

            return sb.ToString().Trim();

        }
    }
}
