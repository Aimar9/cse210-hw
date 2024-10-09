using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string response = "yes";
        while (response == "yes")
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 2; i <= 20; i = i + 2)
        {
            Console.WriteLine(i);
        }

        //foreach (string color in colors)
        //{
         //   Console.WriteLine(color);
        //}

        // HOMEWORK

        //Random randomGenerator = new Random();
        //int number = randomGenerator.Next(1, 11);


////////////////////////////////////////////////////

        Console.Write("What is the magic number? ");
        string magic = Console.ReadLine();
        int number1 = int.Parse(magic);
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int number2 = int.Parse(guess);

        if (number1 == number2)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (number1 > number2)
        {
            Console.WriteLine("Higher");
        }
        else if (number1 < number2)
        {
            Console.WriteLine("Lower");
        }

        // While

        Console.Write("What is the magic number? ");
        string mg = Console.ReadLine();
        int num1 = int.Parse(mg);

        string gss = Console.ReadLine();
        int num2 = int.Parse(gss);

        while (num1 == num2)
        {
            Console.Write("What is your guess? ");

            if (num1 < num2)
            {
                Console.WriteLine("Higher");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("Lower");
            }
        }
        Console.WriteLine("You guessed it!");
    }
}