using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        RunningActivity r1 = new RunningActivity();
        r1.SetDate("09 Dec 2025");
        r1.SetMinute(30);
        r1.SetName("Running");
        r1.SetDistance(10);

        CyclingActivity c1 = new CyclingActivity();
        c1.SetDate("09 Dec 2025");
        c1.SetMinute(70);
        c1.SetName("Cycling");
        c1.SetSpeed(20);

        SwimmingActivity s1 = new SwimmingActivity();
        s1.SetDate("09 Dec 2025");
        s1.SetMinute(50);
        s1.SetName("Swimming");
        s1.SetLap(20);

        activities.Add(r1);
        activities.Add(c1);
        activities.Add(s1);
        
        foreach (Activity activity in activities)
        {
            string act = activity.GetSummary();
            Console.WriteLine(act);
        }
    }
}