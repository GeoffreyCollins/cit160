using System;

class Comment 
{
    public string _commentAuthor = "";
    public string _text = "";

    public void Display()
    {
        Console.WriteLine($"Author: {_commentAuthor} - Text: {_text}");
    }
}