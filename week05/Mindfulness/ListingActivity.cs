using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "What are some things you are grateful for?",
        "List some of your favorite memories.",
        "What are some achievements you are proud of?",
        "Name a few people who have positively impacted your life.",
        "What hobbies or activities bring you joy?"
    };
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing them.", 60)
    {
        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowCountdown(5);

        Console.WriteLine("Think of a few good things in your life and list them below:");
        Console.WriteLine("Press Enter after each item. Type 'done' when you are finished.");

        string input;
        int count = 0;

        while (true)
        {
            input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }
            count++;
            Console.WriteLine($"Item {count}: {input}");
        }

        Console.WriteLine($"You listed {count} good things.");
        ShowSpinner(60);

        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Take a moment to reflect on this prompt before you start listing.");
        ShowSpinner(5);
    }

    List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        Console.WriteLine("Please enter items (type 'done' to finish):");
        string input;
        while ((input = Console.ReadLine()) != "done")
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }
        return items;
    }
}