using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project."); // Welcome message

        Journal journal = new Journal();

        while (true) // Infinite loop for the menu
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine(); // Get user choice

            if (choice == "1")
            {
                Console.Write("Enter your response: ");
                string response = Console.ReadLine(); // Get user response
                journal.AddEntry(response); // Add entry to journal
            }
            else if (choice == "2")
            {
                journal.DisplayEntries(); // Display journal entries
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save: ");
                string saveFilename = Console.ReadLine(); // Get filename,
                journal.SaveToFile(saveFilename); // Save entries to file
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string loadFilename = Console.ReadLine(); // Get filename
                journal.LoadFromFile(loadFilename); // Load entries from file,
            }
            else if (choice == "5")
            {
                return; // Exit the program
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again."); // Handle invalid input
            }
        }
    }
}
