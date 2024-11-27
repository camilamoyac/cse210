using System.ComponentModel;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    Scripture(Reference reference, string text)
    {
        _reference = reference;

    }

    public void HiderandomWords()
    {
        
    }
    public string GetDisplayText()
    {
        return "";
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }
}