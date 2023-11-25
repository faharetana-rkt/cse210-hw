public class Address
{
	private string _streetAddress;
	private string _city;
	private string _stateProvince;
	private string _country;

	public Address(string street, string city, string stateProvince, string country)
	{
		_streetAddress = street;
		_city = city;
		_stateProvince = stateProvince;
		_country = country;
	}

	public string Location()
	{
		if (_country == "USA")
		{
			return "National";
		}
		else
		{
			return "International";
		}
	}

	public string GetAddress()
	{
		return $"{_streetAddress} \n{_city}, {_stateProvince} \n{_country}";
	}
}