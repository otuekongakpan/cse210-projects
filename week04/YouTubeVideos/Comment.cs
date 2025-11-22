using System;



public class Comment
{
    public string _userName;
    public string _commentText;

    public void DisplayComment()
    {
        Console.WriteLine($"User Name: {_userName}");
        Console.WriteLine($"Comment: {_commentText}");

    }
}