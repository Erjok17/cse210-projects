using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
         // Create activities
        var running = new RunningActivity("03 Nov 2024", 30, 3.0); // 3 miles
        var cycling = new CyclingActivity("04 Nov 2024", 45, 15.0); // 15 mph
        var swimming = new SwimmingActivity("05 Nov 2024", 20, 30); // 30 laps

        // Add to list
        var activities = new List<Activity> { running, cycling, swimming };

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}