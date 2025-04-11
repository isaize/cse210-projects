using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goals);
                    break;
                case "2":
                    ListGoals(goals);
                    break;
                case "3":
                    SaveGoals(goals);
                    break;
                case "4":
                    LoadGoals(goals);
                    break;
                case "5":
                    totalPoints += RecordEvent(goals);
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            goals.Add(new SimpleGoal(name, points));
        }
        else if (goalType == "2")
        {
            goals.Add(new EternalGoal(name, points));
        }
        else if (goalType == "3")
        {
            Console.Write("Enter target number of times to complete: ");
            int target = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, points, target));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    static void ListGoals(List<Goal> goals)
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
        }
    }

    static void SaveGoals(List<Goal> goals)
    {
        using (var writer = new System.IO.StreamWriter("goals.txt"))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetType().Name + "," + goal.GetDetailsString());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    static void LoadGoals(List<Goal> goals)
    {
        if (System.IO.File.Exists("goals.txt"))
        {
            var lines = System.IO.File.ReadAllLines("goals.txt");
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                string type = parts[0];
                string name = parts[1];
                int points = int.Parse(parts[2]);

                if (type == "SimpleGoal")
                {
                    goals.Add(new SimpleGoal(name, points));
                }
                else if (type == "EternalGoal")
                {
                    goals.Add(new EternalGoal(name, points));
                }
                else if (type == "ChecklistGoal")
                {
                    int target = int.Parse(parts[3]);
                    goals.Add(new ChecklistGoal(name, points, target));
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }

    static int RecordEvent(List<Goal> goals)
    {
        Console.WriteLine("Select a goal to record an event for:");
        ListGoals(goals);
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            goals[index].RecordEvent();
            Console.WriteLine("Event recorded.");
            return goals[index].GetPoints();
        }
        Console.WriteLine("Invalid goal selection.");
        return 0;
    }
}