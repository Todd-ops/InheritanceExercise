using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }
        public bool DoesItFly { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public string Region { get; set; }
    }
}
