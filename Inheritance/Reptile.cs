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

        public void PrintReptileInfo()
        {
            Console.WriteLine($"Species: {AnimalName}");
            Console.WriteLine($"Name: {PersonalName}");
            Console.WriteLine($"Age: {Age} years");
            Console.WriteLine($"Weight: {Weight} pounds");
            Console.WriteLine($"Length of Body: {LengthOfBody} feet");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Can it swim? {CanSwim}");
            Console.WriteLine($"Is it poisonous? {IsPoisonous}");
            
        }



    }

   
}
