using System;

public class Running: Exercise
{
    private double _distance;
    private double _speed;

    public Running(DateTime date, int minutes, double distance, double speed) : base(date, minutes)
    {
        _distance = distance;
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (double)Minutes() * 60; 
    }

    public override double GetPace()
    {
        return (double)Minutes() / GetDistance();
    }

    
}