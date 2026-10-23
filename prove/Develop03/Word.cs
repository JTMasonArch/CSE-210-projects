
using System.Runtime;

class Word
{
    
    private bool _isVisible;
    private string _text;

    public Word(string text)
    {
        _isVisible = true;
        _text = text;
    }

    public string GetWord()
    {
        if (_isVisible)
        {
            return _text;
        } else
        {
            string[] wordItems = new string[_text.Length];
            string wordDisplay = "";

            for(int i = 0; i < _text.Length; i++)
            {
                wordItems[i] = "_";
            }

            wordDisplay = string.Join("", wordItems);
            return wordDisplay;
        }
    }

    public void HideWord()
    {
        _isVisible = false;
    }

    public void ShowWord()
    {
        _isVisible = true;
    }

    public bool IsVisibile()
    {
        return _isVisible;
    }
}