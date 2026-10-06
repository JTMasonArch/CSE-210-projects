
class Entry
{
    string _prompt;
    string _response;
    int _date;

    void Display()
    {
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Date: {_date}");
    }

}