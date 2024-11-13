using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.\n");
        List<int> numberList = new List<int>();
        int number = -1;

        while (number != 0)
        {
        Console.Write("Enter number: ");
        string numberInput = Console.ReadLine();
        number = int.Parse(numberInput);
        if (number != 0)
        {
            numberList.Add(number);
        }
        }

        int amount = numberList.Count;
        int total = 0;
        int highest = 0;
        foreach (int element in numberList)
        {
            total += element;
            if (element > highest)
            {
                highest = element;
            }
        }

        float average = (float)total / amount;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average:f1}");
        Console.WriteLine($"The highest number is: {highest}");
    }
}