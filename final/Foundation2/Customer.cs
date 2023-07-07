public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        _address = new Address(street, city, state, country);
    }

    public bool isUS()
    {
        return _address.isUS();
    }

    public string GetShippingInfo()
    {
        return $"Customer: {_name}  Address: {_address.Display()}";
    }
}