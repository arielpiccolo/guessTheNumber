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

            //call app details (located at the botton)
            GetAppInfo();

            // ask for user name and greet
            GreetPlayer();


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

                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "That is not a number, please enter a number");

                        // stay inside the loop
                        continue;
                    }


                    // cast to int and put in guess (parsing the guessed number)
                    guess = Int32.Parse(guessedNumber);


                    // if guessed != correct number do
                    if (guess != correctNumber)
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number please try again!");

                    }
                }

                // if guessed number matched
                // changing text colour

                PrintColorMessage(ConsoleColor.Yellow, "That's correct you Win!");


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
                    return;
                }

                else
                {
                    return;
                }
            }
        }


        // Display app info 
        static void GetAppInfo()
        {
            // set app vars
            string appName = "Guess The Number";
            string appVersion = "1.0.0";
            string appAuthor = "Ariel";

            // changing text colour
            Console.ForegroundColor = ConsoleColor.Green;


            // log out app info
            Console.WriteLine("App: {0}, Version: {1}, by {2}", appName, appVersion, appAuthor);

            // terminal colour back to default
            Console.ResetColor();
        }


        //ask player name and greet
        static void GreetPlayer()
        {

            // ask players name
            Console.WriteLine("What is your Name?");

            // get players input and save it into variable playerName
            string playersName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game", playersName);
        }

        // print colour message
        static void PrintColorMessage(ConsoleColor color, string message) {

            // changing text colour
            Console.ForegroundColor = color;


            // log out app info
            Console.WriteLine(message);

            // terminal colour back to default
            Console.ResetColor();
        }
    }
}
