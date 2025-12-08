using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public string GetName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public  virtual string GetDetailsString()
    {
        return $"{_shortName},{_description},{_points}";
    }
    public abstract string GetStringRepresentation();

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
}