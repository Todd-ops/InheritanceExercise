using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {

        }
        public string Color { get; set; }
        public bool Tail { get; set; }
        public bool Fly { get; set; }
        public bool Pet { get; set; }

        public void PrintOut()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}