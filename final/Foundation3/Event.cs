using System.Net.Sockets;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address) 
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandardDetails()
    {
        string address = _address.GetAddress();
        Console.WriteLine($"{_title}\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine($"When: {_date} - {_time}");
        Console.WriteLine($"Where: {address}\n");
    }
    public void DisplayShortDescription()
    {
        var eventType = GetType().Name;
        Console.WriteLine($"{eventType}: {_title}");
    }
}