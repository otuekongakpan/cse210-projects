using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3); 

        Console.WriteLine("Reflect on this prompt:");
        Console.WriteLine(GetRandomPrompt());

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("Get ready....");
        ShowSpinner(3);
        Console.WriteLine("");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());

            string answer = Console.ReadLine();

            ShowSpinner(2);
            Console.WriteLine("");
        }

        DisplayEndingMessage();
        Console.WriteLine("");
    }


    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    
        public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }

}