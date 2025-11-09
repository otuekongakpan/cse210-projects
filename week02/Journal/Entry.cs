using System;

public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _response = "";

    public void Display()
    {
        Console.WriteLine($"{_date} {_promptText}: {_response}");
    }


}