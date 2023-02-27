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
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
}