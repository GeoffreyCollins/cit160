using System;
using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        int count = 0;
        foreach (Entry entry in _entries)
        {
            count++;
            System.Console.WriteLine(count);
            entry.display();
        }
    }

    public void Load()
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._entry = parts[1];
            entry._prompt = parts[2];
            _entries.Add(entry);
        }
    }

    public void Save(string filename) 
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._entry}|{entry._prompt}");
            }
        }
    }
}