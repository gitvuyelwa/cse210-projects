using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

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
        List<string> spinner = new List<string> { };
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        foreach (string s in spinner)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
        
    
