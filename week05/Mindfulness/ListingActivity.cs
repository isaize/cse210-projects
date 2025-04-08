using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "What brings you joy?"
    };

    public override string GetName()
    {
        return "Listing Activity";
    }

    public override string GetDescription()
    {
        return "This activity will help you list the good things in your life.";
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Pause(3); // Time to think

        List<string> items = new List<string>();
        Console.WriteLine("Start listing your items (type 'done' when finished):");

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "done") break;
            items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} items.");
    }
}