public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string type, string weather) : base(title, description, date, time, address, type)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        return $"{_eventType}: {_eventTitle}, {_description} \nWeather forecast: {_weather}\nDate: {_date} at {_time} \nLocation: {_address.ToString()}";
    }
}