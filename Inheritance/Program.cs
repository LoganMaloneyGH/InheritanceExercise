using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var cardinal = new Bird() 
            { 
                Legs = 2, 
                IsLiving = true, 
                HasTail = true, 
                CanSing = true, 
                CanSwim = false, 
                LaysEggs = true,
            };

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var Rattlesnake = new Reptile() 
            { 
                Legs = 0, 
                Color = "green", 
                HasScales = true,
                IsColdBlooded = true, 
                Mobility = "slithers" 
            };

            Bird Penguin = new Bird() 
            { 
                CanFly = false, 
                CanSwim = true, 
                HasFeathers = true, 
                Legs = 2 ,
            };

            cardinal.Printdetails();
            Console.WriteLine();

            Penguin.Printdetails();
            Console.WriteLine();

            Rattlesnake.Printdetails();
            Console.WriteLine(); 
        }
    }
}
