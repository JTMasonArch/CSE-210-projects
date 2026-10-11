using System;

class Program
{
    static void Main(string[] args)
    {

        Menu mainMenu = new Menu(["Write journal entry", "Display journal", "Load journal", "Save journal", "Quit"]);

        Console.WriteLine("Welcome to your Journal Program\n");
        bool active = true;
        while (active)
        {
            string userRequest = mainMenu.RecieveMenuInput();

            switch (userRequest)
            {
                case "Write journal entry":
                    mainMenu.NewEntry();
                    break;
                case "Display journal":
                    mainMenu.DisplayJournal();
                    break;
                case "Load journal":
                    mainMenu.LoadJournal();
                    break;
                case "Save journal":
                    mainMenu.SaveJournal();
                    break;
                case "Quit":
                    active = mainMenu.Quit(active);
                    break;
                default:
                    Console.WriteLine("Please use one of the options listed.");
                    break;
            }
        }
    }
}