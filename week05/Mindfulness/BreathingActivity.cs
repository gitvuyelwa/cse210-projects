using System;
using System.Reflection.Metadata;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by focusing on your breathing. " +
        "You will inhale and exhale slowly to calm your mind and body.",
        30) 

    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowCountdown(5);
        
        
            Console.WriteLine("Breathe in deeply through your nose for 4 seconds...");
            Thread.Sleep(2000);
            ShowCountdown(4);

            Console.WriteLine("Now, breathe out slowly through your mouth for 6 seconds...");
            Thread.Sleep(2000);
            ShowCountdown(6);

        DisplayEndingMessage();
    }
}