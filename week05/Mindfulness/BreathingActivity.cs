using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow, deep breaths.", 60)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowCountdown(5);

        Console.WriteLine("Breathe in deeply through your nose for 4 seconds...");
        ShowSpinner(4);
        Console.WriteLine("Now, breathe out slowly through your mouth for 6 seconds...");
        ShowSpinner(6);

        Console.WriteLine("Repeat this process for the duration of the activity.");
        ShowSpinner(_duration);

        DisplayEndingMessage();
    }
}