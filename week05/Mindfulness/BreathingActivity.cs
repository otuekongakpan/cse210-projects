using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }

public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        Console.Clear();
        
        Console.WriteLine("Get ready....");
        ShowSpinner(3);
        Console.WriteLine("");   

        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in.....");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write("Breath out.....");
            ShowCountDown(4);
            Console.WriteLine();

            Console.WriteLine("");
        }
        
        Console.WriteLine("");
        DisplayEndingMessage();
        Console.WriteLine("");
    }

}