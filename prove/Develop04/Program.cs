using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        int userChoice = -1;
        while (userChoice != 4)
        {
            userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    BreathingActivity breath = new BreathingActivity(30);
                    breath.DisplayWelcome();
                    Console.WriteLine();
                    breath.DisplayDesc();
                    Console.WriteLine();
                    breath.DoActivity();
                    Console.WriteLine();
                    breath.DisplayEnding();
                    break;
            }
        }
    }
}