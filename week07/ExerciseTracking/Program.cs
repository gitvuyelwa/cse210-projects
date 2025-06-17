using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>
        {
            new Running(new DateTime(2023, 10, 1), 30, 3.5, 7.0),
            new Cycling(new DateTime(2023, 10, 2), 45, 15.0, 20.0),
            new Swimming(new DateTime(2023, 10, 3), 60, 40)
        };

        foreach (var exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}
