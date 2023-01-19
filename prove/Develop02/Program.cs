using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        int userChoice = -1;
        Console.WriteLine("Welcome to the journal program!");
        Console.WriteLine("Please select one of the following options:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit"); 
    }

    class Write
    {
        string[] userOptions = {"What was the most interesting thing that happened to you today?", 
                                "What was your favorite meal from the day?",
                                "What would you have done differently?",
                                "What was a good thing that happened?",
                                "Is there anything you need to do today to prepare for tomorrow?"};

    }
        
}