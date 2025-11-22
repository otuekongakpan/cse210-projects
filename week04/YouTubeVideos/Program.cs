using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video();
        v1._author = "Mich";
        v1._title = "Summer Holiday";
        v1._length = 620;
        v1._comment = new List<Comment>();
        
        Video v2 = new Video();
        v2._author = "Eleanor";
        v2._title = "Cooking Class";
        v2._length = 730;
        v2._comment = new List<Comment>();

        Video v3 = new Video();
        v3._author = "Arabella";
        v3._title = "Yoga Class";
        v3._length = 869;
        v3._comment = new List<Comment>();

        //Mich video comments
        Comment c1 = new Comment();
        c1._userName = "Brobbey";
        c1._commentText = "I would love to travel to Spain soon";
        v1._comment.Add(c1);

        Comment c2 = new Comment();
        c2._userName = "Sammy";
        c2._commentText = "Amazing Content";
        v1._comment.Add(c2);

        Comment c3 = new Comment();
        c3._userName = "Arthur";
        c3._commentText = "Nice Content";
        v1._comment.Add(c3);
        //Eleanor's video
        Comment c4 = new Comment();
        c4._userName = "Job";
        c4._commentText = "Interesting";
        v2._comment.Add(c4);

        Comment c5 = new Comment();
        c5._userName = "Jill";
        c5._commentText = "I will try this at night";
        v2._comment.Add(c5);

        Comment c6 = new Comment();
        c6._userName = "Otto";
        c6._commentText = "Good Job Ellie!";
        v2._comment.Add(c6);
        
        //Arabella's video
        Comment c7 = new Comment();
        c7._userName = "Job";
        c7._commentText = "Interesting";
        v3._comment.Add(c7);

        Comment c8 = new Comment();
        c8._userName = "Jill";
        c8._commentText = "I will try this at night";
        v3._comment.Add(c8);

        Comment c9 = new Comment();
        c9._userName = "Otto";
        c9._commentText = "Good Job Ellie!";
        v3._comment.Add(c9);

        Console.WriteLine("VIDEO 1");
        v1.Display();

        Console.WriteLine("_______________");

        Console.WriteLine("VIDEO 2");
        v2.Display();

        Console.WriteLine("_______________");

        Console.WriteLine("VIDEO 3");
        v3.Display();
    }
}