using System;

public class Journal {
    public List<Journal> _journalEntries = new List<Journal>();
    
    public static async Task Save()
    {
        string[] entries = {};
        await File.WriteAllLinesAsync("journal.txt",entries);
    }
}