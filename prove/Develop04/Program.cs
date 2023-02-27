using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breath = new BreathingActivity(30);
        breath.Display();
        breath.DoTheThing();
    }
}