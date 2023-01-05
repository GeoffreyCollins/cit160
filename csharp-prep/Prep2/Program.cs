using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);
        if (percent >= 90)
            {
                Console.WriteLine("A");
            }
        else if (percent >= 80)
            {
                Console.WriteLine("B");
            }
        else if (percent >= 70)
            {
                Console.WriteLine("C");
            } 
        if (percent >= 70)
            {
                Console.WriteLine("Congratulations! You passed the class!");
            }
        else if (percent >= 60)
            {
                Console.WriteLine("D");
                Console.WriteLine("You were so close! Try again next time!");
            }
        else 
            {
                Console.WriteLine("F");
                Console.WriteLine("It's ok to fail! It's not ok to give up. You got this!");
            }
    }
}