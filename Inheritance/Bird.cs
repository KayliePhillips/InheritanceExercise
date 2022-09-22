using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    //give this class 4 members that are specific to Bird
    internal class Bird : Animal
    {
        public string Color { get; set; }
        public string FoodType { get; set; }

        public int NumberofEggs { get; set; }

        public int WingSpan { get; set; }
    }

    
}
