
class Reference
{
    
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetReferenceTitle()
    {
        string fullReference;
        if(_endVerse != 0)
        {
            fullReference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        } else
        {
            fullReference = $"{_book} {_chapter}:{_verse}";
        }
        return fullReference;
    }
    //this is a substitue for what would in a real program be a set of functions that search files containing the entire scriptures to find the ones requested
    public string GetReferenceText()
    {
        string verses = "";

        List<string> retrievedChapter = new List<string>(["", "", "", "", "Trust in the Lord with all thine heart; and lean not unto thine own understanding.", "In all thy ways acknowledge him, and he shall direct thy paths"]);
        List<string> requestedVerses = new List<string>();
        if(_endVerse > 0)
        {
            for(int i = _verse; i <= _endVerse; i++)
            {
                requestedVerses.Add(retrievedChapter[i-1]);
            }
        } else
        {
            requestedVerses.Add(retrievedChapter[_verse-1]);
        }
        
        verses = string.Join("", requestedVerses);
        return verses;
    }
}