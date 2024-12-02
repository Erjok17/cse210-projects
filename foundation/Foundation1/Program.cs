using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

         // Create videos
        Video video1 = new Video("Intro to C#", "Skul boi tech", 600);
        Video video2 = new Video("Fun with Unity", "GameDevDave", 1200);

        // Add comments
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Erjok", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Bro its Clear and concise!"));

        video2.AddComment(new Comment("Dave", "Can't wait to try this!"));
        video2.AddComment(new Comment("Ekon", "Yoo! this is lit , I love this content!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2 };

        // Display details for each video
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}