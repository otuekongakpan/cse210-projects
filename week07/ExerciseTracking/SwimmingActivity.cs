using System;

public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity() : base()
    {
        _laps = 0;
    }

    public void SetLap(int laps)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0; // KM
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinute()) * 60;
    }

    public override double GetPace()
    {
        double dist = GetDistance();
        if (dist == 0) return 0;
        return GetMinute() / dist; 
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Distance {GetDistance():0.00} km, Speed {GetSpeed():0.00} km/h, Pace {GetPace():0.00} min/km.";
    }
}
