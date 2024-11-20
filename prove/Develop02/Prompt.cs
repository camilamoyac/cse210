using System;
using System.Collections.Generic;

public class Prompt
{
    public List<string> _promptList = new List<string> {"What am I grateful for today?",
    "What is one good thing and one bad thing that happened today?", "What did I learn today?",
    "What surprised me today?", "What am i looking forward to tomorrow?", "What reminded me of God today?",
    "What made me smile today?", "What did I accomplish today?", "What's something you want to remember from today?"};

    public string GivePrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_promptList.Count);
        return _promptList[randomIndex];
    }
}