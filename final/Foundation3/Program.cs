using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Here are the menu options:");
        Console.WriteLine("1. Lecture");
        Console.WriteLine("2. Reception");
        Console.WriteLine("3. Outdoor Gathering");
        Console.WriteLine("4. Quit");
        int userChoice = -1;
        while (userChoice != 4)
        {
            userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    Lecture lecture = new Lecture();
                    lecture.DisplayEvent();
                    break;
                case 2:
                    Reception reception = new Reception();
                    reception.DisplayEvent();
                    break;
                case 3:
                    OutdoorGathering outdoorGathering = new OutdoorGathering();
                    outdoorGathering.DisplayEvent();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the event program!");
                    break;
            }
        }
    }
}