using System;

class Program
{
    static void Main(string[] args)
    {
        string chosenReference = GenerateScripture();
        Scripture scripture = new Scripture(chosenReference);

        bool active = true;

        while (active)
        {
            Console.Clear();
            DisplayScripture(scripture);
            Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish: ");
            string userResponse = Console.ReadLine();
            if(userResponse == "quit")
            {
                active = Quit(active);
                break;
            } else
            {
                bool allWordsHidden = scripture.CheckHiddenWords();
                if (allWordsHidden)
                {
                    active = Quit(active);
                    break;
                } else
                {
                    int visibleWords = scripture.VisibleCount();
                    int hideCount = 0;
                    if(visibleWords >= 3)
                    {
                        hideCount = 3;
                    } else if(visibleWords > 0)
                    {
                        hideCount = visibleWords;
                    } else
                    {
                        hideCount = 0;
                    }
                    
                    scripture.HideRandomWords(hideCount);
                }
            }
        }
    }

    private static string GenerateScripture()
    {
        //in an expanded program would recieve user input
        string retrievedReference = "Proverbs 3:5";
        return retrievedReference;
    }

    private static void DisplayScripture(Scripture scripture)
    {
        scripture.DisplayWords();
    }

    private static bool Quit(bool exitValue)
    {
        return !exitValue;
    }
}