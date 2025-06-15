using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Eternal Goal '{_shortName}' completed! You earned {_points} points.");
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} - {_description})";
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|Eternal";
    }
}