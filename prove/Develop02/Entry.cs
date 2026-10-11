
class Entry
{
    public string _entryPrompt;
    public string _response;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"Prompt: {_entryPrompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Date: {_date}\n");
    }

    string GetPrompt()
    {
        PromptGenerator prompt = new PromptGenerator();
        return prompt._prompt;
    }

    public void writeEntry()
    {
        _entryPrompt = GetPrompt();
        Console.WriteLine(_entryPrompt);
        _response = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();
    }
}