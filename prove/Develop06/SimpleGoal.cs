public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine($"Goal completed! You earned {Points} points.");
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
        }
    }

    public override string GetDetails()
    {
        return $"[ {(IsComplete ? "X" : " ")} ] {Name} ({Description})";
    }
}
