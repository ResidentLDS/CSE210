using System.ComponentModel.DataAnnotations;
using System.Data;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    public Address(string entry) //261 Randall Dr, Folsom, California, USA
    {
        string[] parts = entry.Split(",");
        for (int i = 0; i < parts.Length; i++)
        {
            parts[i] = parts[i].Trim();
        }
        if (parts.Length == 4)
        {
            _streetAddress = parts[0];
            _city = parts[1];
            _state = parts[2];
            _country = parts[3];
        }
        else // whenever I found a european address it didn't have a state, just a city and then country, so this makes suer that it will work correctly with the shorter addresses
        {
            _streetAddress = parts[0];
            _city = parts[1];
            _state = null;
            _country = parts[2];
        }
    }

    public bool IsInUSA()
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

    public string PrintAddress()
    {
        if (_state != null)
        {
            return $"{_streetAddress} \n{_city}, {_state} \n{_country}";
        }
        else
        {
            return $"{_streetAddress} \n{_city} \n{_country}";
        }
    }
}