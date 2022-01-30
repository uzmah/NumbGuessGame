using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace name: NumbGuessGame
namespace NumbGuessGame
{
    // Main Class
    class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guessing Number Game!");
            // Calling GetAppInfo function to get info
            GetAppInfo();

            // Calling GreetUser function to greet user with user name
            GreetUser();

            //While loop until it is true
            while (true)
            {
                // Creating a new Random object
                Random random = new Random();

                // Random integer correct number
                int RandNumber = random.Next(1, 10);

                // Initializing guess into to zero
                int guess = 0;

                // Asking user for number between 1 and 10
                Console.WriteLine("Guess a number between 1 and 10");

                // While loop runs until guess number is not correct radom number
                while (guess != RandNumber)
                {
                    // Taking string user input
                    string input = Console.ReadLine();

                    // Making sure it is a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message if user doesnt enter actual number
                        PrintColorMessage(ConsoleColor.DarkBlue, "Please use an actual number");

                        // continue-keep going
                        continue;
                    }

                    // Cast to int and put in guess variable
                    guess = int.Parse(input);

                    // Match guess to correct random number
                    if (guess != RandNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Green, "CORRECT!! You guessed it!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    Console.WriteLine("Thanks for playing Number Guessing Game!");
                    Console.ReadLine();
                    return;
                }
                else if (answer != "Y")

                {
                    Console.WriteLine("Thanks for playing Number Guessing Game!");
                    Console.ReadLine();
                    return;
                }
            }

        }

        // Get and display app info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guess Game";
            string appVersion = "1.1";
            string appAuthor = "Uzma Hanif";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser()
        {

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}

