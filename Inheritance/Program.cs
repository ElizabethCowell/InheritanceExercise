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
            var raven = new Bird();
            raven.Type = "raven";
            raven.FeatherColors = "black";
            raven.TransportMode = "flying";
            raven.Migrates = false;

            Console.WriteLine($"Here we have the {raven.Type}! \n" +
                $"Their feathers are typically {raven.FeatherColors}. \n" +
                $"They get around by {raven.TransportMode}. \n" +
                $"Do they migate south in the winter? {raven.Migrates}");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var tortoise = new Reptile();
            tortoise.Type = "tortoise";
            tortoise.Diet = "yummy veggies";
            tortoise.HaveHardShell = true;
            tortoise.Habitat = "on land";
            Console.WriteLine($"Say, Hello, to our friend {tortoise.Type}! \n" +
                $"He loves to eat {tortoise.Diet} and mostly lives {tortoise.Habitat}. \n" +
                $"Does he have a hard shell? {tortoise.HaveHardShell}");
        }
    }
}
