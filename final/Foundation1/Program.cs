using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("First Video", "Mac Peterson", 60);
        video1.AddComment(new Comment("Mac", "This is a Great Video!"));
        video1.AddComment(new Comment("Bob", "Thanks! This is exactly what we are looking at."));
        video1.AddComment(new Comment("Oswell", "I'm flawed bro! Kudos"));
        videos.Add(video1);

        Video video2 = new Video("Second Video", "James Bond", 85);
        video2.AddComment(new Comment("James", "I will enroll right away!"));
        video2.AddComment(new Comment("Percy", "Good course!"));
        video2.AddComment(new Comment("John", "This is an amazing experience!"));
        videos.Add(video2);

        Video video3 = new Video("Third Video", "King Booker", 120);
        video3.AddComment(new Comment("Vick", "Looks good!"));
        video3.AddComment(new Comment("Rocky", "We love you!"));
        video3.AddComment(new Comment("Sackey", "Keep creating great contents!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}