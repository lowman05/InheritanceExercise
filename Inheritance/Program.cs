using System;
using System.Security.Cryptography.X509Certificates;

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

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var parrot = new Bird();

            parrot.HasFeathers = true;
            parrot.HasWings = true;
            parrot.LaysEggs = true;
            parrot.HasNest = false;
            parrot.LegCount = 2;
            parrot.EyeCount = 2;
            parrot.HasCage = true;
            Console.WriteLine($"Is it true or false that a parrot has feathers?  It is {parrot.HasFeathers}!");
            Console.WriteLine($"Is it true or false that a parrot has wings?  It is {parrot.HasWings}!");
            Console.WriteLine($"Is it true or false that a parrot lays eggs?  It is {parrot.LaysEggs}!");
            Console.WriteLine($"Is it true or false that a parrot lives in a cage?  It is {parrot.HasCage}!");

            var snake = new Reptile();

            snake.HasNest = false;
            snake.HasScales = true;
            snake.ForkedTongue = true;
            snake.HasFangs = true;
            snake.LegCount = 0;

            Console.WriteLine($"Is it true or false that a snake lives in a nest?  It is {snake.HasNest}!");
            Console.WriteLine($"Is it true or false that a snake has scales?  It is {snake.HasScales}!");
            Console.WriteLine($"Is it true or false that a snake has a forked tongue?  It is {snake.ForkedTongue}!");
            Console.WriteLine($"Is it true or false that a snake has fangs?  It is {snake.HasFangs}!");


        }  
    }
}
