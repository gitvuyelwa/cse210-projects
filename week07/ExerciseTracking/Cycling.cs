using System;
using System.Runtime.CompilerServices;

public class Cycling : Exercise
{
    private double _distance;
    private double _speed;

    public Cycling(DateTime date, int minutes, double distance, double speed) : base(date, minutes)
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
        return _speed; 
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    
}