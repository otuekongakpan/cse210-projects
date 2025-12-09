using System;

public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity() : base()
    {
        _speed = 0;
    }

    public override double GetDistance()
    {
        return  (_speed * GetMinute()) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    } 

    public void SetSpeed(int speed)
    {
        _speed = speed;
    }

    public override double GetPace()
    {
        return GetMinute() / GetDistance();
    }  

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Distance {GetDistance():0.00} km, Speed {GetSpeed():0.00} km/h, Pace {GetPace():0.00} min/km.";
    }
}
