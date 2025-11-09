using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
  

        int choice = 0;

        while (choice != 5)
        {

            Console.WriteLine("Please select one of the following choices: ");
            
            List<string> menu = new List<string>()
            {
                "Write",
                "Display",
                "Load",
                "Save",
                "Quit"
            };

            int number = 1;
            foreach (string item in menu)
            {
                Console.WriteLine($"{number}. {item}");
                number++;
            }

            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                journal.WriteEntry();
            }

            else if (choice == 2)
            {
                journal.DisplayAll();

            }
            else if (choice == 3)
            {
                Console.WriteLine("loading file......");
                journal.LoadFromFile();
            }
            else if (choice == 4)
            {
                Console.WriteLine("saving to file......");
                journal.SaveToFile();
                Console.WriteLine("Entries have been saved into a file");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye for now!");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}