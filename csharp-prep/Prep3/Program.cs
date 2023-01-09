using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        int numberGuess = -1;

        while (numberGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            numberGuess = int.Parse(Console.ReadLine()); 
            if (numberGuess > magicNumber)
            {
                Console.WriteLine("Higher ");
            }
            else if (numberGuess < magicNumber)
            {
                Console.WriteLine("Lower ");
            }
            else 
            {
                Console.WriteLine("You guessed it! ");
            }
        }
    }
}