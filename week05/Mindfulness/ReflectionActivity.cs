using System;
using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?"
    };

    public override string GetName()
    {
        return "Reflection Activity";
    }

    public override string GetDescription()
    {
        return "This activity will help you reflect on times in your life when you have shown strength.";
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Pause(5); // Time to reflect

        for (int i = 0; i < duration / 5; i++)
        {
            string question = questions[random.Next(questions.Count)];
            Console.WriteLine(question);
            Pause(5); // Pause for each question
        }
    }
}