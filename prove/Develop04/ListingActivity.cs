public class ListingActivity : Activity
{
    // Not super clear on the necessity of _count, so I'm just using it to count the number of entries the user inputs during the activity. 
    private int _count;
    private List<string> _prompts = new List<string>();

    // Constructor will need all attributes from the base for DisplayStart and Display End on the activity, also using the duration in the run command. 
    public ListingActivity(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = prompts;
    }
    // This function will run when the user selects the Listing Activity
    public void Run()
    {
        List<string> entries = new List<string>();

        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(4);
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        GetRandomPrompt();
        Console.WriteLine("You may begin:");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            entries.Add(Console.ReadLine());
        }
        _count = entries.Count();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
        
    }
    // 
    private void GetRandomPrompt()
    {
        Random random = new Random();
        int randInt = random.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[randInt]} ---");
    }
    // Not really sure what the purpose of this function is. I set the lists in the constructors for the classes, so I don't really need this. It was just in the description for the project
    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}