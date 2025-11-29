using System;

class Program
{
    static void Main(string[] args)
    {
                int choice = 0;

        while (choice != 4)
        {

            Console.WriteLine("Please select one of the following activities: ");

            List<string> menu = new List<string>()
            {
                "Breathing Activity",
                "Reflecting Activity",
                "Listing Activity",
                "Quit"
            };

            int number = 1;
            foreach (string item in menu)
            {
                Console.WriteLine($"{number}. {item}");
                number++;
            }

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity a1 = new BreathingActivity("Breathing", "This activity will help you relax by walking through your breathing in and out slowly. Clear your mind and focus on your breathing", 0);
                a1.Run();
            }

            else if (choice == 2)
            {
                ReflectingActivity a2 = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                a2.Run();
            }
            
            else if (choice == 3)
            {
                ListingActivity a3 = new ListingActivity(0, 0, "Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
                a3.Run();                
            }
            else if (choice == 4)
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