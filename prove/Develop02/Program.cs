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
        userChoice = int.Parse(Console.ReadLine());
        if (userChoice == 1)
        {
            Journal write1 = new Journal();
            write1.Write();
        }  
        if (userChoice == 2)
        {
            Journal myJournal = new Journal();
            Journal write1 = new Journal();                
            myJournal._journalEntries.Add(write1);
            myJournal.Display();
        }
        else 
        {
            Console.WriteLine("Thank you for using the journal program. Goodbye.");
        }
        
    }      
}