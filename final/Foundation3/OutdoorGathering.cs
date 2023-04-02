using System;

class OutdoorGathering : Event
{
    public OutdoorGathering() : base("4th of July Potluck", "Party with a BBQ and Games", "July 04, 2023", "4:00 PM", "3100 Droste Rd, St. Charles, MO")
    {

    }

    public OutdoorGathering(string title, string desc, string date, string time, string address) : 
        base(title, desc, date, time, address)
    {

    }

    public void PresentOutdoorGathering()
    {
        Console.Write("Is there any inclement weather in the forecast?");
        string weatherInput = Console.ReadLine();
        if (weatherInput == "no")
        {
            DisplayEvent();
        }
        else {
            Console.WriteLine("You will want to find an indoor venue.");
        }
    }
}