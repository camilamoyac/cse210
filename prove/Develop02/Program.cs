//I added a streak that looks at the previous entry date to calculate the writing streak
//and then displays the streak.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal");
        Console.WriteLine("---------------------------------------------------------------------");
        Journal journal = new Journal();
        Prompt prompt = new Prompt();
        journal.DisplayStreak();

        int quit = 0;
        while (quit != 1)
        {
            Console.WriteLine("\nPlease select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string optionInput = Console.ReadLine();
            int option = int.Parse(optionInput);

            if (option == 1)
            {
                string newPrompt = prompt.GivePrompt();
                Console.WriteLine(newPrompt);

                Console.Write(">>>");
                string newEntry = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string newDateTime = theCurrentTime.ToShortDateString();
                
                journal.AddEntry(new Entry(newDateTime, newPrompt, newEntry));
                journal.DisplayStreak();
            }
            else if (option == 2)
            {
                journal.DisplayAll();
            }
            else if (option == 3)
            {
                Console.Write("Enter filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                journal.DisplayStreak();
            }
            else if (option == 4)
            {
                Console.Write("Enter filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (option == 5)
            {
                quit = 1;
            }
            else
            {
                Console.WriteLine("Invalid input, try again.");
            }
        }
    }
}