using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess a number. ");
            string response = Console.ReadLine();
            SecretNumber(int.Parse(response));
        }

        static void SecretNumber(int userGuess)
        {
            int secretNum = 42;
            if (userGuess == secretNum)
            {
                Console.WriteLine("You guessed it!");
            }
            else
            {
                Console.WriteLine("Sorry, try again...");
            }
        }

    }
}