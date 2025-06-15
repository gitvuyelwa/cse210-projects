using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\n-- Eternal Quest --");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Choose: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": manager.CreateGoal();break;
                case "2": manager.RecordEvent(); break;
                case "3": manager.ListGoalNames(); break;
                case "4": manager.ListGoalDetails(); break;
                case "5":manager.SaveGoals();break;
                case "6": manager.LoadGoals(); break;
                case "7": return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }
}