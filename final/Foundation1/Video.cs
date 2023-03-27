using System;

class Video 
{
    public string _title = "";
    public string _author = "";
    public string _length = "";

    public void Display()
    {
        System.Console.WriteLine("Video Details:");
        System.Console.WriteLine($"Title: {_title} - Author: {_author} - Length (in seconds): {_length}");
    }
}