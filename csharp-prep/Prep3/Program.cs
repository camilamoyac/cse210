using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Guess the number\n");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        bool repeat = true;
        do
        {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            int guess = int.Parse(guessInput);
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                repeat = false;
            }
        } while (repeat == true);
    }
}