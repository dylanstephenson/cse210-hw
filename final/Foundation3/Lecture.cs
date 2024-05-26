public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void DisplayFullDetails()
    {
        string address = _address.GetAddress();
        Console.WriteLine($"Lecture Event - {_title}\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Event Capacity: {_capacity}");
        Console.WriteLine($"When: {_date} - {_time}");
        Console.WriteLine($"Where: {address}\n");
    }
}