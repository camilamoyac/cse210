using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Eternal Quest Program");
        Console.WriteLine("---------------------------------------------------------------------\n");
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}