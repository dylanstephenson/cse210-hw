public class Activity
{
    private string _name;
    private string _description;
    // I decided to make _duration protected because I would like each of the Run() methods in my other classes to have access to the duration. 
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 60;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowEmojiFaces(4);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowEmojiFaces(4);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> characters = new List<string>();
        characters.Add("|");
        characters.Add("/");
        characters.Add("-");
        characters.Add(@"\");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write(characters[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i ++;

            if (i >= characters.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowEmojiFaces(int seconds)
    {
        List<string> emojis = new List<string>()
        {
            "😩","🙁","😐","🙂","😀"
        };

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write(emojis[i]);
            Thread.Sleep(800);
            Console.Write("\b\b  \b\b");

             i ++;

            if (i >= emojis.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}