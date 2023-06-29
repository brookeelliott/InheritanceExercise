using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var bird = new Bird();
            bird.canFly = false;
            bird.color = "Blue";
            bird.flightless = true;
            bird.hasTail = true;
            bird.LegCount = 2;
            bird.size = "large";

            Console.WriteLine($"This very interesting penguin is {bird.color}, has a tail? {bird.hasTail}, Leg Count? {bird.LegCount}, And is size {bird.size}... weird but okay");


            var reptile = new Reptile();
            reptile.scaleColor = "green";
            reptile.hasEyes = false;
            reptile.canFly = true;
            reptile.hasClaws = true;

            Console.WriteLine($"Okay so this reptile is {reptile.scaleColor}, doesnt have eyes, can fly?? {reptile.canFly}, has claws?? {reptile.hasClaws}... I'm confused but okay");
        }
    }
}

