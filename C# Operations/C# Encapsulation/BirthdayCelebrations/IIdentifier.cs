using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    //We create IIdentifier and implement it in some of the classes.
    public interface IIdentifier
    {
        public string Id { get; set; }
    }
}
