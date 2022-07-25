using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IIdentifier
    {
        //We create IIdentifier and implement it in some of the classes.
        public string Id { get; set; }
    }
}
