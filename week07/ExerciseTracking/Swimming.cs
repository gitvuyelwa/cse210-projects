using System;

public class Swimming : Exercise
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0;
    }
    public override double GetSpeed()
    {
        return GetDistance() / (Minutes() / 60.0);
    }
    public override double GetPace()
    {
        return (Minutes() / GetDistance());
    }
    
}