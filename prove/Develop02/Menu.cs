
class Menu
{
    List<string> _options;
    Journal _openJournal = new Journal();

    public Menu(List<string> options)
    {
        _options = options;
    }
    public string RecieveMenuInput()
    {
        Console.WriteLine("\nPlease choose from one of the following options.");
        foreach(string option in _options)
        {
            Console.WriteLine(" - " + option);
        }

        Console.WriteLine("");

        string answer = "";
        bool validOption = false;

        while(!validOption){
            answer = Console.ReadLine();

            foreach(string option in _options)
            {
                if(answer == option)
                {
                    validOption = true;
                    break;
                }
            }
        }
        return answer;
    }

    public void LoadJournal()
    {
        _openJournal.Load();
    }

    public void SaveJournal()
    {
        _openJournal.Save();
    }

    public void NewEntry()
    {
        _openJournal.WriteEntry();
    }

    public void DisplayJournal()
    {
        _openJournal.DisplayEntries();
    }

    public bool Quit(bool exit)
    {
        if (exit)
        {
            exit = false;
        } else
        {
            exit = true;
        }
        return exit;
    }

}