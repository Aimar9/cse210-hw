using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayMessage();

        DisplayPersonalMessage("Maria");

        int result = AddNumbers(5, 3);

        Console.WriteLine(result);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Hello World!");
    }

    static void DisplayPersonalMessage(string userName)
    {
        Console.WriteLine("Hello " + userName);
    }
    static int AddNumbers(int first, int second)
    {
        int sum = first + second;
        return sum;
    }
}