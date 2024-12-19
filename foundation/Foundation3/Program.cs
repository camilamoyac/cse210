using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity running = new RunningActivity(DateTime.Now, 60, 10);
        RunningActivity running1 = new RunningActivity(DateTime.Now, 30, 6);

        SwimmingActivity swimming = new SwimmingActivity(DateTime.Now, 45, 40);
        SwimmingActivity swimming1 = new SwimmingActivity(DateTime.Now, 30, 30);

        BikingActivity biking = new BikingActivity(DateTime.Now, 60, 20);
        BikingActivity biking1 = new BikingActivity(DateTime.Now, 90, 15);

        List<Activity> activities = new List<Activity>
        {
            running, running1, swimming, swimming1, biking, biking1
        };

        foreach (Activity element in activities)
        {
            Console.WriteLine(element.GetSummary());
        }
    }
}