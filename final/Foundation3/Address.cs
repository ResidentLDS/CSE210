using System.ComponentModel.DataAnnotations;
using System.Data;

class Address // So it said to use an address class, so I kinda copied some code from the last foundation project to make it easier on me
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
        
        _streetAddress = parts[0];
        _city = parts[1];
        _state = parts[2];
        _country = parts[3];
        

    }

    public string PrintAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state} \n{_country}";
    }
}