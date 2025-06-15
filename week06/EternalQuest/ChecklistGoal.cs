using System;

public class ChecklistGoal : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"Checklist Goal '{_shortName}' updated! You have completed {_amountCompleted}/{_target}.");
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You earned {_points + _bonus} points for completing the goal.");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{_shortName}' is already complete. No points awarded.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} - {_description} ({_amountCompleted}/{_target})";
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_amountCompleted}/{_target}|{_bonus}";
    }
}