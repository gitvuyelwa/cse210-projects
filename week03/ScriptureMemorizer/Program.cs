using System;
//program shows a clue for the first letter of every hidden word
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("You can memorize a scripture by hiding random words.");
        Console.WriteLine("Type 'quit' to exit the program.");
        Console.WriteLine("Type 'clue' to get a clue for the first letter of a word.");

        Scripture scripture = new Scripture();
        scripture.HideRandomWords(0);
        bool showOnlyFirstLetter = false;

        while (true)
        {

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations! You have memorized the scripture!");
                break;
            }

            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit or type 'clue' to get the first letter of every hidden word.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (input.ToLower() == "clue")
            {
                showOnlyFirstLetter = !showOnlyFirstLetter;
                Console.WriteLine("Clue mode: " + (showOnlyFirstLetter ? "Showing first letters of hidden words." : "Showing full words."));
                foreach (Word word in scripture._words)
                {
                    Console.Write(word.GetClue(showOnlyFirstLetter) + " ");
                }
                Console.WriteLine();
                Console.ReadLine(); 
                continue;
            }
            scripture.HideRandomWords(1);
        }
    }
}

       