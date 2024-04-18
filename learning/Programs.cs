using System;

namespace learning
{
    class Programs
    {
        public static void RunGame()
        {
            string secretWord = "test";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuess = false;

            while (guess != secretWord && !outOfGuess)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter the secret word ");
                    guess = Console.ReadLine();
                    guessCount++;
                    Console.WriteLine("Try again " + (guessLimit - guessCount) + " chances left");
                }
                else
                {
                    outOfGuess = true;

                }
            }
            if (outOfGuess)
            {
                Console.WriteLine("YOU LOST!!!");
            }
            else {
                Console.WriteLine("YOU WON!!!");

            }
            Console.ReadLine();
        }
    }
}