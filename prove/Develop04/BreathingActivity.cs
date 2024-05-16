public class BreathingActivity : Activity
{
    // constructor has no new attributes, so it is taking everything from the Base constructor. 
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    // This will run when the user selects the breathing activity from the display menu in Program.cs
    public void Run()
    {
        DisplayStartingMessage();


        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(4);

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        Console.Write("\nBreathe in...");
        ShowCountdown(2);

        Console.Write("\nNow breathe out...");
        ShowCountdown(3);

        Console.Write("\n\nBreathe in...");
        ShowCountdown(2);

        Console.Write("\nNow breathe out...");
        ShowCountdown(3);

        while (DateTime.Now < end)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountdown(4);

            Console.Write("\nNow breathe out...");
            ShowCountdown(6);
        }
        

        DisplayEndingMessage();

    }
}