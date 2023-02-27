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
    {
        
    }

    public void DoTheThing()
    {
       Console.WriteLine("Get ready....");
       DisplayDelay(5);
    }
}