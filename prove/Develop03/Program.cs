using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please press 'enter' to continue or type 'quit' to finish:");
        Console.Write("John 4:14 - ");
        List<string> verses = new List<string>
        {
            "But whosoever drinketh of the water that I shall give him",
            "shall never thirst but the water that I shall give him",
            "shall be in a well of water springing up into everlasting life"
        };

        Scripture scrip = new Scripture(verses);
        scrip.Display();
        scrip.HideWords(4);
        scrip.IsAllHidden();
    }
}