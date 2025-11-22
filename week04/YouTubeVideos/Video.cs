using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comment = new List<Comment>();

    public int NumberOfComment()
    {
        return _comment.Count;
    }
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {NumberOfComment()}");
        Console.WriteLine("COMMENTS:");

        foreach (Comment c in _comment)
        {
            c.DisplayComment();
        }
    }


}