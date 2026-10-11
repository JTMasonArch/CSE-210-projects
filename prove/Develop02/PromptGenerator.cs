
class PromptGenerator
{
    public string _prompt;
    List<string> _promptList = ["What are you most proud of from today?", "What is a skill you worked on today?", "What is one way that you helped someone, or was helped by someone?", "What was the best thing you ate today?", "What did you do today that was the most fun?"];

    //randomly selects a prompt from the full list of prompts
    public PromptGenerator()
    {
        Random random = new Random();
        int numberOfPrompts = _promptList.Count;
        int randomId = random.Next(numberOfPrompts);
        _prompt = _promptList[randomId];
    }
}