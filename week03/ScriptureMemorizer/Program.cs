using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // Create a scripture reference and text
        Reference reference = new Reference("John 3:16");
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Display the full scripture
        Console.Clear();
        scripture.Display();

        // Loop until all words are hidden
        while (true)
        {
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide a random word
            scripture.HideRandomWord();
            Console.Clear();
            scripture.Display();

            // Check if all words are hidden
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are now hidden!");
                break;
            }
        }
    }
}