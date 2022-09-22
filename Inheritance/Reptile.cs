using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    //give this class 4 members that are specific to Reptile
    internal class Reptile : Animal
    {
        public double LengthOfBody { get; set; }
        public bool CanSwim { get; set; }
        public bool IsPoisonous { get; set; }

        public string Color { get; set; }
    }
}
