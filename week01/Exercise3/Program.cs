using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessNum = int.Parse(guess);

        while(guessNum != magicNumber)
        {
        if (guessNum < magicNumber)
        {
            Console.WriteLine("Higher.");
        }
        else if (guessNum > magicNumber)
        {
            Console.WriteLine("Lower.");
        }
        Console.Write("What is your guess? ");
        guess = Console.ReadLine();
        int guessNumber = int.Parse(guess);
        }
        if (guessNum == magicNumber)
        {
            Console.WriteLine("You guessed it");
        }
    }
}