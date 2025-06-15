using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name ;
        _description = description;
        _points = points;

    }
    public string Name
    {
        get { return _shortName; }
        set { _shortName = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public int Points
    {
        get { return int.Parse(_points); }
        set { _points = value.ToString(); }
    }
public static Goal CreateGoal(string line)
{
    string[] parts = line.Split(':');
    string type = parts[0];
    string[] values = parts[1].Split(',');

    return null;
}

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}