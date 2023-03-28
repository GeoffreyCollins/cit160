using System;

class Customer 
{
    public string _name = "";
    public void GetCustomerInfo()
    {   
        Address address = new Address();
        Console.Write("What is your name?");
        string nameInput = Console.ReadLine();
        Console.Write("What is your street address?");
        string addressInput = Console.ReadLine();
        Console.Write("What city do you live in?");
        string cityInput = Console.ReadLine();
        Console.Write("What state/province do you live in?");
        string stateInput = Console.ReadLine();
        Console.Write("What country do you live in?");
        address._streetAddress = addressInput;
        address._city = cityInput;
        address._state = stateInput;
        Console.Write($"Customer Name: {nameInput}");
        address.GetAddressInfo();
    }
    
}