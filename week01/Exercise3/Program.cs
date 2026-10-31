using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string playing = "yes";

        while (playing == "yes")
        {
            Random random = new Random();
            int number = random.Next(1, 101);

            int count = 0;
            int guess = -1;

            while (guess != number)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                count++;

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"It took you {count} guesses");

            Console.Write("Wouls you like to play again? (yes/no)? ");
            playing = Console.ReadLine();
        }

        Console.WriteLine("Thank you for playing!!");
    }
}