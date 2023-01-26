using System;


class Program
{
    static void Main(string[] args)
    {   
        int userChoice = -1;
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please enter one of the following choices: ");
        Console.WriteLine("1. Write ");
        Console.WriteLine("2. Display ");            
        Console.WriteLine("3. Load ");
        Console.WriteLine("4. Save ");
        Console.WriteLine("5. Quit"); 
        Console.Write("What would you like to do? ");
        while (userChoice != 5)
        {
            userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1)
            {
                Entry write1 = new Entry();
                write1.Write();
            }  
            if (userChoice == 2)
            {
                Entry display1 = new Entry();
                display1.Display();
            }
            if (userChoice == 5)
            {
            Console.WriteLine("Thank you for using the journal program. Goodbye.");
            }
        }
    }      
}