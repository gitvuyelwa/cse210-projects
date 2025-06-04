using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Ed Sheeran", "Algebra");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Sam Smith", "Calculus", "Section 5.2", "Problems 1-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Alina Baraz", "History", "The Renaissance");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWrirtingInformation());
    }
}