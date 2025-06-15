using System;

class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    
    int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
    while (running)
    {
        Console.WriteLine("1. Create Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Save Goals");
        Console.WriteLine("5. Load Goals");
        Console.WriteLine("6. Quit");
        Console.Write("Choose an option: ");

        switch (Console.ReadLine())
        {
            case "1": CreateGoal(); break;
            case "2": DisplayPlayerInfo(); break;
            case "3": RecordEvent(); break;
            case "4": SaveGoals(); break;
            case "5": LoadGoals(); break;
            case "6": running = false; break;
            default: Console.WriteLine("Invalid option."); break;
        }
    }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Available Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Name}");
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("Select type: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter description: ");
        string desc = Console.ReadLine();

        Console.Write("Enter points: ");
        string points = Console.ReadLine();

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("How many times to complete? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }

    public void RecordEvent()
    {
        LoadGoals();
        Console.Write("Which goal? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int earned = 0;
            if (_goals[index] is SimpleGoal simpleGoal)
            {
                simpleGoal.RecordEvent();
                earned = simpleGoal.Points; // Assuming Points is a property for earned points
            }
            else if (_goals[index] is EternalGoal eternalGoal)
            {
                eternalGoal.RecordEvent();
            }
            else if (_goals[index] is ChecklistGoal checklistGoal)
            {
                checklistGoal.RecordEvent();
                earned = checklistGoal.Points; // Assuming Points is a property for earned points
            }
            _score += earned;
            Console.WriteLine($"+{earned} points!");
        }
    }

    public void SaveGoals()
    {
        string filePath = "goals.txt";
    List<string> lines = new List<string>();

    lines.Add(_score.ToString()); // Save the score as the first line

    foreach (var goal in _goals)
    {
        lines.Add(goal.ToString()); // Each goal converts itself to a string
    }

    File.WriteAllLines(filePath, lines);
    Console.WriteLine($"Goals saved to {filePath}");
    }

    public void LoadGoals()
    {
        string filePath = "goals.txt";

    if (File.Exists(filePath))
    {
        string[] lines = File.ReadAllLines(filePath);

        _score = int.Parse(lines[0]); // Load the score

        _goals.Clear(); // Clear existing goals before loading

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string goalType = parts[0];
            string data = parts[1];

             switch (goalType)
        {
            case "SimpleGoal":
                _goals.Add(new SimpleGoal(parts[1], parts[2], parts[3]));
                break;
            case "EternalGoal":
                _goals.Add(new EternalGoal(parts[1], parts[2], parts[3]));
                break;
            case "ChecklistGoal":
                _goals.Add(new ChecklistGoal(parts[1], parts[2], parts[3],
                                             int.Parse(parts[4]), int.Parse(parts[5])));
                break;
        }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
    else
    {
        Console.WriteLine("File not found.");
    }
}
}