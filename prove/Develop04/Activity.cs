using System;

class Activity 
{
    private string _name = "";
    private string _desc = "";
    private string _welcomeMessage = "";
    private string _endingMessage = "";
    private int _duration = 0;

    public Activity()
    {

    }

    public Activity(string name, string desc, string welcomeMessage, string endingMessage, int duration)
    {
        _name = name;
        _desc = desc;
        _welcomeMessage = welcomeMessage;
        _endingMessage = endingMessage;
        _duration = duration;
    }

    public void Display()
    {
        System.Console.WriteLine(_name);
        System.Console.WriteLine(_desc);
        System.Console.WriteLine(_welcomeMessage);
        System.Console.WriteLine(_endingMessage);
        System.Console.WriteLine(_duration);
    }

    public void DisplayDelay(int delay) 
    {
        int delta = 10;
        double time = delay * 1000;
        while (time < 0)
        {
            Console.WriteLine("/");
            Thread.Sleep(delta);
            time -= delta;
            Console.WriteLine("\b\b");
            Console.WriteLine("--");
            Thread.Sleep(delta);
            Console.WriteLine("\b\b");
            Console.WriteLine("\\");
            Thread.Sleep(delta);
            time -= delta;
            Console.WriteLine("\b\b");
        }
    }
}