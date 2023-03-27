using System;

class Video 
{
    public List<VideoInformation> _videos = new List<VideoInformation>();

    public void AddVideo(VideoInformation video)
    {
        _videos.Add(video);
    }

    public void Display()
    {
        foreach (VideoInformation video in _videos)
        {
            video.Display();
        }
    }
}