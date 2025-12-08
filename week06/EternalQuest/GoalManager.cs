using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager(int score)
    {
        _score = score;
    }

    int choice = 0;
    public void Start()
    {
        while (choice != 6)
        {
            Console.WriteLine($"You have {_score} points");
            List<string> menu = new List<string>()
            {
                "Create New Goal",
                "List Goals",
                "Save Goals",
                "Load Goals",
                "Record Event",
                "Quit"
            };

            int number = 1;
            foreach (string item in menu)
            {
                Console.WriteLine($"{number}. {item}");
                number++;
            }
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }

            else if (choice == 2)
            {
                ListGoalNames();
            }

            else if (choice == 3)
            {
                SaveGoals();
            }

            else if (choice == 4)
            {
                LoadGoals();
            }

            else if (choice == 5)
            {
                RecordEvent();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Goodbye for now!");
            }

            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            string checkbox;
            if (goal.IsComplete() == true)
            {
                checkbox = "[X]";
            }
            else
            {
                checkbox = "[ ]";
            }
            Console.WriteLine($"{checkbox} {goal.GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            string checkbox;
            if (goal.IsComplete() == true)
            {
                checkbox = "[X]";
            }
            else
            {
                checkbox = "[ ]";
            }
            Console.WriteLine($"{checkbox} {goal.GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        List<string> menu = new List<string>()
        {
            "Simple Goal",
            "Eternal Goal",
            "Checklist Goal"
         }; 
         
        int number = 1; 
        foreach (string item in menu) 
        {
            Console.WriteLine($"{number}. {item}");
            number++; 
        }

        Console.Write("Choose: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        bool isComplete = false;

        if (choice == 1)
        {
            SimpleGoal g = new SimpleGoal(name, description, points, isComplete);
            _goals.Add(g);
            
        }
        else if (choice == 2)
        {
            EternalGoal g = new EternalGoal(name, description, points);
            _goals.Add(g);
        }
        else if (choice == 3)
        {
            Console.Write("How many times does this need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            int amountCompleted = 0;

            ChecklistGoal g = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
            _goals.Add(g);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Goal g = _goals[index];

        int pointsEarned = g.RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"Your new total score is {_score}.");
    }

    public void SaveGoals()
    {
        string filename = "Goals.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }
    
    public void LoadGoals()
    {
        string filename = "Goals.txt";

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] typeSplit = line.Split(":");
            string goalType = typeSplit[0];
            string data = typeSplit[1];

            string[] parts = data.Split(",");

            if (goalType == "SimpleGoal")
            {
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                bool isComplete = bool.Parse(parts[3]);

                _goals.Add(new SimpleGoal(name, description, points, isComplete));
            }
            else if (goalType == "EternalGoal")
            {
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);

                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                int target = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountCompleted));
            }
        }
    }

}