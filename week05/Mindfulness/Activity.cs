using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine($"{_description}");
        Console.Write("How long in seconds do you want this session to last? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Congratulations! You did a good job.");
        ShowSpinner(3);
        Console.WriteLine($"You completed the {_name} Activity in {_duration} seconds!");
        Thread.Sleep(3000);
    }

    public void ShowSpinner(int seconds)
    {   
        string[] symbols = { "|", "/", "-", "\\" };
        int index = 0;

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(symbols[index]);  
            Thread.Sleep(200);              

            Console.Write("\b \b");         

            index = (index + 1) % symbols.Length;
        }
    }


    public void ShowCountDown(int seconds)
    {

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            Console.Write("\b \b");
        }

    }

}