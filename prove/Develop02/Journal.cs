using System.IO;

class Journal
{
    string _currentJournal;
    List<Entry> _entries = new List<Entry>();

    public void DisplayEntries()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void Save()
    {
        

        using (StreamWriter outputFile = new StreamWriter($"journals\\{_currentJournal}.text"))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} ~|~ {entry._entryPrompt} ~|~ {entry._response}");
            }
            

        }
        Console.WriteLine("Journal saved!");
    }

    public void Load()
    {

        Console.WriteLine("What journal would you like to load?");

        string journalFolderPath = @"journals";
        foreach (string file in Directory.EnumerateFiles(journalFolderPath))
        {
            Console.WriteLine(Path.GetFileNameWithoutExtension(file));
        }

        bool validOption = false;

        Console.WriteLine("");
        while(!validOption){

            _currentJournal = Console.ReadLine();

            foreach (string file in Directory.EnumerateFiles(journalFolderPath))
            {
                if(_currentJournal == Path.GetFileNameWithoutExtension(file))
                {
                    validOption = true;
                    break;
                }
            }
        }
        
        string[] lines = System.IO.File.ReadAllLines($"journals\\{_currentJournal}.text");

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            Entry lineEntry = new Entry();
            lineEntry._entryPrompt = parts[1];
            lineEntry._response = parts[2];
            lineEntry._date = parts[0];

            _entries.Add(lineEntry);
            
        }
        Console.WriteLine("Journal loaded!");
    }

    public void WriteEntry()
    {
        if(_currentJournal == null)
        {
            Console.WriteLine("Please load a journal first.");
        } else {

            Entry newEntry = new Entry();
            newEntry.writeEntry();
            _entries.Add(newEntry);

        }
    }
}