using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    { "Who are the people that you appreciate?",
      "What are personal strengths of yours?",
      "Who are people that you have helped this week?",
      "When have you felt the Holy Ghost this month?",
      "Who are some of your personal heroes?"
       };

    public ListingActivity(int count, int duration, string name, string description) : base(name, description, duration)
    {
        _count = count;

    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

 public void Run()
    {

        DisplayStartingMessage();
        ShowSpinner(3);
        Console.WriteLine("");

        Console.WriteLine("List as many responses as you can for the following prompt:");
        GetRandomPrompt();


        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        Console.WriteLine("");
        List<string> responses = GetListFromUser();

        _count = responses.Count;

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine("");
        DisplayEndingMessage();
        Console.WriteLine("");
    }
    public List<string> GetListFromUser()
    {
        List<string> userResponse = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        Console.WriteLine("Start listing your responses. You have limited time!");

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    userResponse.Add(input);
                }
            }
        }

        return userResponse;
    }


    
}