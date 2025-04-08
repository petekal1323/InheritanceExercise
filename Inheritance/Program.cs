using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var birdOne = new Bird();
            birdOne.WingColor = "Blue";
            birdOne.CanFly = true;
            birdOne.WillMigrate = true;
            birdOne.BeakLength = 5.5;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var lizardOne = new Reptile()
            {
                isColdBlooded = true,
                isScaly = true,
                habitat = "Desert",
                canGrowTail = true
            };

            var myAnimals = new Animal[] {birdOne, lizardOne};
            
            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Animal is alive: {animal.isAlive}");
                Console.WriteLine($"Animal Age: {animal.Age}");
                Console.WriteLine($"Animal Leg Count: {animal.LegCount}");
                Console.WriteLine($"Animal Land, Sea, or Air: {animal.LandSeaAir}");
                Console.WriteLine($"");
            }


        }
    }
}
