using System;

public abstract class Exercise
{
    private DateTime _date;
    private int _minutes;

    public Exercise(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public DateTime DateTime()
    {
        return _date;
    }
    public int Minutes()
    {
        return _minutes;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MM yyyy} {GetType().Name} ({_minutes} min) - Distance: {GetDistance():F1} kilometres, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min/km";
    }
}