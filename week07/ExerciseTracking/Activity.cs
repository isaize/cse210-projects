using System;

public abstract class Activity
{
    private DateTime date;
    protected int minutes;

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{date:dd MMM yyyy} {GetType().Name} ({minutes} min) - Distance: {GetDistance():F1}, Speed: {GetSpeed():F1}, Pace: {GetPace():F2} min";
    }
}