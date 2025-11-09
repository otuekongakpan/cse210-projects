using System;


public class Job
{
    public string _jobTitle = "";
    public string _company = "";
    public int _StartYear = 0;
    public int _EndYear = 0;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_StartYear}-{_EndYear}");
    }
    



}
