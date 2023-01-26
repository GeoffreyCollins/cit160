using System;

public class Journal {
    public List<Journal> _entries = new List<Journal>();
    public void Display()
    {
        foreach (Journal entry in _entries)
        {
            Console.WriteLine($"Date: 01/28/2023 - Prompt: {_entries}");
        }
    }
}