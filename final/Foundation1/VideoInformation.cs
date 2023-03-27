using System;

class VideoInformation
{
    public string _title = "";
    public string _author = "";
    public string _length = "";

    public List<Comment> _comments = new List<Comment>();

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void Display()
    {
        System.Console.WriteLine("Video Details:");
        System.Console.WriteLine($"Title: {_title} - Author: {_author} - Length (in seconds): {_length}");
    }
}