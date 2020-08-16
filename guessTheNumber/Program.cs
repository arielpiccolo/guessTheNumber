using System;
using System.Runtime.CompilerServices;



// namespace (container)
namespace guessTheNumber
{
    // main class
    class Program
    {   
        // entry point method
        static void Main(string[] args)
        {

            // set app vars
            string appName = "Guess The Number";
            string appVersion = "1.0.0";
            string appAuthor = "Ariel";

            // changing text colour
            Console.ForegroundColor = ConsoleColor.Green;


            // log out app info
            Console.WriteLine("App: {0}, Version: {1}, by {2}", appName,appVersion,appAuthor);

            // terminal colour back to default
            Console.ResetColor();

            // ask players name
            Console.WriteLine("What is your Name?");

            // get players input and save it into variable playerName
            string playersName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game", playersName);

            while (true)
            {

                // create a random number    
                Random random = new Random();

                // set correct number
                int correctNumber = random.Next(1, 10);

                // set guess var
                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 and 10");


                // loop until the player guess the correct number
                while (guess != correctNumber)
                {
                    // player guessed number
                    string guessedNumber = Console.ReadLine();


                    // force the input to be a number only

                    if (!int.TryParse(guessedNumber, out guess))
                    {
                        // changing text colour
                        Console.ForegroundColor = ConsoleColor.Blue;


                        // log out app info
                        Console.WriteLine("That's not a number try again.");

                        // terminal colour back to default
                        Console.ResetColor();

                        // keep inside the loop
                        continue;
                    }


                    // cast to int and put in guess (parsing the guessed number)
                    guess = Int32.Parse(guessedNumber);


                    // if guessed != correct number do
                    if (guess != correctNumber)
                    {
                        // changing text colour
                        Console.ForegroundColor = ConsoleColor.Red;


                        // log out app info
                        Console.WriteLine("Wrong Number please try again!");

                        // terminal colour back to default
                        Console.ResetColor();

                    }
                }

                // if guessed number matched
                // changing text colour
                Console.ForegroundColor = ConsoleColor.Yellow;


                // log out app info
                Console.WriteLine("Your are correct, You Win!!!");

                // terminal colour back to default
                Console.ResetColor();


                // ask player  to play again
                Console.WriteLine("[Play again Y/N]");

                // get answer and for into upper case
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }

                else if (answer == "N")
                {
                    continue;
                }

                else
                {
                    return;
                }
            }
        }
    }
}
