using System;

class Reception : Event
{
    public Reception() : base("Wedding Reception", "Reception after a Sealing", "April 07, 2023", "6:00 PM", "S 2nd W & 3rd W, Rexburg, ID")
    {

    }

    public Reception(string title, string desc, string date, string time, string address) 
                : base(title, desc, date, time, address)
    {

    }

    public void PresentReception()
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