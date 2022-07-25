using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    //We create IBirthdayable and implement it in some of the classes.
    public interface IBirthdayable
    {
        public string BirthDate { get; set; }
    }
}
