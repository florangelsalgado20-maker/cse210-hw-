// Word.cs
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        // Each hidden word is replaced with underscores 
        // matching the EXACT number of letters:
        // "faith" → "_____" (5 underscores)
        // "God" → "___" (3 underscores)
        return _isHidden ? new string('_', _text.Length) : _text;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}
