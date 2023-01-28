using System;


class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Welcome to the Journal Program!");
        int userChoice = -1;
        while (userChoice != 5)
        {
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
                Entry write1 = new Entry();
                string userEntry = write1.Write();
            }  
            if (userChoice == 2)
            {
                Journal display1 = new Journal();
                display1.Display();
            }
            if (userChoice == 3)
            {
                
            }
            if (userChoice == 5)
            {
            Console.WriteLine("Thank you for using the journal program. Goodbye.");
            }
        }
    }      
}