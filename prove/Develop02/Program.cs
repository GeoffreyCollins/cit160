using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Menu menu = new Menu();
        PromptManager promptMan = new PromptManager();

        string filename = "";

        int choice = -1;
        while (choice != 5) 
        {
            menu.Display();
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    string prompt = promptMan.GetPrompt();
                    System.Console.WriteLine(prompt);
                    string input = Console.ReadLine();
                    Entry entry = new Entry();

                    DateTime thisDay = DateTime.Today;
                    entry._date = thisDay.ToShortDateString();
                    entry._entry = input;
                    entry._prompt = prompt;

                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    System.Console.Write("Enter FileName to load journal");
                    filename = Console.ReadLine();
                    journal.Load(filename);
                    break;
                case 4:
                    System.Console.WriteLine("Enter FileName to Save journal");
                    filename = Console.ReadLine();
                    journal.Save(filename);
                    break;
            }
        }
    }
}