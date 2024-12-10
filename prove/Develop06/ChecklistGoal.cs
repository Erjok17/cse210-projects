public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int Bonus { get; set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        Bonus = bonus;
        CurrentCount = 0;
    }

    public override void RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            Console.WriteLine($"Progress made! You earned {Points} points.");

            if (CurrentCount == TargetCount)
            {
                IsComplete = true;
                Console.WriteLine($"Goal completed! You earned a bonus of {Bonus} points.");
            }
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
        }
    }

    public override string GetDetails()
    {
        return $"[ {(IsComplete ? "X" : " ")} ] {Name} ({Description}) - Completed {CurrentCount}/{TargetCount}";
    }
}
