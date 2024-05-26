public class OutdoorGathering : Event
{
    private string _forecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string forecast) : base(title, description, date, time, address)
    {
        _forecast = forecast;
    }

    public void DisplayFullDetails()
    {
        string address = _address.GetAddress();
        Console.WriteLine($"Outdoor Gathering - {_title}\n");
        Console.WriteLine($"{_description}\n");
        Console.WriteLine($"When: {_date} - {_time}");
        Console.WriteLine($"Where: {address}");
        Console.WriteLine($"Forecast: {_forecast}\n");
    }
}