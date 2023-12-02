public class Address
{
    private string _venue;
    private string _city;
    private string _county;

    public Address(string venue, string city, string county)
    {
        _venue = venue;
        _city = city;
        _county = county;
    }

    public override string ToString()
    {
        return $"{_venue}, {_city}, {_county}";
    }
}