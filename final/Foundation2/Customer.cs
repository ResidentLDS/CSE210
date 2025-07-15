using System.Dynamic;
using System.Net.Sockets;

class Customer
{
    private string _name;
    private Address _addy;

    public Customer(string name, string address)
    {
        _name = name;
        _addy = new Address(address);
    }

    public int GetShippingPrice()
    {
        if (_addy.IsInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _addy.PrintAddress();
    }
}