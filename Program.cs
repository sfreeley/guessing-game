using System;

namespace guessing_game
{
    class Program
    {
        static int secretNum = new Random().Next(0, 101);

        static void Main(string[] args)
        {
            SecretNumber();
        }

        static void SecretNumber()
        {
            Console.WriteLine(secretNum);
            Console.WriteLine("What do you want your difficulty level to be? Easy? 8 guesses; Medium? 6 guesses; Hard? 4 guesses; CHEATER? Unlimited guesses.");
            string difficultyResponse = Console.ReadLine().ToLower();
            while (difficultyResponse != "easy" && difficultyResponse != "medium" && difficultyResponse != "hard" && difficultyResponse != "cheater")
            {
                Console.WriteLine("Your response needs to be 'Easy, Medium, Hard, OR Cheater'");
                Console.WriteLine("What do you want your difficulty level to be? Easy? 8 guesses; Medium? 6 guesses; Hard? 4 guesses; CHEATER? Unlimited guesses.");
                difficultyResponse = Console.ReadLine().ToLower();
            }

            if (difficultyResponse == "easy")
            {
                NumberOfGuesses(8);
            }
            else if (difficultyResponse == "medium")
            {

                NumberOfGuesses(6);
            }
            else if (difficultyResponse == "hard")
            {

                NumberOfGuesses(4);
            }
            else if (difficultyResponse == "cheater")
            {
                NumberOfGuesses(int.MaxValue);
            }

        }

        static void NumberOfGuesses(int guesses)
        {
            int remainingGuesses = guesses - 1;
            int whatGuess = 0;
            for (int i = 0; i < guesses; i++)
            {
                Console.Write("Guess a number between 1 and 100. ");
                string response = Console.ReadLine();
                whatGuess++;

                if (int.Parse(response) == secretNum)
                {
                    Console.WriteLine($"You guessed it, {int.Parse(response)}!");
                    return;
                }
                else if (int.Parse(response) > secretNum)
                {
                    Console.WriteLine($"Your guess { int.Parse(response) } was too high. This is guess number {whatGuess} . You have {remainingGuesses--} guesses left.");
                    if (whatGuess != guesses)
                    {
                        Console.WriteLine("Try Again!");
                    }
                }
                else
                {
                    Console.WriteLine($"Your guess { int.Parse(response) } was too low. This is guess number {whatGuess}. You have { remainingGuesses--} guesses left.");
                    if (whatGuess != guesses)
                    {
                        Console.WriteLine("Try Again!");
                    }
                }
            }
        }

    }
}