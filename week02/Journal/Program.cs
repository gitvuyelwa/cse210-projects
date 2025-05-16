using System;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("What is the date? ");
        string _date = Console.ReadLine();

        Entry entry1 = new Entry();
        Console.WriteLine("1.What was the best part of my day? ");
        entry1._promptText ="What was the best part of my day? ";
        
        Entry entry2 = new Entry();
        Console.WriteLine("2.How did I see the hand of the Lord in my life today? ");
        entry2._promptText = "How did I see the hand of the Lord in my life today? ";

        Entry entry3 = new Entry();
        Console.WriteLine("3.What was the strongest emotion I felt today? ");
        entry3._promptText = "What was the strongest emotion I felt today? ";

        Entry entry4 = new Entry();
        Console.WriteLine("4.If I had one thing I could do over today, what would it be? ");
        entry4._promptText = "If I had one thing I could do over today, what would it be? ";

        Entry entry5 = new Entry();
        Console.WriteLine("5.What are you going to do differently tomorrow? ");
        entry5._promptText = "What are you going to do differently tomorrow? ";

        Entry entry6 = new Entry();
        Console.WriteLine("6.What is something you wish you did today? ");  
        entry6._promptText = "What is something you wish you did today? ";
        
        Entry entry7 = new Entry();
        Console.WriteLine("7.What did you learn about yourself today? ");
        entry7._promptText = "What did you learn about yourself today? ";

        Entry entry8 = new Entry();
        Console.WriteLine("8.Your Journal: ");
        entry8._promptText = "Your Journal: ";

        Console.WriteLine("Pick a number between 1 and 7 to answer one of the above displayed Questions. To include any other information in your journal enter 8, to quit your entry enter 0: " );
            int prompt = int.Parse(Console.ReadLine());
                if (prompt == 0)
                {
                    Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
                }
                else if (prompt == 1)
                {
                    Console.WriteLine("What was the best part of my day? ");
                    entry1._entryText = Console.ReadLine();
                    
                }
                else if (prompt == 2)
                {
                    Console.WriteLine("How did I see the hand of the Lord in my life today? ");
                    entry2._entryText = Console.ReadLine();
                }
                else if (prompt == 3)
                {
                    Console.WriteLine("What was the strongest emotion I felt today? ");
                    entry3._entryText = Console.ReadLine();
                }
                else if (prompt == 4)
                {
                    Console.WriteLine("If I had one thing I could do over today, what would it be? ");
                    entry4._entryText = Console.ReadLine();
                }
                else if (prompt == 5)
                {
                    Console.WriteLine("What are you going to do differently tomorrow? ");
                    entry5._entryText = Console.ReadLine();
                }
                else if (prompt == 6)
                {
                    Console.WriteLine("What is somthing you wish you did today? ");  
                    entry6._entryText = Console.ReadLine();
                }
                else if (prompt == 7)
                {
                    Console.WriteLine("What did you learn about yourself today? ");
                    entry7._entryText = Console.ReadLine();
                }
                // prompt 8 allows them to enter any other information they want to include in their journal entry.
                else if (prompt == 8)
                {
                    
                    Console.WriteLine("Your Journal: ");
                    entry8._entryText = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 8 or 0 to quit.");
                }
        Console.WriteLine("Thank you for using the Journal Program. Goodbye!");

            
    }   
}
