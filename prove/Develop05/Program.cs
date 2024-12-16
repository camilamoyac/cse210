// I added a fourth activity called BodyScanActivity that helps you tune into your body.

using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness program");
        Console.WriteLine("---------------------------------------------------------------------");

        bool quit = false;
        while (quit == false)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflexion Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Body Scan Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a number from the menu: ");
            string choiceInput = Console.ReadLine();
            int choice = int.Parse(choiceInput);

            if (choice == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.DisplayStartingMessage();
                breathing.Run();
                breathing.DisplayEndingMessage();
            }
            else if (choice == 2)
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.DisplayStartingMessage();
                reflection.Run();
                reflection.DisplayEndingMessage();
            }
            else if (choice == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.DisplayStartingMessage();
                listing.Run();
                listing.DisplayEndingMessage();
            }
            else if (choice == 4)
            {
                BodyScanActivity bodyScan = new BodyScanActivity();
                bodyScan.DisplayStartingMessage();
                bodyScan.Run();
                bodyScan.DisplayEndingMessage();
            }
            else if (choice == 5)
            {
                quit = true;
            }
        }

    }
}