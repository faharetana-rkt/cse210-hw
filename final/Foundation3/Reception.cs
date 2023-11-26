public class Reception : Event
{
    private string _mailRSVP;

    public Reception(string title, string description, string date, string time, Address address, string type, string mail) : base(title, description, date, time, address, type)
    {
        _mailRSVP = mail;
    }

    public override string FullDetails()
    {
        return $"{_eventType}: {_eventTitle}, {_description} \nReservation mail: \n{_mailRSVP}\nDate: {_date} at {_time} \nLocation: {_address.ToStr()}";
    }
}