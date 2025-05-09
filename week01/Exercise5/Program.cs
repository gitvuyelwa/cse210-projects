using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcomeMessage();
       string userName = GetUserName();
       int userNumber = GetUserNumber();
       int squaredNumber = SquareNumber(userNumber);
        DisplayResults(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the number squaring program!");
    }

    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int GetUserNumber()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static void DisplayResults(string userName, int squaredNumber)
    {
        Console.WriteLine($"Hello {userName}, the square of your number is: {squaredNumber}");
    }
}