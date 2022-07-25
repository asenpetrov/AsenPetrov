using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizen : IIdentifier, IBirthdayable
    {
        //We create a class Citizen with appropriate properties which implements IIdentifier interface 
        public Citizen(string name, int age, string id, string birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthDate;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string BirthDate { get; set; }
    }
}
