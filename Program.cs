using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {

            SecretNumber();
        }

        static void SecretNumber()
        {
            int secretNum = 42;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Guess a number.");
                string response = Console.ReadLine();
                if (int.Parse(response) == secretNum)
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
}