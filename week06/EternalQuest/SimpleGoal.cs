using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        isComplete = true;
    }

    public override string GetDetailsString()
    {
        return isComplete ? $"[X] {name}" : $"[ ] {name}";
    }

    public override int GetPoints()
    {
        return isComplete ? points : 0;
    }
}