public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string type, string speaker, int capacity) : base(title, description, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"{_eventType}: {_eventTitle}, {_description} \nLecturer: {_speaker} \nCapacity: {_capacity} persons\nDate: {_date} at {_time} \nLocation: {_address.ToString()}";
    }
}