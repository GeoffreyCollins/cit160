using System;

public class Entry {
    public List<Entry> _entries = new List<Entry>();
    public string Write() {
        Random rand = new Random();
        string[] prompts = {"What would you have done differently today? ", 
                            "What is a positive from today? ",
                            "How were you of service to others? ",
                            "Did you do anything productive? If not, what can you do now? ", 
                            "Is there anything that needs to be done today to prepare for tomorrow? "};
        int index = rand.Next(prompts.Length);
        Console.WriteLine(prompts[index]);
        Console.Write("> ");
        string userPromptResponse = Console.ReadLine();
        return userPromptResponse;
    }
     public void Display()
     {
        foreach (Entry entry in _entries)
        {
            _entries.Add(entry);
            entry.Display();
        }
    }
}