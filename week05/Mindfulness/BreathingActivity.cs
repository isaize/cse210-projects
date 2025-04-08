using System;

class BreathingActivity : Activity
{
    public override string GetName() //i learn override concept on week 6
    {
        return "Breathing Activity";
    }

    public override string GetDescription()
    {
        return "This activity will help you relax by guiding you through breathing in and out slowly.";
    }

    protected override void PerformActivity()
    {
        int cycles = duration / 4; // 4 seconds per cycle
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            Pause(3);
            Console.WriteLine("Breathe out...");
            Pause(3);
        }
    }
}