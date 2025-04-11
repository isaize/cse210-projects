using System;

public abstract class Goal
{
    protected string name;
    protected int points;
    protected bool isComplete;

    public Goal(string goalName, int goalPoints)
    {
        name = goalName;   // Assign parameter to member variable
        points = goalPoints; // Assign parameter to member variable
        isComplete = false; // Initialize isComplete to false
    }

    public abstract void RecordEvent();
    public abstract string GetDetailsString();
    public abstract int GetPoints();
}