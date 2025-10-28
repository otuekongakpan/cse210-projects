using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter = "";
        
        if (grade >= 90)
        {
            if (grade <= 92)
            {
                letter = "A-";
            }
            else
            {
                letter = "A";
            }
        }
        else if (grade >= 80)
        {
            if (grade >= 87)
            {
                letter = "B+";
            }

            else if (grade < 83)
            {
                letter = "B-";
            }
            else
            {
                letter = "B";
            }
        }
        else if (grade >= 70)
        {
               if (grade >= 77)
            {
                letter = "C+";
            }

            else if (grade < 73)
            {
                letter = "C-";
            }
            else
            {
                letter = "C";
            }
            
        }
        else if (grade >= 60)
        {
               if (grade >= 67)
            {
                letter = "D+";
            }

            else if (grade < 63)
            {
                letter = "D-";
            }
            else
            {
                letter = "D";
            }
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        if (letter == "A" || letter == "A-")
        {
            Console.WriteLine("Congratulations on this great feat!");
        }
        else if (letter == "B" || letter == "B+" || letter == "B-")
        {
            Console.WriteLine("Congratulations. Go for a distinction next time!");
        }
        else if (letter == "C" || letter == "C+" || letter == "C-")
        {
            Console.WriteLine("Good job. You can do better!");
        }
        else if (letter == "D" || letter == "D+" || letter == "D-")
        {
            Console.WriteLine("You can do better.");
        }
        else
        {
            Console.WriteLine("You should put in more effort.");
        }

    }
}