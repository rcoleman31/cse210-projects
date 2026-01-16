using System;

class Program
{
    static void Main(string[] args)
    {
        // Old code for choosing your own magic number:
        // Console.Write("What is the magic number? ");
        // string input = Console.ReadLine();
        // int number = int.Parse(input);

        Random randomGenerator = new Random();
        string play_again = "yes";

        while (play_again.ToLower() == "yes")
        {
            int number = randomGenerator.Next(1, 101);
            int guess = -1;
            int guess_count = 0; // tracks number of guesses

            Console.WriteLine("I am thinking of a number between 1 and 100.");

            while (guess != number)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                guess_count++;

                if (number > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (number < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You are correct! It took you {guess_count} guesses.");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            play_again = Console.ReadLine();
            Console.WriteLine();
        }

        Console.WriteLine("Thank you for playing!");
        
        


    }
}