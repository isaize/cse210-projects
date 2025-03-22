using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> Entries = new List<Entry>(); // List to store journal entries

    private Random random = new Random(); // Random number generator (i got this code from youtube C#learning for beginners)
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void AddEntry(string response)
    {
        string prompt = prompts[random.Next(prompts.Count)]; // Get a random prompt
        Entries.Add(new Entry(prompt, response)); // Create and add a new entry
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine(entry.ToString()); // Display each entry
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename)) //(i got this code from youtube, after my code was showing some errors C#learning for beginners)
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}"); // Save entry to file
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear(); // Clear existing entries
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|'); // Split line by the separator
                if (parts.Length == 3)
                {
                    Entries.Add(new Entry(parts[1], parts[2]) { Date = parts[0] }); // Add new entry
                }
            }
        }
    }
}