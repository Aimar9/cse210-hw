using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;

        foreach (int numberList in numbers)
        {
            sum += numberList;
        }

        Console.WriteLine($"The sum is: {sum}");

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        int largest = numbers[0];

        foreach (int numberList in numbers)
        {
            if (numberList > largest)
            {
                largest = numberList;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");

        int smallest = int.MaxValue;

        foreach (int numberList in numbers)
        {
            if (numberList > 0 && numberList < smallest)
            {
                smallest = numberList;
            }
        }

        Console.WriteLine($"The smallest positive number is: {smallest}");

        numbers.Sort();

        Console.WriteLine("The sorted list is:");

        foreach (int numberList in numbers)
        {
            Console.WriteLine(numberList);
        }
    }
}