using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Camila Moya", "Science");
        Console.WriteLine(assignment1.getSummary());

        MathAssignment assignment2 = new MathAssignment("Joe Mama", "Addition", "5.2", "1-20");
        Console.WriteLine(assignment2.getSummary());
        Console.WriteLine(assignment2.getHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Buzz Lightyear", "IIWW", "Why the Nazis were Bad");
        Console.WriteLine(assignment3.getSummary());
        Console.WriteLine(assignment3.getWritingInformation());
    }
}