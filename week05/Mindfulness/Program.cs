using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Please choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                break;
            case "2":
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                break;
            case "3":
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}
