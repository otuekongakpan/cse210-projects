using System;

class Program
{
static void Main(string[] args)
    {
        Reference reference = new Reference("Psalms", 23, 1);
        Scripture scripture = new Scripture(reference, "The Lord is my Shepherd, I shall not want");

        while (true)
        {
            Console.Clear();

            reference.GetDisplayText();

            scripture.GetDisplayText();
            Console.WriteLine("Press Enter to hide more words or type 'quit' to finish.");

            string input = Console.ReadLine();

            if (input != null && input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                reference.GetDisplayText();
                scripture.GetDisplayText();

                break;
            }
        }
    }

}