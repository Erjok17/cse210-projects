using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop06 World!");

        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("======================");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateNewGoal(goalManager);
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    Pause();
                    break;
                case "3":
                    RecordEvent(goalManager);
                    Pause();
                    break;
                case "4":
                    goalManager.DisplayScore();
                    Pause();
                    break;
                case "5":
                    SaveGoals(goalManager);
                    Pause();
                    break;
                case "6":
                    LoadGoals(goalManager);
                    Pause();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Pause();
                    break;
            }
        }
    }

    static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("\nCreate New Goal");
        Console.WriteLine("================");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select goal type: ");

        string input = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter point value: ");
        int points = int.Parse(Console.ReadLine());

        switch (input)
        {
            case "1":
                goalManager.AddGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                goalManager.AddGoal(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                goalManager.AddGoal(new ChecklistGoal(name, description, points, targetCount, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type selected.");
                break;
        }
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.WriteLine("\nRecord Event");
        Console.WriteLine("=============");
        goalManager.DisplayGoals();
        Console.Write("Enter the goal number to record progress: ");
        
        if (int.TryParse(Console.ReadLine(), out int goalIndex))
        {
            goalManager.RecordEvent(goalIndex - 1);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static void SaveGoals(GoalManager goalManager)
    {
        Console.Write("Enter the filename to save goals: ");
        string filename = Console.ReadLine();
        goalManager.SaveToFile(filename);
        Console.WriteLine("Goals saved successfully.");
    }

    static void LoadGoals(GoalManager goalManager)
    {
        Console.Write("Enter the filename to load goals: ");
        string filename = Console.ReadLine();
        goalManager.LoadFromFile(filename);
        Console.WriteLine("Goals loaded successfully.");
    }

    static void Pause()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(); 
    }
}