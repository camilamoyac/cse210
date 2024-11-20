using System;
using System.Collections.Generic;
using System.IO; 

public class Journal
{
    public List<Entry> _entryList = new List<Entry>();
    public int streak = 0;
    public DateTime? lastEntryDate = null;

    public void AddEntry(Entry entry)
    {   
        _entryList.Add(entry);

        DateTime entryDate = DateTime.Parse(entry._date);
        if (lastEntryDate.HasValue)
        {
            if ((entryDate - lastEntryDate.Value).Days == 1)
            {
                streak++;
            }
            else if ((entryDate - lastEntryDate.Value).Days > 1)
            {
                streak = 1;
            }
        }
        else
        {
            streak = 1;
        }

        lastEntryDate = entryDate;
    }

    public void DisplayAll()
    {
        foreach (Entry element in _entryList)
        {
            element.DisplayOne();
        }
    }

    public void DisplayStreak()
    {
        Console.WriteLine($"Current streak: {streak} days");
    }

    public void SaveToFile(string filename)
    {   
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry element in _entryList)
            {
                string line = $"{element._date}|{element._prompt}|{element._entry}";
                outputFile.WriteLine(line);
            }
            outputFile.WriteLine($"Streak:{streak}");
            outputFile.WriteLine($"LastEntryDate:{(lastEntryDate.HasValue ? lastEntryDate.Value.ToShortDateString() : "null")}");    
        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            if (line.StartsWith("Streak:"))
            {
                streak = int.Parse(line.Replace("Streak:", "").Trim());
            }
            else if (line.StartsWith("LastEntryDate:"))
            {
                string dateString = line.Replace("LastEntryDate:", "").Trim();
                lastEntryDate = dateString != "null" ? DateTime.Parse(dateString) : (DateTime?)null;
            }
            else
            {
                string[] parts = line.Split("|");

                if (parts.Length == 3)
                    {
                        Entry entry = new Entry(parts[0], parts[1], parts[2]);
                        _entryList.Add(entry);
                    }
            }
        }
    }
}