using System;
using System.Collections.Generic;
using System.IO; 

public class Journal
{
    public List<Entry> _entryList = new List<Entry>();
    public int _streak = 0;
    public DateTime? _lastEntryDate = null;

    public void AddEntry(Entry entry)
    {   
        _entryList.Add(entry);

        DateTime entryDate = DateTime.Parse(entry._date);
        if (_lastEntryDate.HasValue)
        {
            if ((entryDate - _lastEntryDate.Value).Days == 1)
            {
                _streak++;
            }
            else if ((entryDate - _lastEntryDate.Value).Days > 1)
            {
                _streak = 1;
            }
        }
        else
        {
            _streak = 1;
        }

        _lastEntryDate = entryDate;
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
        Console.WriteLine($"Current streak: {_streak} days");
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
            outputFile.WriteLine($"Streak:{_streak}");
            outputFile.WriteLine($"LastEntryDate:{(_lastEntryDate.HasValue ? _lastEntryDate.Value.ToShortDateString() : "null")}");    
        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            if (line.StartsWith("Streak:"))
            {
                _streak = int.Parse(line.Replace("Streak:", "").Trim());
            }
            else if (line.StartsWith("LastEntryDate:"))
            {
                string dateString = line.Replace("LastEntryDate:", "").Trim();
                _lastEntryDate = dateString != "null" ? DateTime.Parse(dateString) : (DateTime?)null;
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