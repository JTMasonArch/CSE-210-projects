
class PromptGenerator
{
    string _prompt;
    List<string> _promptList = new List<string>();

    //randomly selects a prompt from the full list of prompts
    string GetPrompt()
    {
        Random random = new Random();
        int numberOfPrompts = _promptList.Count;
        int randomId = random.Next(numberOfPrompts);
        _prompt = _promptList[randomId];
        return _prompt;
    }
}