using System;

class Goal
{
    public string _goalName = "";
    public List<Goal> _goals = new List<Goal>();
    public void AddGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");

        Console.WriteLine("Which type of goal would you like to create?");
        string typeGoal = Console.ReadLine();

        Console.WriteLine("What is the name of your goal?");
        string nameOfGoal = Console.ReadLine();

        Console.WriteLine("What is a short description of your goal?");
        string descriptionGoal = Console.ReadLine();

        Console.WriteLine("How many points will there be associated with this goal?");
        int points = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How many times does this goal need to be completed to get a bonus?");
        int pointBonus = Convert.ToInt32(Console.ReadLine());

        
    }

    public void DisplayList()
    {
        Console.WriteLine($"[] {_goalName}");
        Console.WriteLine();
    }

    public void SaveGoal(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"[] {goal}");
            }
        }
    }
    public void LoadGoal(string filename)
    {
        _goals.Clear();

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines) 
        {
            string[] parts = line.Split("|");
            Goal goal = new Goal();
            goal._goalName = parts[0];
            _goals.Add(goal);
        }
    }
}