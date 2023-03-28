using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video();
        Comment comment = new Comment();

        int choice = -1;

        while (choice != 0)
        {
            Console.WriteLine("Enter 1 if you would like to add a video, enter 0 to end the program");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("What is the name of the video?");
                    string videoInput = Console.ReadLine();
                    Console.Write("Who made the video?");
                    string videoAuthor = Console.ReadLine();
                    Console.Write("How long is the video (in seconds)?");
                    string videoLength = Console.ReadLine();
                    video._title = videoInput;
                    video._author = videoAuthor;
                    video._length = videoLength;
                    video.display();
                    break;
                case 0:
                    Console.WriteLine("Thank you for using the Youtube program!");
                    break;
            }
        }

    }
}