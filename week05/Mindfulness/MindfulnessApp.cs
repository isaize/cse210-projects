using System;
using System.Collections.Generic;

class MindfulnessApp
{
    private List<Activity> activities;

    public MindfulnessApp()
    {
        activities = new List<Activity>
        {
            new BreathingActivity(),
            new ReflectionActivity(),
            new ListingActivity()
        };
    }

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Choose an activity:");
            for (int i = 0; i < activities.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {activities[i].GetName()}");
            }
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();
            if (choice == "4") break;

            if (int.TryParse(choice, out int index) && index > 0 && index <= activities.Count)
            {
                activities[index - 1].Start();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}