using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(numbers.Sum());
        Console.WriteLine("The sum is: " + numbers.Sum());
        Console.WriteLine("The average is: " + numbers.Average());
        Console.WriteLine("The largest number is: " + numbers.Max());
    
    }
}