using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        // No completion for eternal goals
    }

    public override string GetDetailsString()
    {
        return $"(Eternal) {name}";
    }

    public override int GetPoints()
    {
        return points;
    }
}