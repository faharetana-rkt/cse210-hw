public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _eventType;

    public Event(string title, string description, string date, string time, Address address, string type)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = type;
    }

    public string StandardDetail()
    {
        return $"{_eventTitle}, {_description} \n{_date} at {_time} \nLocation: {_address.ToString()}";
    }

    public virtual string FullDetails()
    {
        return $"{_eventType}: {_eventTitle}, {_description} \n{_date} at {_time} \nLocation: {_address.ToString()}";
    }

    public string ShortDescription()
    {
        return $"{_eventType}, {_eventTitle}, {_date}";
    }
}