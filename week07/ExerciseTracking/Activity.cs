using System;

public abstract class Activity
{
    private string _date;
    private int _minute;
    private string _name;


    public Activity()
    {
        _date = "";
        _minute = 0;
        _name = "";
    }

    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public int GetMinute()
    {
        return _minute;
    }

    public void SetMinute(int minute)
    {
        _minute = minute;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{GetDate()} {GetName()} ({GetMinute()} min): ";
    }
}