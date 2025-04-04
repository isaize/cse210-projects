using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        // Creating videos
        Video video1 = new Video("Understanding C#", "Jane Doe", 300);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very informative."));
        video1.AddComment(new Comment("Charlie", "Thanks for the tips!"));

        Video video2 = new Video("OOP Concepts Explained", "John Smith", 450);
        video2.AddComment(new Comment("David", "Well explained!"));
        video2.AddComment(new Comment("Eve", "This helped me a lot."));
        video2.AddComment(new Comment("Frank", "Keep it up!"));

        Video video3 = new Video("Data Structures in C#", "Sarah Lee", 600);
        video3.AddComment(new Comment("Grace", "Nice overview."));
        video3.AddComment(new Comment("Hank", "I learned a lot."));
        video3.AddComment(new Comment("Ivy", "Thanks for this!"));

        // Adding videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Displaying video details
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}

public class Comment
{
    private string name;
    private string text;

    public string GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        name = value;
    }

    public string GetText()
    {
        return text;
    }

    public void SetText(string value)
    {
        text = value;
    }

    public Comment(string name, string text)
    {
        SetName(name);
        SetText(text);
    }
}

public class Video
{
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments;

    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string value)
    {
        title = value;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string value)
    {
        author = value;
    }

    public int GetLengthInSeconds()
    {
        return lengthInSeconds;
    }

    public void SetLengthInSeconds(int value)
    {
        lengthInSeconds = value;
    }

    public Video(string title, string author, int lengthInSeconds)
    {
        SetTitle(title);
        SetAuthor(author);
        SetLengthInSeconds(lengthInSeconds);
        comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}