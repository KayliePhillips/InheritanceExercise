using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE Create a class Animal
            // DONE give this class 4 members that all Animals have in common


            // DONE Create a class Bird
            // DONE give this class 4 members that are specific to Bird
            // DONE Set this class to inherit from your Animal Class

            // DONE Create a class Reptile
            // DONE give this class 4 members that are specific to Reptile
            // DONE Set this class to inherit from your Animal Class

            Console.WriteLine("---------------------Bird---------------------------");
            Console.WriteLine();
                /*DONECreate an object of your Bird class
             * DONE give values to your members using the object of your Bird class
             *  
             *DONE Creatively display the class member values 
             */
            var flamingo = new Bird()
            {
                AnimalName = "Flamingo",
                PersonalName = "Fred",
                Age = 4,
                Weight = 7,
                Color = "pink",
                FoodType = "fish",
                NumberofEggs = 2,
                WingSpan = 3
            };

            Console.WriteLine($"One of my favorite animals is the {flamingo.AnimalName}.  At the zoo the {flamingo.Age} year old " +
                $"{flamingo.AnimalName} is named {flamingo.PersonalName}. He weighs {flamingo.Weight} pounds and has a wingspan of" +
                $" {flamingo.WingSpan} feet.  His favorite food is {flamingo.FoodType}.  {flamingo.AnimalName}'s usually lay " +
                $"{flamingo.NumberofEggs} eggs.  Their feathers are usually {flamingo.Color}. ");



            Console.WriteLine();
            Console.WriteLine("---------------------Reptile---------------------------");
            Console.WriteLine();

            /*DONECreate an object of your Reptile class
             * DONE give values to your members using the object of your Reptile class
             *  
             * DONE Creatively display the class member values 
             */

            var snake = new Reptile()
            {
                AnimalName = "Cobra",
                PersonalName = "Carla",
                Age = 2.5,
                Weight = 2,
                LengthOfBody = 3,
                CanSwim = true,
                IsPoisonous = true,
                Color = "brown"

            };

            snake.PrintReptileInfo();
                     

        }
    }
}
