
using System.Threading.Channels;

class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(String reference)
    {
        SetReference(reference);
        string verseWords = _reference.GetReferenceText();
        SetWords(verseWords);
    }

    public void SetReference(string newReference)
    {
        List<string> bookSplit = newReference.Split(" ").ToList();
        string book = bookSplit[0];

        List<string> chapterSplit = bookSplit[1].Split(":").ToList();
        int chapter = Int32.Parse(chapterSplit[0]);

        int verse;
        int endVerse = 0;
        if(chapterSplit[1].Contains("-"))
        {
            List<string> verseSplit = chapterSplit[1].Split("-").ToList();
            verse = Int32.Parse(verseSplit[0]);
            endVerse = Int32.Parse(verseSplit[1]);
        } else
        {
            verse = Int32.Parse(chapterSplit[1]);
        }
        
        if(endVerse != 0)
        {
            _reference = new Reference(book, chapter, verse, endVerse);
        } else
        {
            _reference = new Reference(book, chapter, verse);
        }

    }

    public void SetWords(string verseWords)
    {
        List<string> wordText = verseWords.Split(" ").ToList();

        foreach(string item in wordText)
        {
            Word word = new Word(item);
            this._words.Add(word);
        }
    }

    public void DisplayWords()
    {
        Console.Write(_reference.GetReferenceTitle());
        foreach(Word word in _words)
        {
            Console.Write(" " + word.GetWord());
        }
    }

    public void HideRandomWords(int hideCount)
    {
        Random random = new Random();

        for(int i =0; i <hideCount; i++)
        {
            int chosenIndex = random.Next(_words.Count());
            if (_words[chosenIndex].IsVisibile())
            {
                _words[chosenIndex].HideWord();
            } else
            {
                i--;
            }
            
        }
    }

    public int VisibleCount()
    {
        int wordsVisible = 0;
        foreach(Word word in _words)
        {
            if (word.IsVisibile())
            {
                wordsVisible++;
            } else
            {
                continue;
            }
        }
        return wordsVisible;
    }
    public bool CheckHiddenWords()
    {
        
        int wordsVisible = VisibleCount();

        bool allHidden = false;
        if((_words.Count() - wordsVisible) == _words.Count())
        {
            allHidden = true;
        } else
        {
            allHidden = false;
        }

        return allHidden;
    }

}