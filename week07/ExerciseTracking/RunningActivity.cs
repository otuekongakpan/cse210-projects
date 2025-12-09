using System;

public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity() : base()
    {
        _distance = 0;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public void SetDistance(double distance)
    {
        _distance = distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetMinute()) * 60;
    }

    public override double GetPace()
    {
        return GetMinute() / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Distance {GetDistance():0.00} km, Speed {GetSpeed():0.00} km/h, Pace {GetPace():0.00} min/km.";
    }
}