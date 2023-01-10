using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Hello world!");
        }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userResponse = Console.ReadLine();
        int userNumber = int.Parse(userResponse);
        return userNumber;
    }

    static void SquareNumber(string userName, int userNumber)
    {
        double numberSquared = (userNumber * userNumber);
        Console.WriteLine($"{userName}, the square of your number is {numberSquared}.");
    }
        DisplayMessage();
        SquareNumber(PromptUserName(), PromptUserNumber());
    }
}