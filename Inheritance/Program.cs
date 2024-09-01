using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
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
           

            Console.WriteLine("=====================Open Book True False Quiz=====================");
            Console.WriteLine("Indicate whether the statement is true or false.");
            int score = 0;
            bool tryAgain = false;
            do
            {
                Console.WriteLine("A parrot has feathers?");

                string answer1 = Console.ReadLine().ToLower();
                if (answer1 == "true")
                {
                    Console.WriteLine($"It is {parrot.HasFeathers} that a parrot has feathers!");
                    score++;
                    tryAgain = false;
                    
                }
                else if (answer1 == "false")
                {
                    Console.WriteLine("Incorrect.");
                    tryAgain = true;
                    score--;
                }
                else 
                {
                    Console.WriteLine("Invalid answer.");
                    tryAgain = true;
                }
            }
            while (tryAgain);
            tryAgain = false;
            do
            {
                Console.WriteLine("A parrot has wings.");
                string answer2 = Console.ReadLine().ToLower();

                if (answer2 == "true")
                {
                    Console.WriteLine($"It is {parrot.HasWings} that a parrot has wings!");
                    score++;
                    tryAgain = false;
                }
                else if ( answer2 == "false")
                {
                    Console.WriteLine("Incorrect.");
                    tryAgain = true;
                    score--;
                }
                else
                {
                    Console.WriteLine("Invalid answer.");
                    tryAgain = true;
                }
            }
            while (tryAgain);
            tryAgain = false;
            do
            {
                Console.WriteLine("A parrot lays eggs.");
                string answer3 = Console.ReadLine().ToLower();

                if (answer3 == "true")
                {
                    Console.WriteLine($"It is {parrot.LaysEggs} that a parrot lays eggs!");
                    score++;
                    tryAgain = false;
                }
                else if (answer3 == "false")
                {
                    Console.WriteLine("Incorrect.");
                    tryAgain = true;
                    score--; 
                }
                else
                {
                    Console.WriteLine("Invalid answer.");
                    tryAgain = true; 
                }               
            }
            while(tryAgain);
            tryAgain =false;
            do
            {
                Console.WriteLine("A parrot sometimes lives in a cage.");
                string answer4 = Console.ReadLine().ToLower();
                if (answer4 == "true")
                {
                    Console.WriteLine($"It is {parrot.HasCage} that a parrot sometimes lives in a cage!");
                    score++;
                    tryAgain=false;
                }
                else if (answer4 == "false")
                {
                    Console.WriteLine("Incorrect.");
                    tryAgain=true;
                    score--;
                }
                else
                {
                    Console.WriteLine("Invalid answer.");
                    tryAgain = true;
                }
            }
            while(tryAgain);
            tryAgain = false;
            do
            {
                Console.WriteLine("A snake lives in a nest.");
                string answer5 = Console.ReadLine().ToLower();
                if ( answer5 == "true")
                {
                    Console.WriteLine("Incorrect.");
                    score--;
                    tryAgain=true;
                }
                else if (answer5 == "false")
                {
                    Console.WriteLine($"It is {snake.HasNest} that a snake lives in a nest!");
                    tryAgain=false;
                    score++;
                }
                else
                {
                    Console.WriteLine("Invalid answer.");
                    tryAgain = true;
                }
            }
            while(tryAgain);
            tryAgain = false;
            do
            {
                Console.WriteLine("A snake has scales.");
                string answer6 = Console.ReadLine().ToLower();
                if (answer6 == "true")
                {
                    Console.WriteLine($"It is {snake.HasScales} that a snake has scales!");
                    score++;
                    tryAgain = false;
                }
                else if (answer6 == "false")
                {
                    Console.WriteLine("Incorrect.");
                    tryAgain=true;
                    score--;
                }
                else
                {
                    Console.WriteLine("Invalid answer.");
                    tryAgain = true;
                }
            }
            while(tryAgain);
            tryAgain = false;
            do
            {
                Console.WriteLine("A snake has a forked tongue.");
                string answer7 = Console.ReadLine().ToLower();
                if (answer7 == "true")
                {
                    Console.WriteLine($"It is {snake.ForkedTongue} that a snake has a forked tongue!");
                    score++;
                    tryAgain = false;
                }
                else if (answer7 == "false")
                {
                    Console.WriteLine("Incorrect.");
                    tryAgain=true;
                    score--;
                }
                else
                {
                    Console.WriteLine("Invalid answer.");
                    tryAgain = true;
                }
            }
            while(tryAgain);
            tryAgain = false;
            do
            {
                Console.WriteLine("A snake has fangs.");
                string answer8 = Console.ReadLine().ToLower();
                if (answer8 == "true")
                {
                    Console.WriteLine($"It is {snake.HasFangs} that a snake has fangs!");
                    score++;
                    tryAgain = false;
                }
                else if (answer8 == "false")
                {
                    Console.WriteLine("Incorrect.");
                    tryAgain=true;
                    score--; 
                }
                else
                {
                    Console.WriteLine("Invalid answer.");
                    tryAgain = true;
                }
            }
            while (tryAgain);
            Console.WriteLine($"Your score is {score} out of 8!");

        
            

        }  
    }
    

    
}
