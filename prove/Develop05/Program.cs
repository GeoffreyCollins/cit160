using System;

class Program
{
    static void Main(string[] args)
    {
        Goal goal = new Goal();
        MenuManager menu = new MenuManager();

        int pointCount = 0;

        string filename = "";

        int userChoice = -1;
        while (userChoice != 6)
        {
            Console.WriteLine($"You have {pointCount} points");

            menu.Display();
            userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    goal.AddGoal();
                    break;
                case 2:
                    goal.DisplayList();
                    break;
                case 3:
                    Console.WriteLine("Please enter the filename that you would like to save to: ");
                    filename = Console.ReadLine();
                    goal.SaveGoal(filename);
                    break;
                case 4:
                    Console.WriteLine("Please enter the filename that you would like to load:");
                    filename = Console.ReadLine();
                    goal.LoadGoal(filename);
                    break;
                case 5:
                    goal.RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Thank you for using the goal program. Goodbye.");
                    break;
            }
        }
    }
}