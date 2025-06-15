using System;

public class SimpleGoal : Goal
{
    bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = IsComplete();
    }
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Simple Goal '{_shortName}' completed! You earned {_points} points.");
        }
        
    }

    public override bool IsComplete()
    {
        Console.WriteLine($"[{(_isComplete ? "X" : " ")}] {_shortName} - {_description}");
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} - {_description})";
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{(_isComplete ? "Complete" : "Incomplete")}";
    }
}