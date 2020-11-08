using System;
using static System.Console;

namespace Module_3_Guessing_Game
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            //create definite loop constant
            const int MAX_GUESSES = 10;

            //create variables
            int system_guess;
            int user_guess;
            int counter = 1;
            bool gotIt = false;

            //create random number class
            Random random = new Random();
            system_guess = random.Next(1, 101);

            //guessing loop
            while (counter <= MAX_GUESSES) {
                Write("Please enter a number between 1 and 100: ");

                //retrieve number from the user
                user_guess = int.Parse(ReadLine());

                //decide if user guessed the correct number
                if (system_guess == user_guess)
                {
                    WriteLine($"The number is {user_guess} - you guessed it!");
                    gotIt = true;
                    break;

                }
                else if (system_guess < user_guess) {
                    WriteLine("Wrong answer! Go Lower!");
                }
                else if (system_guess > user_guess){
                    WriteLine("Wrong answer! Go Higher!");
                }
                counter++;
            }
            if (gotIt == true)
            {
                WriteLine("You won! Goodbye!");
            }
            else {
                WriteLine($"Sorry you lost. The number was {system_guess}! Goodbye!");
            }
        }
    }
}
