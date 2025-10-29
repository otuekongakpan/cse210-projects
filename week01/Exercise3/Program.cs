using System;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int guess = -1;
        int magicNumber = randomGenerator.Next(1, 101);

        int count = 0;
        string response = "yes";

        while (response == "yes")
        {
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    count += 1;
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    count += 1;
                }
                else
                {
                    count += 1;
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You tried {count} times");

                }



            }
        }
    }
}