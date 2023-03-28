using System;

class Address
{
    public string _streetAddress = "";
    public string _city = "";
    public string _state = "";
    public string _country = "";

    public void GetAddressInfo()
    {
        Console.WriteLine($"{_streetAddress}, {_city}, {_state}, {_country}");
    }
}