using System;

namespace Guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretwoed = "hello";
            string guess = "";

            int numOfGuesses = 1;

            while ( guess != secretwoed && numOfGuesses <= 3)
            {
                Console.Write("Enter a guess: ");
                guess = Console.ReadLine();

                numOfGuesses++;


            }
            if (guess == secretwoed)
            {
                Console.WriteLine("You win \n it took you "+ (numOfGuesses-1) +" guesses");

            }
            else
            {
                Console.WriteLine("You lose");
            }
        }
    }
}
