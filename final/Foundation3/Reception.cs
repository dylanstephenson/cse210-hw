public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvp) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvp;
    }
    public void DisplayFullDetails()
    {
        string address = _address.GetAddress();
        Console.WriteLine($"Reception Event: {_title}\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine($"When: {_date} - {_time}");
        Console.WriteLine($"Where: {address}\n");
        Console.WriteLine($"An RSVP/Registration is required in order to attend this event. To register for the event, please email {_rsvpEmail}.\n");
    }
}