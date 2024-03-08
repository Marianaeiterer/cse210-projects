public class PromptGenerator
{
    public List<string> _prompts = new List<string>();


    public string GetRandomPrompt()
    {
        var rnd = new Random(); 
        return _prompts[rnd.Next(0, _prompts.Count)];
    }
}