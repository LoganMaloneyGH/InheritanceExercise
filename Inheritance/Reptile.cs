using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal 
    {
        public Reptile()
        {

        }

        public bool IsColdBlooded { get; set; } = true;
        public string Mobility { get; set; }  
        public string Color { get; set; }
        public bool HasScales { get; set; } = true; 

        public void Printdetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Is Cold-Blooded: {IsColdBlooded}");
            Console.WriteLine($"slithers: {Mobility}");
            Console.WriteLine($"green: {Color}");
            Console.WriteLine($"true: {HasScales}"); 
        }
    }
}
