public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded! You earned {Points} points.");
    }

    public override string GetDetails()
    {
        return $"[ ∞ ] {Name} ({Description})";
    }
}
