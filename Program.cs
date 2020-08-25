using System;

namespace guessing_game
{
    class Program
    {
        static int secretNum = new Random().Next(0, 101);
        static int guessesLeft;
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
                guessesLeft = 8;
                NumberOfGuesses(guessesLeft);
            }
            else if (difficultyResponse == "medium")
            {
                guessesLeft = 6;
                NumberOfGuesses(guessesLeft);
            }
            else if (difficultyResponse == "hard")
            {
                guessesLeft = 4;
                NumberOfGuesses(guessesLeft);
            }
            else if (difficultyResponse == "cheater")
            {
                guessesLeft = int.MaxValue;
                NumberOfGuesses(guessesLeft);
            }

        }

        static void NumberOfGuesses(int NumOfGuesses)
        {
            for (int i = 0; i < NumOfGuesses; i++)
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
                    NumOfGuesses--;
                    Console.WriteLine($"Your guess { int.Parse(response) } was too high.Try again...You have { NumOfGuesses } guesses left. ");
                }
                else
                {
                    NumOfGuesses--;
                    Console.WriteLine($"Your guess { int.Parse(response) } was too low.Try again...You have { NumOfGuesses } guesses left.");
                }
            }
        }

    }
}