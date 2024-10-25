using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        
        string reference = "Proverbs 3:5-6 ";
        string scripture = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        
        ShowScripture(reference, scripture);

        while (true)
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture = HideWords(scripture);
            ShowScripture(reference, scripture);

        }
    }

    static void ShowScripture(string reference, string scripture)
    {
        Console.Clear();
        Console.WriteLine($"{reference}: {scripture}\n");
    }

    static string HideWords(string scripture)
    {
        string[] words = scripture.Split(' ');
        Random rand = new Random();
        int WordsForHide = rand.Next(1, Math.Min(4, words.Length)); 

        for (int i = 0; i < WordsForHide; i++)
        {
            int index = rand.Next(words.Length);
            if (!words[index].Contains("_"))
            {
                words[index] = new string('_', words[index].Length);
            }
        }

        return string.Join(" ", words);
    }

    static bool AllWords(string scripture)
    {
        return  scripture.Split(' ').All(p => p.Contains("_")); 
    
    }
}