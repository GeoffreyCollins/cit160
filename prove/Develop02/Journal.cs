using System;

public class Journal {
    public List<Journal> _journalEntries = new List<Journal>();
    public string Write()
    {
        // The list of random prompts for the user 
        string[] prompts = {"What would you have done differently today? ", 
                            "What is a positive from today? ",
                            "How were you of service to others? ",
                            "Did you do anything productive? If not, what can you do now? ", 
                            "Is there anything that needs to be done today to prepare for tomorrow? "};
        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        Console.WriteLine($"Date: 01/28/2023 - Prompt: {prompts[index]} ");
        string userResponse = Console.ReadLine();
        return userResponse;
    }
    public void Display()
    {
        Console.WriteLine($"Date: 1/28/2023 - Entry: {Write()}");
    }
    
}