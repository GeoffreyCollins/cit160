using System;

class ReflectionActivity : Activity
{
    public ReflectionActivity(int duration) : base("Reflect",
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                                                    "Welcome to the Reflection Activity!",
                                                    "Thank you for using the Reflection Activity!",
                                                    duration)
    {

    }

    public ReflectionActivity(string name, string desc, string welcomeMessage, string endingMessage, int duration)
        : base(name, desc, welcomeMessage, endingMessage, duration)
    {

    }

    public string[] _startingPrompts = new string[]
    {
        "Think of a time where you did something challenging.",
        "How have you improved yourself?",
        "Think of a time when you helped someone else."
    };

    public string[] _questions = new string[]
    {
        "> Why was this experience meaningful?",
        "> How did you feel when it was complete?",
        "> What is your favorite thing of this experience?"
    };

    public string GetStartingPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _startingPrompts.Length);
        return(_startingPrompts[index]);
    }
    
    public string GetQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Length);
        return(_questions[index]);
    }

    public void timeBeforeResponse(int timeReflect)
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
        Console.Write("Please enter, in seconds, how long you would like to do the activity: ");
        int duration = Convert.ToInt32(Console.ReadLine());
        DisplayDelay(5);
        Console.Clear();
        Console.WriteLine("Get ready.....");
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"---- {GetStartingPrompt()}  ----");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        timeBeforeResponse(4);
        Console.Clear();
        Console.WriteLine(GetQuestion());
        DisplayDelay(10);
        Console.WriteLine();
        Console.WriteLine();
        DisplayEnding();
    }
}