using System;
using System.Collections.Generic;

public class Comment
{
    private string _commenterName;
    private string _text;

    public Comment(string name, string text)
    {
        _commenterName = name;
        _text = text;
    }

    public string GetCommenter()
    {
        return _commenterName;
    }

    public string GetText()
    {
        return _text;
    }
}

public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthSeconds = length;
    }

    public void AddComment(Comment c)
    {
        _comments.Add(c);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthSeconds} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");

        foreach (var c in _comments)
        {
            Console.WriteLine($"- {c.GetCommenter()}: {c.GetText()}");
        }
        Console.WriteLine();
    }
}

class Program2
{
    static void Main(string[] args)
    {
        Video v1 = new Video("C# Tutorial", "Alice", 600);
        v1.AddComment(new Comment("Bob", "Great tutorial!"));
        v1.AddComment(new Comment("Clara", "Thanks for explaining well."));

        Video v2 = new Video("Learn Encapsulation", "David", 450);
        v2.AddComment(new Comment("Eve", "Super helpful."));
        v2.AddComment(new Comment("Frank", "Now I understand classes!"));

        List<Video> videos = new List<Video> { v1, v2 };

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
