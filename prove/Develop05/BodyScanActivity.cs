using System;

public class BodyScanActivity : Activity
{
    List<string> _bodyParts;
    public BodyScanActivity()
    {
        _name = "Body Scan Activity";
        _description = "This activity will help you connect your mind and body by becoming aware of the sensations in each body part. Tune into every sensation carefully.";
        _bodyParts = new List<string>
        {
            "Head", "Face", "Eyes", "Nose", "Mouth", "Ears", "Neck", "Shoulders", "Arms", "Elbows", "Hands", "Fingers",
            "Chest", "Abdomen", "Back", "Hips", "Legs", "Knees", "Ankles", "Feet", "Toes"
        };
    }

    public void Run()
    {
        Console.WriteLine("Think only about the sensations in the following body parts: ");
        ShowDots(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomPart());
            ShowSpinner(7);
            Console.Clear();
        }
    }
    public string GetRandomPart()
    {
        Random random = new Random();
        int randomIndex = random.Next(_bodyParts.Count);
        return _bodyParts[randomIndex];
    }
}