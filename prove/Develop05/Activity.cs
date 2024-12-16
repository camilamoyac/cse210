using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage()
    {
        Console.WriteLine(_name);
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string durationInput = Console.ReadLine();
        _duration = int.Parse(durationInput);
        Console.WriteLine("Get Ready...");
        ShowDots(3);
        Console.Clear();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowDots(3);
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}.");
        ShowDots(5);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>
        {
            "|", "/", "-", "\\", "|", "/", "-", "\\"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0; 
        while (DateTime.Now < endTime)
        {
            string s = animation[i] ;
            Console.Write(s);
            Thread.Sleep(800);
            Console.Write("\b \b");
            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        } 
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        } 
    }

    public void ShowDots(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        } 
    }
}