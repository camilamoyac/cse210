using System.ComponentModel;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();
        foreach(Word word in _words)
        {
            if (!word.IsHidden()) //if it's not hidden
            {
                visibleWords.Add(word);
            }
        } 

        if (visibleWords.Count <= numberToHide)
        {
            foreach (Word word in visibleWords)
            {
                word.Hide();
            }
            return;
        }

        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
        int randomIndex = random.Next(visibleWords.Count);
        visibleWords[randomIndex].Hide();
        visibleWords.RemoveAt(randomIndex);
        }
    }
    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden()) // if the wrd is not hidden
            {
                return false;
            }
        }
        return true;
    }
}