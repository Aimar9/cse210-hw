using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        // This is prep 2
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your note? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        if (number >= 90)
        {
            Console.WriteLine("A");
        }
        else if (number >= 80)
        {
            Console.WriteLine("B");
        }
        else if (number >= 70)
        {
            Console.WriteLine("C");
        }
        else if (number >= 60)
        {
            Console.WriteLine("D");
        }
        else if (number < 60)
        {
            Console.WriteLine("F");
        }
    }
}