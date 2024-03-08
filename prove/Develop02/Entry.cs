public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _quote;
    public string _music;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine("");
        Console.WriteLine($"Quote of the day:");
        Console.WriteLine($"{_quote}");
        Console.WriteLine($"Music of the day: {_music}");
        Console.WriteLine("");
    }
}