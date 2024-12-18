using System;

public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * 50) / 1000.0 * 0.62; // Converts meters to miles

    public override double GetSpeed() => (GetDistance() / Minutes) * 60;

    public override double GetPace() => Minutes / GetDistance();
}
