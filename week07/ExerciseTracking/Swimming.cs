using System;

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance() => (laps * 50.0 / 1000.0); // Distance in kilometers

    public override double GetSpeed() => (GetDistance() / (minutes / 60.0));

    public override double GetPace() => (minutes / GetDistance());
}