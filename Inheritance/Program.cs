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




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myBird = new Bird();
            myBird.Color = "yellow";
            myBird.DoesItFly = true;
            myBird.Fur = false;
            myBird.Legs = 2;
            myBird.Outdoors = true;
            myBird.Region = "Northern Midwest";
            myBird.Size = 6;
            myBird.Sound = "Tweet Tweet";

            Console.WriteLine($"The bird i see in my backyard is {myBird.Color}. I believe its {myBird.DoesItFly} it can fly faster than the others.");
            Console.WriteLine($"This bird has {myBird.Legs} short legs, and I belive it is from the {myBird.Region}. In size, they average {myBird.Size} inches");
            Console.WriteLine($"Listen, can you here it? {myBird.Sound}!");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myRep = new Reptile();
            myRep.Color = "green";
            myRep.Fly = false;
            myRep.Fur = false;
            myRep.Legs = 4;
            myRep.Outdoors = true;
            myRep.Pet = false;
            myRep.Sound = "Burp";
            Console.WriteLine("");
            Console.WriteLine($"Look at this {myRep.Color} lizard I found. You would be {myRep.Outdoors} if you think its a good thing to let him indoors.");
            Console.WriteLine($"Although he has {myRep.Legs} legs, he prefers to walk on 2. He's pretty weird.");
            Console.WriteLine($"All he says is, {myRep.Sound}. See what I mean?");
        }
    }
}
