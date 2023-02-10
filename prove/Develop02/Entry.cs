using System;

class Entry 
{
    public string _date = "";
    public string _prompt = "";
    public string _entry = "";

    public void display() 
    {
        System.Console.WriteLine($"Date: {_date} - {_prompt}");
        System.Console.WriteLine(_entry);
        System.Console.WriteLine();
    }
}