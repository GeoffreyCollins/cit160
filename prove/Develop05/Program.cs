using System;

class Program
{
    static void Main(string[] args)
    {
        MenuManager menu = new MenuManager();

        string filename = "";

        int userChoice = -1;
        while (userChoice != 6)
        {
            menu.Display();
        }
    }
}