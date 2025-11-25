using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment a1 = new MathAssignment("Matthew", "Algebra", "12.7", "20-32");

        Console.WriteLine(a1.GetSummary());
        Console.WriteLine(a1.GetHomeworkList());

        WritingAssignment a2 = new WritingAssignment("Michelle", "Mild Expectations", "The Beginnning of the End");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetWritingInformation());
    }
}