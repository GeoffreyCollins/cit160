using System;

class Activity
{
    public void AddActivity()
    {
        Console.WriteLine("Here are the options for your activity:");
        Console.WriteLine("1. Running");
        Console.WriteLine("2. Stationary Bike");
        Console.WriteLine("3. Swimming Laps");

        Console.Write("Which activity did you participate in?");
        string typeActivity = Console.ReadLine();

        Console.Write("What was the date of this activity?");
        string dateInput = Console.ReadLine();

        Console.Write("How long did you participate (in minutes)?");
        int durationInput = Convert.ToInt32(Console.ReadLine());

        Console.Write("What was the distance that you accumulated during this activity (in miles)?");
        int distanceInput = Convert.ToInt32(Console.ReadLine());

        float speed = (distanceInput / durationInput) * 60;

        float pace = durationInput / distanceInput;

        Console.WriteLine($"{dateInput} {typeActivity} ({durationInput}): Distance {distanceInput}, Speed {speed}, Pace {pace}");
    }
}