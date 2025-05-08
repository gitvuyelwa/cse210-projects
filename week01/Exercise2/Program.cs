using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage did you get on the test? ");
        string grade = Console.ReadLine();
        int gradePercent = int.Parse(grade);


    if (gradePercent >= 90)
    {
        Console.WriteLine("You got an A!");
    }
    else if (gradePercent >= 80)
    {
        Console.WriteLine("You got a B!");
    }
    else if (gradePercent >= 70)
    {
        Console.WriteLine("You got a C!");
    }
    else if (gradePercent >= 60)
    {
        Console.WriteLine("You got a D!");
    }
    else
    {
        Console.WriteLine("You got an F!");
    }
    Console.WriteLine($"Your grade is {gradePercent}%.");

    if (gradePercent >= 70)
    {
        Console.WriteLine("You passed the test!");
    }
    else
    {
        Console.WriteLine("You failed the test.");
    }
    }
}