using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("C# Programming Tutorial", "John Doe", 3600);
        video1.AddComment(new Comment("Alice", "Great video! Very informative."));
        video1.AddComment(new Comment("Bob", "Thanks for the tips!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot from this."));

        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 5400);
        video2.AddComment(new Comment("Dave", "This is exactly what I needed!"));
        video2.AddComment(new Comment("Eve", "Excellent explanation!"));

        Video video3 = new Video("C# Design Patterns", "Alice Johnson", 4800);
        video3.AddComment(new Comment("Frank", "Design patterns are crucial for good software design."));
        video3.AddComment(new Comment("Grace", "I love how you explained the Singleton pattern!"));

        Video video4 = new Video("C# LINQ Basics", "Bob Brown", 3000);
        video4.AddComment(new Comment("Hank", "LINQ makes data manipulation so much easier!"));
        video4.AddComment(new Comment("Ivy", "Great introduction to LINQ!"));

        List<Video> videos = new List<Video> { video1, video2, video3, video4 };
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentNumber()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Author}: {comment.Content}");
            }
            Console.WriteLine();
        }

    }
}