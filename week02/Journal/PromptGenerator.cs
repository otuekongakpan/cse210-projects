using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What are you grateful for today?",
        "Describe a time you helped someone.",
        "What was your happiest moment this week?",
        "What is one goal you want to achieve?",
        "Who inspires you the most and why?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}
