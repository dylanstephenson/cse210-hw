public class Entry
{
    public static DateTime _dateTime = DateTime.Now;
    public string _date = _dateTime.ToShortDateString();
    public static PromptGenerator _getPrompt =  new PromptGenerator();
    public string _promptText = _getPrompt.GetRandomPrompt();
    public string _entryText;
    
    public void Display()
    {
        Console.WriteLine($"\nDate: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}\n");
    }
}