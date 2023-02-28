using System;

class ListingActivity : Activity 
{
    public ListingActivity(int duration) : base("List",
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                                                 "Welcome to the Listing Activity!",
                                                 "Thank you for using the Listing Activity!",
                                                 duration)
    {

    }

    public ListingActivity(string name, string desc, string welcomeMessage, string endingMessage, int duration)
        : base(name, desc, welcomeMessage, endingMessage, duration)
    {

    }

    public string[] _listPrompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that have helped you out this week?"
    };

    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _listPrompts.Length);
        return(_listPrompts[index]);
    }

    public void timeBeforeResponse(int timeList)
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

    public List<string> _responses = new List<string>();
    public void DoActivity()
    {
        DisplayWelcome();
        Console.WriteLine();
        DisplayDesc();
        Console.WriteLine();
        Console.Write("Please enter, in seconds, how long you would like to participate: ");
        int duration = Convert.ToInt32(Console.ReadLine());
        DisplayDelay(5);
        Console.Clear();
        Console.WriteLine("Get ready....");
        DisplayDelay(5);
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"---- {GetPrompt()}  ----");
        Console.Write("You may begin in: ");
        timeBeforeResponse(4);
        _responses.Add(Console.ReadLine());
        int count = _responses.Count();
        Console.WriteLine($"You listed {count} items!");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        DisplayEnding();
    }
}