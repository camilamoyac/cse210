using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind\nand focus on your breathing.";
    }

    public void Run()
    {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
        Console.Write("\n\nBreathe in... ");
        ShowCountDown(4);
        Console.Write("\nBreathe out... ");
        ShowCountDown(6);
        }
    }
}