using System;

class Video 
{
    public string _title = "";
    public string _author = "";
    public string _length = "";

    public List<Comment> _comments = new List<Comment>();

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void display()
    {
        System.Console.WriteLine("Video Details:");
        System.Console.WriteLine($"Title: {_title} - Author: {_author} - Length (in seconds): {_length}");
    }
    public List<Video> _videos = new List<Video>();

    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }

    public void Display()
    {
        foreach (Video video in _videos)
        {
            video.Display();
        }
    }
}