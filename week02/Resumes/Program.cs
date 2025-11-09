using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "ASUS";
        job1._StartYear = 2019;
        job1._EndYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Quality Assurance Engineer";
        job2._company = "HP";
        job2._StartYear = 2022;
        job2._EndYear = 2025;

        job1.Display();
        job2.Display();

    }
    
}