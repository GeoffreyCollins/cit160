using System;


class Program
{
    static void Main(string[] args)
    {   
        int userChoice = -1;
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please enter one of the following choices: " +
                        "1. Write " +
                        "2. Display " +
                        "3. Load " +
                        "4. Save " +
                        "5. Quit"); 
        Console.WriteLine("What would you like to do? ");
        
        while (userChoice != 5)
        {
            if (userChoice == 1)
            {
                Journal write1 = new Journal();
                write1.Write();
            }
        }
    }      
}