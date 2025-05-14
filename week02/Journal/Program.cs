using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("What is the date? ");
        string date = Console.ReadLine();


        Entry entry1 = new Entry();
        Console.WriteLine("What was the best part of my day? ");
        entry1._entryText = Console.ReadLine();
        entry1._promptText ="What was the best part of my day? ";
        

        Entry entry2 = new Entry();
        Console.WriteLine("How did I see the hand of the Lord in my life today? ");
        entry2._entryText = Console.ReadLine();
        entry2._promptText = "How did I see the hand of the Lord in my life today? ";

        Entry entry3 = new Entry();
        Console.WriteLine("What was the strongest emotion I felt today? ");
        entry3._entryText = Console.ReadLine();
        entry3._promptText = "What was the strongest emotion I felt today? ";

        Entry entry4 = new Entry();
        Console.WriteLine("If I had one thing I could do over today, what would it be? ");
        entry4._entryText = Console.ReadLine();
        entry4._promptText = "If I had one thing I could do over today, what would it be? ";

        Entry entry5 = new Entry();
        Console.WriteLine("What are you going to do differently tomorrow? ");
        entry5._entryText = Console.ReadLine();
        entry5._promptText = "What are you going to do differently tomorrow? ";

        Entry entry6 = new Entry();
        Console.WriteLine("What is somthing you wish you did today? ");  
        entry6._entryText = Console.ReadLine();
        entry6._promptText = "What is somthing you wish you did today? ";
        
        Entry entry7 = new Entry();
        Console.WriteLine("What did you learn about yourself today? ");
        entry7._entryText = Console.ReadLine();
        entry7._promptText = "What did you learn about yourself today? ";

        
        
        
        Journal myPrompt = new Journal();

        myPrompt._name.Add(date);
        myPrompt._entries.Add(entry1);
        myPrompt._entries.Add(entry2);
        myPrompt._entries.Add(entry3);
        myPrompt._entries.Add(entry4);
        myPrompt._entries.Add(entry5);
        myPrompt._entries.Add(entry6);
        myPrompt._entries.Add(entry7);

        myPrompt.Display();
        myPrompt.SaveToFile("journal.txt");
        myPrompt.LoadFromFile("journal.txt");
            Console.Write("Pick a number between 1 and 7: " );
            int prompt = int.Parse(Console.ReadLine());
                if (prompt == 1)
                {
                    entry1.Display();
                }
                else if (prompt == 2)
                {
                    entry2.Display();
                }
                else if (prompt == 3)
                {
                    entry3.Display();
                }
                else if (prompt == 4)
                {
                    entry4.Display();
                }
                else if (prompt == 5)
                {
                    entry5.Display();
                }
                else if (prompt == 6)
                {
                    entry6.Display();
                }
                else if (prompt == 7)
                {
                    entry7.Display();
                }

        
            
    }   
}

internal class PromptGenerator
{
}