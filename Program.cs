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
            int secretNum = new Random().Next(0, 101);
            int guessesLeft = 4;
            Console.WriteLine(secretNum);
            for (int i = 0; i < 4; i++)
            {

                Console.Write("Guess a number.");
                string response = Console.ReadLine();

                if (int.Parse(response) == secretNum)
                {
                    Console.WriteLine($"You guessed it, {int.Parse(response)}!");
                    return;
                }
                else if (int.Parse(response) > secretNum)
                {
                    guessesLeft--;
                    Console.WriteLine($"Your guess {int.Parse(response)} was too high. Try again... You have {guessesLeft} guesses left.");
                }
                else
                {
                    guessesLeft--;
                    Console.WriteLine($"Your guess {int.Parse(response)} was too low. Try again... You have {guessesLeft} guesses left.");
                }
            }

        }

    }
}