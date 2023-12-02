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

	// SMT method should return boolean i.e.
	// public bool IsUsaAddress()
	public bool IsUsaAddress()
	{
		if (_country == "USA")
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	// SMT you could use public override string ToString()
	public override string ToString()
	{
		return $"{_streetAddress} \n{_city}, {_stateProvince} \n{_country}";
	}
}