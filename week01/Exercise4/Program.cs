using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int response = -1;

        List<int> numbers = new List<int>();

        while (response != 0)
        {
            Console.Write("Enter Number: ");
            string userResponse = Console.ReadLine();
            response = int.Parse(userResponse);

            if (response != 0)
            {
                numbers.Add(response);
            }

        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is : {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max number is {max}");
    }
}