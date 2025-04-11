using System;

public class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int target;

    public ChecklistGoal(string name, int points, int target) : base(name, points)
    {
        this.target = target;
        this.timesCompleted = 0;
    }

    public override void RecordEvent()
    {
        if (!isComplete)
        {
            timesCompleted++;
            if (timesCompleted >= target)
            {
                isComplete = true;
            }
        }
    }

    public override string GetDetailsString()
    {
        return isComplete
            ? $"[X] {name} (Completed {timesCompleted}/{target})"
            : $"[ ] {name} (Completed {timesCompleted}/{target})";
    }

    public override int GetPoints()
    {
        return isComplete ? points + 500 : timesCompleted * points;
    }
}