using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! What difficulty level would you like?");
            Console.WriteLine("1) Easy");
            Console.WriteLine("2) Medium");
            Console.WriteLine("3) Hard");
            Console.WriteLine("4) Insane");
            Console.WriteLine();
            string difficultyResponse = Console.ReadLine();

            int maxBound;
            if (difficultyResponse == "1" || difficultyResponse == "Easy" || difficultyResponse == "1) Easy")
            {
                maxBound = 10;
            }
            else if(difficultyResponse == "2" || difficultyResponse == "Medium" || difficultyResponse == "2) Medium")
            {
                maxBound = 100;
            }
            else if (difficultyResponse == "3" || difficultyResponse == "Hard" || difficultyResponse == "3) Hard")
            {
                maxBound = 1000;
            }
            else
            {
                maxBound = 1000000;
            }

            Random randomNumberGenerator = new Random();
            int secretNumber = randomNumberGenerator.Next(1, maxBound + 1); // plus 1 because upper bound is exclusive

            Console.WriteLine($"Please enter a guess between 1 and {maxBound}: ");
            string response = Console.ReadLine();
            int guess = int.Parse(response);

            if (guess == secretNumber)
            {
                Console.WriteLine("That's right!");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("That's too high!");
            }
            else
            {
                Console.WriteLine("That's too low!");
            } 

        }
    }
}
