using System;

class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breath", 
    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 
                                                  "Welcome to the Breathing Activity!", 
                                                  "Thank you for using the Breathing Activity!",
                                                  duration)
    {
        
    }

    public BreathingActivity(string name, string desc, string welcomeMessage, string endingMessage, int duration) 
        : base(name, desc, welcomeMessage, endingMessage, duration)
    {
       
    }

    public void DisplayInstructions(int timeBreath)
    {
        List<int> animationNumbers = new List<int>();
        animationNumbers.Add(4);
        animationNumbers.Add(3);
        animationNumbers.Add(2);
        animationNumbers.Add(1);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(4);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            int n = animationNumbers[i];
            Console.Write(n);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= animationNumbers.Count)
            {
                i = 0;
            }
        }
    }
    public void DoActivity()
    {
        DisplayWelcome();
        Console.WriteLine();
        DisplayDesc();
        Console.WriteLine();
        Console.Write("Please enter, in seconds, a duration for the activity: ");
        int duration = Convert.ToInt32(Console.ReadLine());
        DisplayDelay(5);
        Console.WriteLine("Get ready....");
        Console.WriteLine();
        Console.Write("Now breathe in...");
        DisplayInstructions(4);
        Console.WriteLine();
        Console.Write("Breathe out....");
        DisplayInstructions(4);
        Console.WriteLine();
        Console.WriteLine();
        DisplayEnding();
    }
    
}