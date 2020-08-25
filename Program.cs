using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMessage();
        }

        static void DisplayMessage()
        {
            Console.Write("Guess a number. ");
            string response = Console.ReadLine();
            Console.WriteLine(response);
        }
    }
}