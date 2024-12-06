public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by pacing your breathing. Clear your mind and focus on your breathing.") { }

    public override void Execute()
    {
        Start();
        for (int i = 0; i < Duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            PauseWithCountdown(2);
            Console.WriteLine("Breathe out...");
            PauseWithCountdown(2);
        }
        End();
    }

    private void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
