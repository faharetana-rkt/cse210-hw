public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // SMT you're supposed be checking if they reside in USA
    public bool IsResident()
    {
        if (_address.Location() == "National")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string ToStr()
    {
        return $"{_name} \n{_address.GetAddress()}";
    }
}