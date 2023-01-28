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
    public void Save()
    {
        StreamWriter fileWriter = new StreamWriter(File.OpenWrite("journal.txt"));
        fileWriter.Write(Write());
    }
    public void Load()
    {
        string[] textFileLines = System.IO.File.ReadAllLines("prove/Develop02/journal.txt"); 
        System.Console.WriteLine("Contents of Entry");
        foreach (string line in textFileLines)
        {
            Console.WriteLine("\t" + line);
        }
    }
}