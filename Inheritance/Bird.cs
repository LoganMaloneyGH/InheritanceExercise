using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public Bird()
        {

        }

        public bool CanFly { get; set; } = true; 
        public bool HasFeathers { get; set; } = true;

        public bool CanSing { get; set; } = false;

        public bool LaysEggs { get; set; } = true; 

        public void Printdetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Can Fly: {CanFly}");
            Console.WriteLine($"Can Sing: {CanSing}");
            Console.WriteLine($"can Swim: {CanSwim}"); 
        }
    }
}
