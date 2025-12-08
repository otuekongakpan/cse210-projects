using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        return GetPoints();

    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        } else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        return  $"{base.GetDetailsString()},{_amountCompleted},{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetDetailsString()},{_bonus}";
    }
}