using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "y";
        while (playAgain == "y")
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 100);

            int guessNum = 534;

            int guessAmount = 0;

            while (guessNum != magicNum)
            {
                Console.Write("What is your guess? ");
                guessNum = int.Parse(Console.ReadLine());

                guessAmount ++;

                if (guessNum > magicNum)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNum < magicNum)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessAmount} tries");
                    Console.Write("\nWould you like to play again? (y/n)");
                    playAgain = Console.ReadLine();
                }
            }
        
        }
    }    
}