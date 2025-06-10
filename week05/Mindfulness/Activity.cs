using System;

public class Activity
{
    public string _name;
    public string _description;
    public int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine(_description);
        Console.WriteLine($"This activity will last for {_duration} seconds.");
        Console.WriteLine("Get ready...");
        System.Threading.Thread.Sleep(2000);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You have completed the {_name} activity.");
        Console.WriteLine("Thank you for participating!");
        System.Threading.Thread.Sleep(2000);
    }
    public void ShowSpinner(int seconds)
    {
        Console.WriteLine($"Pausing for {seconds} seconds...");
        System.Threading.Thread.Sleep(seconds * 1000);
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"{i}");
            System.Threading.Thread.Sleep(2000);
        }
    }
}