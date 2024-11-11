using System;

class Program
{
    static void Main(string[] args)
    {   
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string numberInput = Console.ReadLine();
            int number = int.Parse(numberInput);
            return number;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}.");
        }

        static void main()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            int squared = SquareNumber(number);
            DisplayResult(name, squared);
        }

        main();
    }
}