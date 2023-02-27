using System;

class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breath", "desc", 
                                                  "Welcome to the Breathing Activity!", 
                                                  "Thank you for using the Breathing Activity!",
                                                  duration)
    {

    }

    public BreathingActivity(string name, string desc, string welcomeMessage, string endingMessage, int duration)
    {

    }

    public void DoTheThing()
    {
        DisplayDelay(3);
        Console.WriteLine("DO IT");
        DisplayDelay(2);
    }
}