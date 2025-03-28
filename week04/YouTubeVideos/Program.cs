using System;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Understanding Abstraction", "Tech Guru", 300);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Can you make a video on encapsulation?"));

        Video video2 = new Video("C# Classes and Objects", "Code Master", 450);
        video2.AddComment(new Comment("Dave", "Well-structured content."));
        video2.AddComment(new Comment("Eve", "Loved the examples."));
        video2.AddComment(new Comment("Frank", "This made OOP easier for me!"));

        Video video3 = new Video("Intro to Programming", "Beginner's Hub", 600);
        video3.AddComment(new Comment("Grace", "Very beginner-friendly!"));
        video3.AddComment(new Comment("Hank", "Perfect for newcomers."));
        video3.AddComment(new Comment("Ivy", "This should be a series!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}

