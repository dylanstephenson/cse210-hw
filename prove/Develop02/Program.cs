using System;
using System.IO.Enumeration;

// CREATIVITY: I added creativity to my assignment to exceed requirements by adding the Get Inspired method to PromptGenerator. This picks a random quote and prints it the console when the user types in "5".
// This helps people who avoid writing in their journal because they worry that they might feel discouraged and sad after writing about their day.

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!"); 

        while (userInput != 6)
        {
            Console.WriteLine("Please Select One of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Get Inspired");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");

            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Entry entry = new Entry();
                journal.AddEntry(entry);
            }
            else if (userInput == 2)
            {
                journal.DisplayAll();
            }
            else if (userInput == 3)
            {
                Console.WriteLine("What is the file name?");
                Console.Write("> ");
                string fileName = Console.ReadLine();
                journal.LoadJournal(fileName);
            }
            else if (userInput == 4)
            {
                Console.WriteLine("What is the file name?");
                Console.Write("> ");
                string fileName = Console.ReadLine();
                journal.SaveEntry(fileName);
            }
            else if (userInput == 5)
            {
                PromptGenerator inspire = new PromptGenerator();
                Console.WriteLine($"\n{inspire.GetInspired()}\n");
            }
            else if (userInput == 6)
            {
                Console.WriteLine("Thank you for using the Journal Program.");
            }
            else
            {
                Console.WriteLine("That input is not recognized.");
            }
        }
    }
}