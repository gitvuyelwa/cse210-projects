using System;

public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>
    {
        "What is something you are proud of?",
        "What is a challenge you have overcome?",
        "What is a lesson you have learned recently?",
        "What is something that makes you happy?",
        "What is a goal you want to achieve?"
    };

    List<string> _questions = new List<string>
    {
        "How does this make you feel?",
        "What can you learn from this experience?",
        "How can you apply this to your life?",
        "What are the next steps you can take?",
        "How can you use this to help others?"
    };
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on your thoughts and feelings.", 60)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowCountdown(5);

        GetRandomPrompt();
        Console.WriteLine("Take a moment to reflect on this prompt.");
        ShowSpinner(5);

        Console.WriteLine("Now, answer the following questions:");
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(15);
        }

        ShowSpinner(60);
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($"Prompt: {prompt}");
        ShowSpinner(15);
    }

    public void GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string question = _questions[index];
        Console.WriteLine($"Question: {question}");
        ShowSpinner(15);
    }

    public void DisplayPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($"Prompt: {prompt}");
        ShowSpinner(15);
    }
    public void DisplayQuestions()
    {
        Console.WriteLine("Here are some questions to help you reflect:");
        foreach (var question in _questions)
        {
            Console.WriteLine($"- {question}");
        }
        Console.WriteLine("Take your time to think about each question.");
        ShowSpinner(15);
    }
}