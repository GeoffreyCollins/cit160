using System;

class Customer 
{
    public string _name = "";

    Address address = new Address();
    public void GetCustomerInfo()
    {   
        Console.Write("What is your name?");
        string name = Console.ReadLine();
        Console.Write("What is your street address?");
        string address = Console.ReadLine();
        Console.Write("What city do you live in?");
        string city = Console.ReadLine();
        Console.Write("What state/province do you live in?");
        string state = Console.ReadLine();
        Console.Write("What country do you live in?");
    }
}